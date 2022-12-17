using System;
using System.Collections.Generic;
using System.Linq;
using Excel = Microsoft.Office.Interop.Excel;


namespace ExcelCreateNetFramework
{
    public class OpenCloseClaimsByRelatedEntityModel
    {
        public IEnumerable<ItemModel> Open { get; set; }
        public IEnumerable<ItemModel> Closed { get; set; }
        public List<ItemModel> All { get; set; }



        public class ItemModel
        {
            public string Name { get; set; }
            public double Value { get; set; }
        }
    }

    internal class Program
    {
       
        

        static void Main(string[] args)
        {

            List<OpenCloseClaimsByRelatedEntityModel.ItemModel> all = new List<OpenCloseClaimsByRelatedEntityModel.ItemModel>();
            List<OpenCloseClaimsByRelatedEntityModel.ItemModel> open = new List<OpenCloseClaimsByRelatedEntityModel.ItemModel>();
            List<OpenCloseClaimsByRelatedEntityModel.ItemModel> closed = new List<OpenCloseClaimsByRelatedEntityModel.ItemModel>();

            all.Add(new OpenCloseClaimsByRelatedEntityModel.ItemModel { Name = "Non-Low Dollar", Value = 27 });
            all.Add(new OpenCloseClaimsByRelatedEntityModel.ItemModel { Name = "Low Dollar", Value = 46 });

            open.Add(new OpenCloseClaimsByRelatedEntityModel.ItemModel { Name = "Non-Low Dollar", Value = 25 });
            open.Add(new OpenCloseClaimsByRelatedEntityModel.ItemModel { Name = "Low Dollar", Value = 45 });

            closed.Add(new OpenCloseClaimsByRelatedEntityModel.ItemModel { Name = "Non-Low Dollar", Value = 2 });
            closed.Add(new OpenCloseClaimsByRelatedEntityModel.ItemModel { Name = "Low Dollar", Value = 1 });



            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet1;
            Excel.Worksheet xlWorkSheet2;
            object misValue = System.Reflection.Missing.Value;
            Excel.Range formatRange;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            Excel.Sheets worksheets = xlWorkBook.Worksheets;

            xlWorkSheet1 = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            xlWorkSheet2 = (Excel.Worksheet)worksheets.Add(worksheets[1], Type.Missing, Type.Missing, Type.Missing);

            xlWorkSheet1.Name = "Chart";
            xlWorkSheet2.Name = "Data";

            xlWorkSheet2.Select();
            xlWorkBook.Save();

            //xlWorkSheet1 = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            //xlWorkSheet2 = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);







            xlWorkSheet2.Cells[1, 1] = "Open";
            xlWorkSheet2.Cells[2, 1] = "Low Dollar";
            xlWorkSheet2.Cells[3, 1] = "Non-Low Dollar";

            xlWorkSheet2.Cells[1, 2] = "Low Dollar vs Non-low dollar claims";
            xlWorkSheet2.Cells[2, 2] = open[1].Value.ToString();
            xlWorkSheet2.Cells[3, 2] = open[0].Value.ToString();



            //Create Chart
            Excel.Range crange;
            Excel.ChartObjects cb = (Excel.ChartObjects)xlWorkSheet1.ChartObjects(Type.Missing);
            Excel.ChartObject cbc = cb.Add(10, 30, 300, 300);
            Excel.Chart cp = cbc.Chart;

            crange = xlWorkSheet2.get_Range("A1", "D5");
            cp.SetSourceData(crange, misValue);
            cp.ChartType = Excel.XlChartType.xlColumnClustered;




            xlWorkBook.SaveAs(@"d:\Excel\test.xlsx", Excel.XlFileFormat.xlWorkbookDefault, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive,misValue,misValue,misValue,misValue,misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            DeallocateObject(xlWorkSheet1);
            DeallocateObject(xlWorkSheet2);
            DeallocateObject(xlWorkBook);
            DeallocateObject(xlApp);
        }


        private static void DeallocateObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                Console.WriteLine("Exception Occurred while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}

