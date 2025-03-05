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
            // Export DataTable to Excel
            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Sheet1");
                worksheet.Cells["A1"].LoadFromDataTable(dataTable, true);
                var file = new FileInfo(filePath ?? "DefaultFilePath.xlsx");
                package.SaveAs(file);
            }
        }
    }
}
