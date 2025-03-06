using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using OfficeOpenXml;
using System.Windows.Forms;

namespace InvestInMe_Mini_Project
{
    class ExcelExporter
    {
        public void ExportToExcel(DataTable dataTable, string filePath)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            try 
            {
                // Ensure directory exists
                var directory = Path.GetDirectoryName(filePath);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                var file = new FileInfo(filePath);
                using (var package = file.Exists ? new ExcelPackage(file) : new ExcelPackage())
                {
                    var worksheet = package.Workbook.Worksheets.FirstOrDefault() ?? package.Workbook.Worksheets.Add("Sheet1");

                    var startRow = worksheet.Dimension?.End.Row + 1 ?? 1;
                    worksheet.Cells[startRow, 1].LoadFromDataTable(dataTable, true);
                    package.SaveAs(file);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving file: {ex.Message}");
            }
        }
    }
}
