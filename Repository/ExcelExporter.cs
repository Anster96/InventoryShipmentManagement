using System;
using System.Collections.Generic;
using ClosedXML.Excel;
using System.Reflection;
using System.Windows;

public class ExcelExporter<T>
{
    public void ExportToExcel(List<T> data, string filePath)
    {
        var workbook = new XLWorkbook();
        var worksheet = workbook.Worksheets.Add("Sheet1");

        // Adding headers
        var properties = typeof(T).GetProperties();
        for (int i = 0; i < properties.Length; i++)
        {
            worksheet.Cell(1, i + 1).Value = properties[i].Name;
        }

        // Adding data
        for (int i = 0; i < data.Count; i++)
        {
            for (int j = 0; j < properties.Length; j++)
            {
                var value = properties[j].GetValue(data[i]);

                if (value != null)
                {
                    worksheet.Cell(i + 2, j + 1).Value = value.ToString();
                }
                else
                {
                    worksheet.Cell(i + 2, j + 1).Value = string.Empty;
                }
                

                //if (value != null)
                //{
                //    worksheet.Cell(i + 2, j + 1).SetValue(value);
                //}
                //else
                //{
                //    worksheet.Cell(i + 2, j + 1).Value = string.Empty;
                //}
            }
        }

        // Saving the workbook
        workbook.SaveAs(filePath);

        // Inform the user
        MessageBox.Show("Data exported successfully to " + filePath);
    }
}
