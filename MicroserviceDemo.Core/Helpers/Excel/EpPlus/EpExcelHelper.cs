using OfficeOpenXml;

namespace MicroserviceDemo.Core.Helpers.Excel.EpPlus
{
    public class EpExcelHelper
    {
        public static byte[] ExportToExcel<T>(T dataFields, List<T> dataList, string excelSheetName, string fileName)
        {
            using (var excelPackage = new ExcelPackage())
            {
                var worksheet = excelPackage.Workbook.Worksheets.Add(excelSheetName);

                int rowOrder = 1;
                int columnOrder = 1;

                //Add Headers
                for (int i = 0; i < dataList.Count; i++)
                {
                    worksheet.Cells[rowOrder, columnOrder].Value = dataFields;
                    rowOrder++;
                }

                rowOrder = 2;
                foreach (var item in dataList)
                {
                    worksheet.Cells[rowOrder, columnOrder].Value = item;
                    rowOrder++;
                }

                using (var stream = new MemoryStream())
                {
                    var xlFile = new FileInfo(fileName + ".xlsx");
                    excelPackage.SaveAs(xlFile);//save the Excel file
                    var content = stream.ToArray();
                    return content;
                }
            }
        }
    }
}
