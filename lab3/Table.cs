using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace lab3
{
    public partial class Table : Form
    {
        public Table()
        {
            InitializeComponent();
            MaximizeBox = false;
            dataGridViewTable.RowHeadersVisible = false;

        }

        public void Input(double x, double plusY, double minusY)
        {

            dataGridViewTable.Rows.Add(x, plusY, minusY);
        }

        private void SaveData_Click(object sender, EventArgs e)
        {
            try
            {
                Excel.Application ExcelApp = new Excel.Application();
                Excel.Workbook ExcelWorkBook;
                Excel.Worksheet ExcelWorkSheet;

                //Построение книги
                ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
                //Построение таблицы
                ExcelWorkSheet = (Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);

                for (int i = 0; i < dataGridViewTable.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridViewTable.ColumnCount; j++)
                    {
                        ExcelApp.Cells[i + 1, j + 1] = dataGridViewTable.Rows[i].Cells[j].Value;
                    }
                }
                ExcelApp.Visible = true;
                ExcelApp.UserControl = true;
            }
            catch
            {
                MessageBox.Show("На вашем устройстве нельзя запустить Excel", "Ошибка вывода данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            /*private void button1_Click(object sender, EventArgs e)
            {
                Excel.Application xlApp;
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;

                xlApp = new Excel.Application();
                xlWorkBook = xlApp.Workbooks.Add(misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                for (int i = 0; i < chart1.Series.Count; i++)
                {
                    xlWorkSheet.Cells[1, 1] = "";
                    xlWorkSheet.Cells[1, 2] = "DateTime";//put your column heading here
                    xlWorkSheet.Cells[1, 3] = "Data";// put your column heading here

                    for (int j = 0; j < chart1.Series[i].Points.Count; j++)
                    {
                        xlWorkSheet.Cells[j + 2, 2] = chart1.Series[i].Points[j].XValue;
                        xlWorkSheet.Cells[j + 2, 3] = chart1.Series[i].Points[j].YValues[0];
                    }
                }

                Excel.Range chartRange;

                Excel.ChartObjects xlCharts = (Excel.ChartObjects)xlWorkSheet.ChartObjects(Type.Missing);
                Excel.ChartObject myChart = (Excel.ChartObject)xlCharts.Add(10, 80, 300, 250);
                Excel.Chart chartPage = myChart.Chart;

                chartRange = xlWorkSheet.get_Range("B2", "c5");//update the range here
                chartPage.SetSourceData(chartRange, misValue);
                chartPage.ChartType = Excel.XlChartType.xlColumnClustered;

                xlWorkBook.SaveAs("csharp.net-informations.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();

                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlApp);

                MessageBox.Show("Excel file created , you can find the file c:\\csharp.net-informations.xls");
            }

            private void releaseObject(object obj)
            {
                try
                {
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                    obj = null;
                }
                catch (Exception ex)
                {
                    obj = null;
                    MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
                }
                finally
                {
                    GC.Collect();
                }
            }*/     
        }
    }
}
