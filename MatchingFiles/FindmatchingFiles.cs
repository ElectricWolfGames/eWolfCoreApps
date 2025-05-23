using System.Security.Cryptography;

namespace MatchingFiles
{
    internal class FindmatchingFiles
    {
        private Dictionary<string, string> HashSet = new Dictionary<string, string>();

        public static string ComputeFileHash(string path)
        {
            using (var sha = SHA256.Create())
            using (var stream = File.OpenRead(path))
            {
                var hash = sha.ComputeHash(stream);
                Console.Write(".");
                return Convert.ToBase64String(hash);
            }
        }

        public void Compera(string path)
        {
            var folders = Directory.GetDirectories(path);
            foreach (var folder in folders)
            {
                Compera(folder);
            }

            var files = Directory.GetFiles(path);

            foreach (var fileName in files)
            {
                var temp = ComputeFileHash(fileName);

                if (HashSet.ContainsKey(temp))
                {
                    FoundMatch(HashSet[temp], fileName);
                }
                else
                {
                    HashSet.Add(temp, fileName);
                }
            }
        }

        private void FoundMatch(string fileNameA, string fileNameB)
        {
            Console.WriteLine("MATCH");
            Console.WriteLine(fileNameA);
            Console.WriteLine(fileNameB);

            string pathLogs = $"E:\\temp\\Matches.txt";
            File.AppendAllText(pathLogs, fileNameA + Environment.NewLine);
            File.AppendAllText(pathLogs, fileNameB + Environment.NewLine);
        }
    }
}