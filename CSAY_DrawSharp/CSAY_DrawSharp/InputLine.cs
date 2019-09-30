using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace CSAY_DrawSharp
{
    public partial class FrmInputLine : Form
    {
        public static int NumberofLine;
        int i;
        string path;

        public static string[] LineName= new string[3000];
        public static float[,] Origin = new float[3000, 3];
        public static float[,] InitialPoint = new float[3000, 3];
        public static float[,] FinalPoint = new float[3000, 3];
        public static float[,] LineColor = new float[3000, 3];

        public static float[,] TempOrigin = new float[3000, 3];
        public static float[,] TempInitialPoint = new float[3000, 3];
        public static float[,] TempFinalPoint = new float[3000, 3];
        public static float[,] TempLineColor = new float[3000, 3];

        public FrmInputLine()
        {
            InitializeComponent();
        }

        private void FrmInputLine_Load(object sender, EventArgs e)
        {
            try
            {
                SetGridColorAndFont();
            }
            catch
            {

            }
        }
        public void SetGridColorAndFont()
        {
            this.dataGridView.DefaultCellStyle.Font = new Font("Comic Sans MS", 12);
            this.dataGridView.DefaultCellStyle.ForeColor = Color.Black;
            this.dataGridView.DefaultCellStyle.SelectionForeColor = Color.White;
            //this.dataGridView.DefaultCellStyle.SelectionBackColor = Color.Purple;
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
        }

        public void Generaterows()
        {
            int cell_val = 0;
            try
            {
                NumberofLine = Convert.ToInt32(TxtNumberOfLine.Text);
            }
            catch
            {
                //MessageBox.Show("Del_t or N missing !!!");
            }
            dataGridView.Rows.Clear();

            for (i = 0; i < NumberofLine; i++)
            {
                i = dataGridView.Rows.Add();

                if (i == 0)
                {
                    cell_val = 1;
                    dataGridView.Rows[i].Cells[0].Value = cell_val;
                }
                else
                {
                    cell_val = cell_val + 1;
                    dataGridView.Rows[i].Cells[0].Value = cell_val;
                }

            }
        }

        private void TxtNumberOfLine_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Generaterows();
            }
            catch
            {

            }
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfiledialog1 = new OpenFileDialog();
            openfiledialog1.Filter = "Excel Sheet(*.xlsx)|*.xlsx|Excel Sheet(*.xls)|*.xls|All Files(*.*)|*.*";
            openfiledialog1.FilterIndex = 1;

            if (openfiledialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = openfiledialog1.FileName;
            }
            else if (openfiledialog1.ShowDialog() == System.Windows.Forms.DialogResult.Cancel) return;

            dataGridView.DataSource = null;

            for (int j = 0; j < dataGridView.Rows.Count - 1; j++)
            {
                dataGridView.Rows.RemoveAt(j);
                j--;
                while (dataGridView.Rows.Count == 0)
                    continue;
            }

            Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            Excel.Workbooks workbooks = app.Workbooks;

            Excel.Workbook workbook = workbooks.Open(path);
            Excel.Worksheet worksheet = workbook.ActiveSheet;
            try
            {
                int rcount = NumberofLine;

                int i = 0;
                int k;
                for (i = 0; i < rcount; i++)
                {
                    dataGridView.Rows.Add();
                    for (k = 0; k <= 12; k++)
                    {
                        dataGridView.Rows[i].Cells[k].Value = worksheet.Cells[i + 3, k + 2].value;
                    }
                    //worksheet.cells[rows, column].value; here rows column starts from 1 and rows starts from 1 of excel.
                }

                workbook.Close();
                app.Quit();
                Marshal.ReleaseComObject(workbook);
                Marshal.ReleaseComObject(workbooks);
                Marshal.ReleaseComObject(worksheet);
                // Marshal.ReleaseComObject(rcount);

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                workbook.Close();
                app.Quit();
                Marshal.ReleaseComObject(workbook);
                Marshal.ReleaseComObject(workbooks);
                Marshal.ReleaseComObject(worksheet);
            }
            MessageBox.Show("IMPORT COMPLETED SUCESSFULLY !");
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        { 
            int i, k;
            NumberofLine = Convert.ToInt32(TxtNumberOfLine.Text);
            //store from grid to array
            //origin
            int index;
            for (i = 0; i < NumberofLine; i++)
            {
                LineName[i] = (dataGridView.Rows[i].Cells[0].Value).ToString();

                index = 0; // origin
                for (k = 1; k <= 3; k++)
                {
                    Origin[i, index] = Convert.ToSingle(dataGridView.Rows[i].Cells[k].Value);
                    TempOrigin[i, index] = Origin[i, index];
                    index++;
                }
                index = 0; // initial point
                for (k = 4; k <= 6; k++)
                {
                    InitialPoint[i, index] = Convert.ToSingle(dataGridView.Rows[i].Cells[k].Value);
                    TempInitialPoint[i, index] = InitialPoint[i, index];
                    index++;
                }
                index = 0; // final point
                for (k = 7; k <= 9; k++)
                {
                    FinalPoint[i, index] = Convert.ToSingle(dataGridView.Rows[i].Cells[k].Value);
                    TempFinalPoint[i, index] = FinalPoint[i, index];
                    index++;
                }
                index = 0; // Line color
                for (k = 10; k <= 12; k++)
                {
                    LineColor[i, index] = Convert.ToSingle(dataGridView.Rows[i].Cells[k].Value);
                    TempLineColor[i, index] = LineColor[i, index];
                    index++;
                }
                //worksheet.cells[rows, column].value; here rows column starts from 1 and rows starts from 1 of excel.
            }

            //-----------------------------------------------------------------------------------------
            FrmMain fm = (FrmMain)Application.OpenForms["FrmMain"];

            fm.treeView1.Nodes[0].Nodes.Clear();
            for (i = 0; i < Convert.ToInt32(NumberofLine); i++)
            {
                fm.treeView1.Nodes[0].Nodes.Add("LineNode" + i.ToString(), LineName[i]);
            }
            //-----------------------------------------------------------------------------------------

            MessageBox.Show("Data Accepted ! \nContinue Drawing lines...");
        }
    }
}
