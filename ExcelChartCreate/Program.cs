using System;
using Excel = Microsoft.Office.Interop.Excel;


namespace ExcelChartCreate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            xlWorkSheet.Cells[1, 1] = "SL";
            xlWorkSheet.Cells[1, 2] = "Name";
            xlWorkSheet.Cells[1, 3] = "CTC";
            xlWorkSheet.Cells[1, 4] = "DA";
            xlWorkSheet.Cells[1, 5] = "HRA";
            xlWorkSheet.Cells[1, 6] = "Conveyance";
            xlWorkSheet.Cells[1, 7] = "Medical Expenses";
            xlWorkSheet.Cells[1, 8] = "Special";
            xlWorkSheet.Cells[1, 9] = "Bonus";
            xlWorkSheet.Cells[1, 10] = "TA";
            xlWorkSheet.Cells[1, 11] = "TOTAL";
            xlWorkSheet.Cells[1, 11] = "Contribution to PF";
            xlWorkSheet.Cells[1, 12] = "Profession Tax";
            xlWorkSheet.Cells[1, 13] = "TDS";
            xlWorkSheet.Cells[1, 14] = "Salary Advance";
            xlWorkSheet.Cells[1, 15] = "TOTAL";
            xlWorkSheet.Cells[1, 16] = "NET PAY";

            Excel.Application xlApp1 = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp1.Workbooks.Open
               (@"C:\Sample\Employee Data.xlsx");
            Excel._Worksheet xlWorksheet = (Excel._Worksheet)xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;

            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;

            for (int i = 1; i <= rowCount; i++)
            {
                for (int j = 1; j <= colCount; j++)
                {
                    Console.WriteLine(xlRange.Cells[i, j]);
                    xlWorkSheet.Cells[i, j] = xlRange.Cells[i, j];
                }
            }

            Console.ReadLine();



        }

    }
}
