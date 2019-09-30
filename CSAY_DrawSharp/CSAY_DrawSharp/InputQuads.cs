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
    public partial class FrmInputQuads : Form
    {
        public static int NumberofQuads;
        int i;
        string path;

        public static float[,] TempQuadOrigin = new float[3000, 3];
        public static float[,] TempQPoint1 = new float[3000, 3];
        public static float[,] TempQPoint2 = new float[3000, 3];
        public static float[,] TempQPoint3 = new float[3000, 3];
        public static float[,] TempQPoint4 = new float[3000, 3];
        public static float[,] TempQuadColor = new float[3000, 3]; 

        public static string[] QuadName = new string[3000]; 
        public static float[,] QuadOrigin = new float[3000, 3]; 
        public static float[,] QPoint1 = new float[3000, 3];
        public static float[,] QPoint2 = new float[3000, 3];
        public static float[,] QPoint3 = new float[3000, 3];
        public static float[,] QPoint4 = new float[3000, 3];  
        public static float[,] QuadColor = new float[3000, 3]; 


        public FrmInputQuads()
        {
            InitializeComponent();
        }

        private void FrmInputQuads_Load(object sender, EventArgs e)
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
                NumberofQuads = Convert.ToInt32(TxtNumberOfQuads.Text);
            }
            catch
            {
                //MessageBox.Show("Del_t or N missing !!!");
            }
            dataGridView.Rows.Clear();

            for (i = 0; i < NumberofQuads; i++)
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

        private void TxtNumberOfQuads_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Generaterows();
            }
            catch
            {

            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
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
                int rcount = NumberofQuads;

                int i = 0;
                int k;
                for (i = 0; i < rcount; i++)
                {
                    dataGridView.Rows.Add();
                    for (k = 0; k <= 18; k++)
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

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            int i, k;
            NumberofQuads = Convert.ToInt32(TxtNumberOfQuads.Text);
            //store from grid to array
            //origin
            int index;
            for (i = 0; i < NumberofQuads; i++)
            {
                QuadName[i] = (dataGridView.Rows[i].Cells[0].Value).ToString();

                index = 0; // origin
                for (k = 1; k <= 3; k++)
                {
                    QuadOrigin[i, index] = Convert.ToSingle(dataGridView.Rows[i].Cells[k].Value);
                    TempQuadOrigin[i, index] = QuadOrigin[i, index];
                    index++;
                }
                index = 0; // point 1
                for (k = 4; k <= 6; k++)
                {
                    QPoint1[i, index] = Convert.ToSingle(dataGridView.Rows[i].Cells[k].Value);
                    TempQPoint1[i, index] = QPoint1[i, index];
                    index++;
                }
                index = 0; // point 2
                for (k = 7; k <= 9; k++)
                {
                    QPoint2[i, index] = Convert.ToSingle(dataGridView.Rows[i].Cells[k].Value);
                    TempQPoint2[i, index] = QPoint2[i, index];
                    index++;
                }
                index = 0; // point 3
                for (k = 10; k <= 12; k++)
                {
                    QPoint3[i, index] = Convert.ToSingle(dataGridView.Rows[i].Cells[k].Value);
                    TempQPoint3[i, index] = QPoint3[i, index];
                    index++;
                }
                index = 0; // point 4
                for (k = 13; k <= 15; k++)
                {
                    QPoint4[i, index] = Convert.ToSingle(dataGridView.Rows[i].Cells[k].Value);
                    TempQPoint4[i, index] = QPoint4[i, index];
                    index++;
                }
                index = 0; // Line color
                for (k = 16; k <= 18; k++)
                {
                    QuadColor[i, index] = Convert.ToSingle(dataGridView.Rows[i].Cells[k].Value);
                    TempQuadColor[i, index] = QuadColor[i, index];
                    index++;
                }
                //worksheet.cells[rows, column].value; here rows column starts from 1 and rows starts from 1 of excel.
            }

            //-----------------------------------------------------------------------------------------
            FrmMain fm = (FrmMain)Application.OpenForms["FrmMain"];

            fm.treeView1.Nodes[2].Nodes.Clear();
            for (i = 0; i < Convert.ToInt32(NumberofQuads); i++)
            {
                fm.treeView1.Nodes[2].Nodes.Add("QuadNode" + i.ToString(), QuadName[i]);
            }
            //-----------------------------------------------------------------------------------------
            MessageBox.Show("Data Accepted ! \nContinue Drawing Quadrilaterals...");
        }
    }
   
}
