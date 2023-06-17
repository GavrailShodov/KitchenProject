using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenProject.Services
{
    internal class ExelService
    {
        public void WriteExelFile(Dictionary<string, List<double>> materials,string fileName)
        {
            using (var package = new ExcelPackage())
            {
                // Create a worksheet
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Sheet1");

                // Define the column headers
                worksheet.Cells[1, 1].Value = "X";
                worksheet.Cells[1, 2].Value = "Y";
                worksheet.Cells[1, 3].Value = "Count";

                var x = materials["x"];
                var y = materials["y"];
                var count = materials["count"];
                //Write items to the worksheet
                for (int i = 0; i < materials["x"].Count; i++)
                {
                worksheet.Cells[ i + 2, 1].Value = x[i];
                worksheet.Cells[i + 2, 2].Value = y[i];
                worksheet.Cells[i + 2, 3].Value = count[i];
                }

                // Save the Excel package to a file
                string pathDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string path = Path.Combine(pathDesktop,fileName + ".xlsx");
                FileInfo file = new FileInfo(path);
                package.SaveAs(file);
            }
        }

    }
}
