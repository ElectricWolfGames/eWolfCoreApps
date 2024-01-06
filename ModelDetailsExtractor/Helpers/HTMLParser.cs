namespace ExtractModelDetails.Helpers
{
    public static class HTMLParser
    {
        public static string GetValue(string line)
        {
            if (line.Contains("<a "))
            {
                line = line.Replace("table-group-divider\">", "");
                line = line.Replace("<tr>", "");
                line = line.Replace("<td><a", "");
                line = line.Replace("</a>", "");
            }

            string[] l = line.Split(">");
            return l[1];
        }
    }
}