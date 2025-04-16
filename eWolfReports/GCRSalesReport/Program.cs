using OfficeOpenXml;
using System.Data;

namespace GCRSalesReport
{
    internal class Program
    {
        private static List<ItemSales> _itemSales = [];
        private static List<Peoples> _peoples = [];

        private static void GetDataTableFromExcel(string fileName, bool hasHeader = true)
        {
            FileInfo existingFile = new FileInfo(fileName);
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage package = new ExcelPackage(fileName))
            {
                Console.WriteLine($"Processing {fileName}");

                ExcelWorksheet worksheet = package.Workbook.Worksheets[3];
                ProcessItems(worksheet);

                worksheet = package.Workbook.Worksheets[2];
                ProcessPeople(worksheet);
            }
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string path = "E:\\GCR\\Stand\\Stand-Sales\\2025\\";

            foreach (var fileInfo in Directory.GetFiles(path))
            {
                GetDataTableFromExcel(fileInfo);
            }

            _itemSales = _itemSales.OrderByDescending(x => x.Quantity * x.Value).ToList();

            foreach (var item in _itemSales)
            {
                if (item.Quantity != 0)
                {
                    Console.WriteLine($"{item.Name},{item.Quantity},£{item.Value},£{item.TotalCost}");
                }
            }

            Console.WriteLine();
            Console.WriteLine();

            _peoples = _peoples.OrderByDescending(x => x.Totals).ToList();

            foreach (var item in _peoples)
            {
                if (!string.IsNullOrEmpty(item.Name))
                {
                    Console.WriteLine($"{item.Name}  Days {item.Totals}");
                }
            }
        }

        private static void ProcessItems(ExcelWorksheet worksheet)
        {
            int colCount = worksheet.Dimension.End.Column;
            int rowCount = worksheet.Dimension.End.Row;
            for (int row = 21; row <= rowCount; row++)
            {
                if (worksheet.Cells[row, 2].Value == null)
                    continue;

                string name = worksheet.Cells[row, 2].Value.ToString();

                if (name == "Name")
                    continue;

                if (worksheet.Cells[row, 3].Value == null)
                    continue;

                if (name == "Coster")
                    name = "Coaster";

                var item = _itemSales.FirstOrDefault(x => x.Name == name);
                if (item == null)
                {
                    item = new ItemSales();
                    _itemSales.Add(item);
                    item.Name = name;
                }

                var price = worksheet.Cells[row, 3].Value;
                item.Value = (double)price;

                for (int col = 4; col < 6; col++)
                {
                    if (worksheet.Cells[row, 4].Value != null)
                    {
                        var value = worksheet.Cells[row, 4].Value;
                        item.Quantity += (double)value;
                        item.TotalCost += (float)((double)value * (double)price);
                    }
                }
            }
        }

        private static void ProcessPeople(ExcelWorksheet worksheet)
        {
            int colCount = worksheet.Dimension.End.Column;
            int rowCount = worksheet.Dimension.End.Row;
            for (int row = 2; row <= rowCount; row++)
            {
                if (worksheet.Cells[row, 1].Value == null)
                    continue;

                string name = worksheet.Cells[row, 1].Value.ToString();
                if (name == "Rudds"
                    || name == "Trains GCRN"
                    || name == "Rudds Gate"
                    || name == "Railway (With Barry)"
                    || name == "Train Numbers"
                    || name == "Stand Numbers")
                {
                    continue;
                }

                name = name.Replace("(PTS)", string.Empty);
                name = name.Replace("[S]", string.Empty);
                name = name.Replace("[C]", string.Empty);
                name = name.Trim();

                var item = _peoples.FirstOrDefault(x => x.Name == name);
                if (item == null)
                {
                    item = new Peoples();
                    _peoples.Add(item);

                    item.Name = name;
                    //Console.WriteLine($"{name}");
                }

                for (int col = 2; col < 6; col++)
                {
                    if (worksheet.Cells[row, col].Value == null)
                        continue;

                    if (worksheet.Cells[1, col].Value != null && worksheet.Cells[1, col].Value.ToString() == "Dismantle")
                        continue;

                    if (worksheet.Cells[1, col].Value != null && worksheet.Cells[1, col].Value.ToString() == "Set-up")
                        continue;

                    string action = worksheet.Cells[row, col].Value.ToString();
                    bool done = false;
                    if (action == "Set-up" || action == "set-up" || action == "dismantle" || action == "Dismantle")
                    {
                        item.SetDays += 1;
                        done = true;
                    }
                    if (action == "WH" || action.Contains("Meet and greet") || action == "Quorn")
                    {
                        item.WH += 1;
                        done = true;
                    }
                    if (action.Contains("Yes") || action.Contains("Stand") || action.Contains("Railway"))
                    {
                        item.Days += 1;
                        done = true;
                    }
                    if (action == "Tickets" || action.Contains("Gate") || action.Contains("Rudds"))
                    {
                        item.Rudds += 1;
                        done = true;
                    }
                    if (action.Contains("Train"))
                    {
                        item.Trains += 1;
                        done = true;
                    }
                    if (action.Contains("no") || action.Contains("No"))
                    {
                        done = true;
                    }
                    if (done == false)
                    {
                        int i = 0;
                        i++;
                        //Console.WriteLine($"missing data for : {action}");
                    }
                }
            }
        }
    }
}