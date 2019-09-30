using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpGL;

namespace CSAY_DrawSharp
{
    public partial class FrmMain : Form
    {
        int i,j,k;
        int redclr, greenclr, blueclr;
        float rotateline = 0, rotateWireCube = 0, rotatequads=0, rotatecylinder = 0; 
        float ScaleLine = 1.0f;
        bool AllowDrawingLines = false, AllowDrawingWireCube = false, AllowDrawingQuads = false;
        public static bool AllowCubeNodeDraw = false;
        float Cubesize = 1;
        float numberofcubeX=1, numberofcubeY = 1, numberofcubeZ = 1;
        float OriginX,OriginY, OriginZ;


        public FrmMain()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            MenuStripMain.ForeColor = Color.LightGray;
            MainMenuStrip.BackColor = Color.Black;

            treeView1.ForeColor = Color.White;

            SetFontAndColorOfDatagridview();
            LoadElementsInComboBox();

           // GenerateCubeDatagridRows();

            GenerateTreeViewLevel1();
        }
        public void LoadElementsInComboBox()
        {
            ComboBoxMain.Items.Add("Line");
            ComboBoxMain.Items.Add("Cube");
            ComboBoxMain.Items.Add("Quads");
        }
        public void GenerateCubeDatagridColumns()
        {
             dataGridView.ColumnCount = 4;

             dataGridView.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
             dataGridView.Columns[0].Width = 100;

             dataGridView.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
             dataGridView.Columns[1].Width = 40;

             dataGridView.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
             dataGridView.Columns[2].Width = 40;

             dataGridView.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
             dataGridView.Columns[3].Width = 40;

             dataGridView.Columns[0].Name = "Properties";
             dataGridView.Columns[1].Name = "X";
             dataGridView.Columns[2].Name = "Y";
             dataGridView.Columns[3].Name = "Z";

        }
        public void GenerateLineDatagridRows() //Line
        { 
            for (i = 0; i < 4; i++)
            {
                dataGridView.Rows.Add();
            }

            dataGridView.Rows[0].Cells[0].Value = "Origin";
            dataGridView.Rows[1].Cells[0].Value = "Initial";
            dataGridView.Rows[2].Cells[0].Value = "Final";
            dataGridView.Rows[3].Cells[0].Value = "Color";
        }

        public void GenerateCubeDatagridRows() //Cube
        {
            for (i=0;i<4;i++)
            {
                dataGridView.Rows.Add();
            }
            
            dataGridView.Rows[0].Cells[0].Value = "Origin";
            dataGridView.Rows[1].Cells[0].Value = "Initial";
            dataGridView.Rows[2].Cells[0].Value = "Side";
            dataGridView.Rows[3].Cells[0].Value = "Color";
        }

        public void GenerateQuadsDatagridRows() //Quads
        {
            for (i = 0; i < 6; i++)
            {
                dataGridView.Rows.Add();
            }

            dataGridView.Rows[0].Cells[0].Value = "Origin";
            dataGridView.Rows[1].Cells[0].Value = "Point1";
            dataGridView.Rows[2].Cells[0].Value = "Point2";
            dataGridView.Rows[3].Cells[0].Value = "Point3";
            dataGridView.Rows[4].Cells[0].Value = "Point4";
            dataGridView.Rows[5].Cells[0].Value = "Color";
        }

        public void SetFontAndColorOfDatagridview()
        {
            dataGridView.BackgroundColor = Color.FromArgb(64, 64, 64);
            dataGridView.DefaultCellStyle.BackColor = Color.FromArgb(64, 64, 64);
            dataGridView.ForeColor = Color.White;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(64, 64, 64);
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGridView.DefaultCellStyle.Font = new Font("Comic Sans MS", 10);
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Comic Sans MS", 10);
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.DimGray;

            dataGridView.AllowUserToResizeRows = false;

        }
        public void GenerateTreeViewLevel1()
        {
            //Level 1
            treeView1.Nodes.Add("Line");    //0
            treeView1.Nodes.Add("Cube");    //1
            treeView1.Nodes.Add("Quads");   //2
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FileToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {

        }

        private void InputLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInputLine fInputline = new FrmInputLine();
            fInputline.Show();
        }
        public void DrawLines(float OX, float OY, float OZ, float IX, float IY, float IZ, float FX, float FY, float FZ, float C1, float C2, float C3)
        {
            //  Get the OpenGL instance that's been passed to us.
            OpenGL gl = openGLControl1.OpenGL;

            //  Reset the modelview matrix.
            gl.LoadIdentity();

            //  Move into a more central position.
           // gl.Translate(0.0f, 0.0f, -7.0f);
            gl.Translate(OX, OY, OZ);

            //  Rotate the line
            gl.Rotate(rotateline, 0.0f, 1.0f, 0.0f);
            gl.Scale(ScaleLine, ScaleLine, ScaleLine);

            gl.LineWidth(2);
            gl.Begin(OpenGL.GL_LINES);
            //--------------------------------------------------------------------------------
            gl.Color(C1,C2,C3); //c1,c2,c3 = RGB and range is 0 to 1
            gl.Vertex(IX,IY,IZ);
            gl.Vertex(FX,FY,FZ);

            gl.End();
            //  Flush OpenGL.
            gl.Flush();

            //  Rotate the geometry a bit.
            //rotateline += 3.0f;
        }

        private void OpenGLControl1_Resized(object sender, EventArgs e)
        {
            // Get the OpenGL instance.
            OpenGL gl = openGLControl1.OpenGL;

            // Load and clear the projection matrix.
            gl.MatrixMode(OpenGL.GL_PROJECTION);
            gl.LoadIdentity();

            // Perform a perspective transformation
            gl.Perspective(45.0f, (float)gl.RenderContextProvider.Width /
                (float)gl.RenderContextProvider.Height,
                0.1f, 100.0f);

            //  Use the 'look at' helper function to position and aim the camera.
            //gl.LookAt(-1, 1, -1, 0, 0, 0, 0, 1, 0);

            // Load the modelview.
            gl.MatrixMode(OpenGL.GL_MODELVIEW);
        }

        private void OpenGLControl1_OpenGLInitialized(object sender, EventArgs e)
        {
            //  Enable the OpenGL depth testing functionality.
            openGLControl1.OpenGL.Enable(OpenGL.GL_DEPTH_TEST);
        }

        private void AllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rotateline += 3.0f;
            rotateWireCube += 3.0f;
            rotatequads += 3.0f;

            rotatecylinder += 3.0f;
        }

        private void AllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            rotateline -= 3.0f;
            rotateWireCube -= 3.0f;
            rotatequads -= 3.0f;

            rotatecylinder -= 3.0f;
        }

        private void InputQuadsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInputQuads fquads = new FrmInputQuads();
            fquads.Show();
        }

        private void RotateQuadsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rotatequads += 3.0f;
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAbout fa = new FrmAbout();
            fa.Show();
        }

        private void TrueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                AllowDrawingLines = true;
            }
            catch
            {

            }
        }

        private void FalseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                AllowDrawingLines = false;
            }
            catch
            {

            }
        }

        private void TrueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AllowDrawingWireCube = true;
            //AllowCubeNodeDraw = true;
            try
            {
               
            }
            catch
            {

            }

        }

        private void TrueToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AllowDrawingQuads = true;
        }

        private void FalseToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AllowDrawingQuads = false;
        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                if (ComboBoxMain.Text == "Line")
                {
                    for (int i = 0; i <FrmInputLine.NumberofLine; i++)
                    {
                        if (treeView1.SelectedNode.Name == ("LineNode" + i.ToString()))
                        {
                            dataGridView.Rows[0].Cells[1].Value = FrmInputLine.Origin[i, 0];
                            dataGridView.Rows[0].Cells[2].Value = FrmInputLine.Origin[i, 1];
                            dataGridView.Rows[0].Cells[3].Value = FrmInputLine.Origin[i, 2];

                            dataGridView.Rows[1].Cells[1].Value = FrmInputLine.InitialPoint[i, 0];
                            dataGridView.Rows[1].Cells[2].Value = FrmInputLine.InitialPoint[i, 1];
                            dataGridView.Rows[1].Cells[3].Value = FrmInputLine.InitialPoint[i, 2];

                            dataGridView.Rows[2].Cells[1].Value = FrmInputLine.FinalPoint[i, 0];
                            dataGridView.Rows[2].Cells[2].Value = FrmInputLine.FinalPoint[i, 1];
                            dataGridView.Rows[2].Cells[3].Value = FrmInputLine.FinalPoint[i, 2];

                            dataGridView.Rows[3].Cells[1].Value = FrmInputLine.LineColor[i, 0];
                            dataGridView.Rows[3].Cells[2].Value = FrmInputLine.LineColor[i, 1];
                            dataGridView.Rows[3].Cells[3].Value = FrmInputLine.LineColor[i, 2];

                           redclr = Convert.ToInt32(Convert.ToSingle(dataGridView.Rows[3].Cells[1].Value) * 255);
                           greenclr = Convert.ToInt32(Convert.ToSingle(dataGridView.Rows[3].Cells[2].Value) * 255);
                           blueclr = Convert.ToInt32(Convert.ToSingle(dataGridView.Rows[3].Cells[3].Value) * 255); 

                            TxtWCubeNumber.BackColor = Color.FromArgb(redclr,greenclr,blueclr);

                            LblSelectedCubeName.Text = "LineNode" + i.ToString();
                        }
                    }
                }

                if (ComboBoxMain.Text == "Cube")
                {
                    for (int i = 0; i < FrmInputCube.NumberofCube; i++)
                    {
                        if (treeView1.SelectedNode.Name == ("CubeNode" + i.ToString()))
                        {
                            dataGridView.Rows[0].Cells[1].Value = FrmInputCube.WCubeOrigin[i, 0];
                            dataGridView.Rows[0].Cells[2].Value = FrmInputCube.WCubeOrigin[i, 1];
                            dataGridView.Rows[0].Cells[3].Value = FrmInputCube.WCubeOrigin[i, 2];

                            dataGridView.Rows[1].Cells[1].Value = FrmInputCube.WCubeFirstPoint[i, 0];
                            dataGridView.Rows[1].Cells[2].Value = FrmInputCube.WCubeFirstPoint[i, 1];
                            dataGridView.Rows[1].Cells[3].Value = FrmInputCube.WCubeFirstPoint[i, 2];

                            dataGridView.Rows[2].Cells[1].Value = FrmInputCube.WCubeSide[i, 0];
                            dataGridView.Rows[2].Cells[2].Value = FrmInputCube.WCubeSide[i, 1];
                            dataGridView.Rows[2].Cells[3].Value = FrmInputCube.WCubeSide[i, 2];

                            dataGridView.Rows[3].Cells[1].Value = FrmInputCube.WCubeColor[i, 0];
                            dataGridView.Rows[3].Cells[2].Value = FrmInputCube.WCubeColor[i, 1];
                            dataGridView.Rows[3].Cells[3].Value = FrmInputCube.WCubeColor[i, 2];

                            redclr = Convert.ToInt32(Convert.ToSingle(dataGridView.Rows[3].Cells[1].Value) * 255);
                            greenclr = Convert.ToInt32(Convert.ToSingle(dataGridView.Rows[3].Cells[2].Value) * 255);
                            blueclr = Convert.ToInt32(Convert.ToSingle(dataGridView.Rows[3].Cells[3].Value) * 255);

                            TxtWCubeNumber.BackColor = Color.FromArgb(redclr, greenclr, blueclr);

                            LblSelectedCubeName.Text = "CubeNode" + i.ToString();
                        }
                    }
                }

                if (ComboBoxMain.Text == "Quads")
                {
                    for (int i = 0; i < FrmInputQuads.NumberofQuads; i++)
                    {
                        if (treeView1.SelectedNode.Name == ("QuadNode" + i.ToString()))
                        {
                            dataGridView.Rows[0].Cells[1].Value = FrmInputQuads.QuadOrigin[i, 0];
                            dataGridView.Rows[0].Cells[2].Value = FrmInputQuads.QuadOrigin[i, 1];
                            dataGridView.Rows[0].Cells[3].Value = FrmInputQuads.QuadOrigin[i, 2];

                            dataGridView.Rows[1].Cells[1].Value = FrmInputQuads.QPoint1[i, 0];
                            dataGridView.Rows[1].Cells[2].Value = FrmInputQuads.QPoint1[i, 1];
                            dataGridView.Rows[1].Cells[3].Value = FrmInputQuads.QPoint1[i, 2];

                            dataGridView.Rows[2].Cells[1].Value = FrmInputQuads.QPoint2[i, 0];
                            dataGridView.Rows[2].Cells[2].Value = FrmInputQuads.QPoint2[i, 1];
                            dataGridView.Rows[2].Cells[3].Value = FrmInputQuads.QPoint2[i, 2];

                            dataGridView.Rows[3].Cells[1].Value = FrmInputQuads.QPoint3[i, 0];
                            dataGridView.Rows[3].Cells[2].Value = FrmInputQuads.QPoint3[i, 1];
                            dataGridView.Rows[3].Cells[3].Value = FrmInputQuads.QPoint3[i, 2];

                            dataGridView.Rows[4].Cells[1].Value = FrmInputQuads.QPoint4[i, 0];
                            dataGridView.Rows[4].Cells[2].Value = FrmInputQuads.QPoint4[i, 1];
                            dataGridView.Rows[4].Cells[3].Value = FrmInputQuads.QPoint4[i, 2];

                            dataGridView.Rows[5].Cells[1].Value = FrmInputQuads.QuadColor[i, 0];
                            dataGridView.Rows[5].Cells[2].Value = FrmInputQuads.QuadColor[i, 1];
                            dataGridView.Rows[5].Cells[3].Value = FrmInputQuads.QuadColor[i, 2];

                            redclr = Convert.ToInt32(Convert.ToSingle(dataGridView.Rows[5].Cells[1].Value) * 255);
                            greenclr = Convert.ToInt32(Convert.ToSingle(dataGridView.Rows[5].Cells[2].Value) * 255);
                            blueclr = Convert.ToInt32(Convert.ToSingle(dataGridView.Rows[5].Cells[3].Value) * 255);

                            TxtWCubeNumber.BackColor = Color.FromArgb(redclr, greenclr, blueclr);

                            LblSelectedCubeName.Text = "QuadNode" + i.ToString();
                        } 
                    }
                }
            }
            catch
            {

            }
            

        }

        private void FalseToolStripMenuItem3_Click(object sender, EventArgs e) //False visibility of treeview1
        {
            
        }

        private void TrueToolStripMenuItem3_Click(object sender, EventArgs e) //True visibility of treeview1
        {
            
        }

        private void VisibleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ComboBoxMain.Text == "Line")
            {
                for (int i = 0; i < FrmInputLine.NumberofLine; i++)
                {
                    if (treeView1.SelectedNode.Name == ("LineNode" + i.ToString()))
                    {
                        FrmInputLine.InitialPoint[i, 0] = FrmInputLine.TempInitialPoint[i, 0];
                        FrmInputLine.InitialPoint[i, 1] = FrmInputLine.TempInitialPoint[i, 1];
                        FrmInputLine.InitialPoint[i, 2] = FrmInputLine.TempInitialPoint[i, 2];

                        treeView1.SelectedNode.ForeColor = Color.White;
                    }
                }
            }

            if (ComboBoxMain.Text == "Cube")
            {
                for (int i = 0; i < FrmInputCube.NumberofCube; i++)
                {
                    if (treeView1.SelectedNode.Name == ("CubeNode" + i.ToString()))
                    {
                        FrmInputCube.WCubeSide[i, 0] = FrmInputCube.TempWCubeSide[i, 0];
                        FrmInputCube.WCubeSide[i, 1] = FrmInputCube.TempWCubeSide[i, 1];
                        FrmInputCube.WCubeSide[i, 2] = FrmInputCube.TempWCubeSide[i, 2];

                        treeView1.SelectedNode.ForeColor = Color.White;

                    }
                }
            }
            if(ComboBoxMain.Text == "Quads")
            {
                for (int i = 0; i < FrmInputQuads.NumberofQuads; i++)
                {
                    if (treeView1.SelectedNode.Name == ("QuadNode" + i.ToString()))
                    {
                        FrmInputQuads.QPoint2[i, 0] = FrmInputQuads.TempQPoint2[i, 0];
                        FrmInputQuads.QPoint2[i, 1] = FrmInputQuads.TempQPoint2[i, 1];
                        FrmInputQuads.QPoint2[i, 2] = FrmInputQuads.TempQPoint2[i, 2];

                        FrmInputQuads.QPoint3[i, 0] = FrmInputQuads.TempQPoint3[i, 0];
                        FrmInputQuads.QPoint3[i, 1] = FrmInputQuads.TempQPoint3[i, 1];
                        FrmInputQuads.QPoint3[i, 2] = FrmInputQuads.TempQPoint3[i, 2];

                        FrmInputQuads.QPoint4[i, 0] = FrmInputQuads.TempQPoint4[i, 0];
                        FrmInputQuads.QPoint4[i, 1] = FrmInputQuads.TempQPoint4[i, 1];
                        FrmInputQuads.QPoint4[i, 2] = FrmInputQuads.TempQPoint4[i, 2];

                        treeView1.SelectedNode.ForeColor = Color.White;

                    }
                }

            }

        }

        private void NotVisibleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ComboBoxMain.Text == "Line")
            {
                for (int i = 0; i < FrmInputLine.NumberofLine; i++)
                {
                    if (treeView1.SelectedNode.Name == ("LineNode" + i.ToString()))
                    {
                        FrmInputLine.InitialPoint[i, 0] = FrmInputLine.FinalPoint[i, 0];
                        FrmInputLine.InitialPoint[i, 1] = FrmInputLine.FinalPoint[i, 1];
                        FrmInputLine.InitialPoint[i, 2] = FrmInputLine.FinalPoint[i, 2];

                        treeView1.SelectedNode.ForeColor = Color.Aqua;
                    }
                }
            }
            if(ComboBoxMain.Text=="Cube")
            {
                for (int i = 0; i < FrmInputCube.NumberofCube; i++)
                {
                    if (treeView1.SelectedNode.Name == ("CubeNode" + i.ToString()))
                    {
                        /*TempWCubeOrigin[i, 0] = FrmInputCube.WCubeOrigin[i, 0];
                        TempWCubeOrigin[i, 1] = FrmInputCube.WCubeOrigin[i, 1];
                        TempWCubeOrigin[i, 2] = FrmInputCube.WCubeOrigin[i, 2];

                        TempWCubeFirstPoint[i, 0] = FrmInputCube.WCubeFirstPoint[i, 0];
                        TempWCubeFirstPoint[i, 1] = FrmInputCube.WCubeFirstPoint[i, 1];
                        TempWCubeFirstPoint[i, 2] = FrmInputCube.WCubeFirstPoint[i, 2];

                        TempWCubeSide[i, 0] = FrmInputCube.WCubeSide[i, 0];
                        TempWCubeSide[i, 1] = FrmInputCube.WCubeSide[i, 1];
                        TempWCubeSide[i, 2] = FrmInputCube.WCubeSide[i, 2]; 

                        TempWCubeColor[i,0] = FrmInputCube.WCubeColor[i, 0];
                        TempWCubeColor[i, 1] = FrmInputCube.WCubeColor[i, 1];
                        TempWCubeColor[i, 2] = FrmInputCube.WCubeColor[i, 2];*/

                        FrmInputCube.WCubeSide[i, 0] = 0;
                        FrmInputCube.WCubeSide[i, 1] = 0;
                        FrmInputCube.WCubeSide[i, 2] = 0;

                        treeView1.SelectedNode.ForeColor = Color.Aqua;

                    }
                }
            }

            if (ComboBoxMain.Text == "Quads")
            {
                for (int i = 0; i < FrmInputQuads.NumberofQuads; i++)
                {
                    if (treeView1.SelectedNode.Name == ("QuadNode" + i.ToString()))
                    {
                        FrmInputQuads.QPoint2[i, 0] = FrmInputQuads.QPoint1[i, 0];
                        FrmInputQuads.QPoint2[i, 1] = FrmInputQuads.QPoint1[i, 1];
                        FrmInputQuads.QPoint2[i, 2] = FrmInputQuads.QPoint1[i, 2];

                        FrmInputQuads.QPoint3[i, 0] = FrmInputQuads.QPoint1[i, 0];
                        FrmInputQuads.QPoint3[i, 1] = FrmInputQuads.QPoint1[i, 1];
                        FrmInputQuads.QPoint3[i, 2] = FrmInputQuads.QPoint1[i, 2];

                        FrmInputQuads.QPoint4[i, 0] = FrmInputQuads.QPoint1[i, 0];
                        FrmInputQuads.QPoint4[i, 1] = FrmInputQuads.QPoint1[i, 1];
                        FrmInputQuads.QPoint4[i, 2] = FrmInputQuads.QPoint1[i, 2];

                        treeView1.SelectedNode.ForeColor = Color.Aqua;

                    }
                }
            }

        }

        private void ComboBoxMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView.Rows.Clear();


                if (ComboBoxMain.Text == "Line")
                {
                    GenerateCubeDatagridColumns();
                    GenerateLineDatagridRows();
                }

                if (ComboBoxMain.Text == "Cube")
                {
                    GenerateCubeDatagridColumns();
                    GenerateCubeDatagridRows();
                }

                if (ComboBoxMain.Text == "Quads")
                {
                    GenerateCubeDatagridColumns();
                    GenerateQuadsDatagridRows();
                }


                //TxtWCubeNumber.Focus();
                LblSelectedCubeName.Focus();
            }
            catch
            {

            }
            
        }

        private void FalseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AllowDrawingWireCube = false;
        }

        private void RotateQuadsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            rotatequads -= 3.0f;
        }

        private void RotateLineToolStripMenuItem_Click(object sender, EventArgs e) // plus
        {
            rotateline += 3.0f;
            
        }

        private void RotateLineToolStripMenuItem1_Click(object sender, EventArgs e) // minus
        {
            rotateline -= 3.0f;
           
        }

        private void OpenGLControl1_OpenGLDraw(object sender, RenderEventArgs args)
        {
           try
           {
                OpenGL gl = openGLControl1.OpenGL;
                gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);

                //DrawCylinder();

                //lines
                if (AllowDrawingLines == true)
                {
                    for (i = 0; i < FrmInputLine.NumberofLine; i++)
                    {
                        DrawLines(
                            FrmInputLine.Origin[i, 0], FrmInputLine.Origin[i, 1], FrmInputLine.Origin[i, 2],
                            FrmInputLine.InitialPoint[i, 0], FrmInputLine.InitialPoint[i, 1], FrmInputLine.InitialPoint[i, 2],
                            FrmInputLine.FinalPoint[i, 0], FrmInputLine.FinalPoint[i, 1], FrmInputLine.FinalPoint[i, 2],
                            FrmInputLine.LineColor[i, 0], FrmInputLine.LineColor[i, 1], FrmInputLine.LineColor[i, 2]
                            );
                    }
                }
                //wireframe cube
                if(AllowDrawingWireCube==true)
                {
                    for(i=0;i<FrmInputCube.NumberofCube;i++)
                    {
                        DrawWireFrameCube(
                            FrmInputCube.WCubeOrigin[i,0], FrmInputCube.WCubeOrigin[i, 1], FrmInputCube.WCubeOrigin[i, 2],
                            FrmInputCube.WCubeFirstPoint[i,0], FrmInputCube.WCubeFirstPoint[i, 1], FrmInputCube.WCubeFirstPoint[i, 2],
                            FrmInputCube.WCubeSide[i,0], FrmInputCube.WCubeSide[i, 1], FrmInputCube.WCubeSide[i, 2],
                            FrmInputCube.WCubeColor[i,0], FrmInputCube.WCubeColor[i, 1], FrmInputCube.WCubeColor[i, 2]
                            );
                    }

                    
                }
                //Quadrilaterals
                if (AllowDrawingQuads == true)
                {
                    for (i = 0; i <FrmInputQuads.NumberofQuads; i++)
                    {
                        DrawQuads(
                            FrmInputQuads.QuadOrigin[i, 0], FrmInputQuads.QuadOrigin[i, 1], FrmInputQuads.QuadOrigin[i, 2],
                            FrmInputQuads.QPoint1[i, 0], FrmInputQuads.QPoint1[i, 1], FrmInputQuads.QPoint1[i, 2],
                            FrmInputQuads.QPoint2[i, 0], FrmInputQuads.QPoint2[i, 1], FrmInputQuads.QPoint2[i, 2],
                            FrmInputQuads.QPoint3[i, 0], FrmInputQuads.QPoint3[i, 1], FrmInputQuads.QPoint3[i, 2],
                            FrmInputQuads.QPoint4[i, 0], FrmInputQuads.QPoint4[i, 1], FrmInputQuads.QPoint4[i, 2],
                            FrmInputQuads.QuadColor[i, 0], FrmInputQuads.QuadColor[i, 1], FrmInputQuads.QuadColor[i, 2]
                            );
                    }
                }
            }
            catch
           {

           }
        }
        public void DrawCylinder()
        {
            //  Get the OpenGL instance that's been passed to us.
            OpenGL gl = openGLControl1.OpenGL;

            //  Reset the modelview matrix.
            gl.LoadIdentity();

            //  Move into a more central position.
            gl.Translate(-1.5f, -1.5f, -7.0f);
            //gl.Translate(tx, ty, tz);

            //  Rotate the line
            //gl.Rotate(120, 1.0f, 0.0f, 0.0f);
            gl.Rotate(rotatecylinder, 0.0f, 1.0f, 0.0f);

            IntPtr ip = new IntPtr();
            ip = gl.NewQuadric();
            gl.QuadricNormals(ip, OpenGL.GL_SMOOTH);

            gl.Color(0.0f, 1.0f, 0.0f); //c1,c2,c3 = RGB and range is 0 to 1 // green
            gl.Cylinder(ip,1, 1, 3, 120, 16);

            gl.Color(0.2f, 0.3f, 1.0f); //c1,c2,c3 = RGB and range is 0 to 1 //red
            gl.Disk(ip, 0, 1, 120, 1);

            float radius = 1.0f;
            int numberoftriangle = 100;
            float CenterX = 0.0f, CenterY = 0.0f, CenterZ = 3.0f;
            float X_Coord, Y_Coord;
            float twoPi = Convert.ToSingle(2 * Math.PI);
            float theta;

            gl.Begin(OpenGL.GL_TRIANGLE_FAN);
            gl.Color(1.0f, 0.0f, 0.0f); //c1,c2,c3 = RGB and range is 0 to 1
            gl.Vertex(CenterX, CenterY, CenterZ);

            for(int i =0;i<=numberoftriangle;i++)
            {
                theta = twoPi * i / numberoftriangle;
                X_Coord =Convert.ToSingle(radius * Math.Cos(theta));
                Y_Coord = Convert.ToSingle(radius * Math.Sin(theta));
                gl.Vertex(X_Coord, Y_Coord, CenterZ);
            }

            gl.End();

            //  Flush OpenGL.
            gl.Flush();

            //  Rotate the geometry a bit.
            //rotateline += 3.0f;
        }
        public void DrawQuads(
                              float tx, float ty, float tz, 
                              float X1, float Y1, float Z1, 
                              float X2, float Y2, float Z2,
                              float X3, float Y3, float Z3,
                              float X4, float Y4, float Z4, 
                              float C1, float C2, float C3
                              ) 
        {
            //  Get the OpenGL instance that's been passed to us.
            OpenGL gl = openGLControl1.OpenGL;

            //  Reset the modelview matrix.
            gl.LoadIdentity();

            //  Move into a more central position.
            //gl.Translate(-1.5f, -1.5f, -7.0f);
            gl.Translate(tx, ty, tz);
             
            //  Rotate the line
            gl.Rotate(rotatequads, 0.0f, 1.0f, 0.0f);

            gl.Begin(OpenGL.GL_QUADS);

            gl.Color(C1, C2, C3); //c1,c2,c3 = RGB and range is 0 to 1
            gl.Vertex(X1, Y1, Z1);
            gl.Vertex(X2, Y2, Z2);
            gl.Vertex(X3, Y3, Z3);
            gl.Vertex(X4, Y4, Z4);

            gl.End();
            //  Flush OpenGL.
            gl.Flush();

            //  Rotate the geometry a bit.
            //rotateline += 3.0f;
        }

        public void DrawWireFrameCube(float tx, float ty, float tz,float OriginX, float OriginY, float OriginZ, float CubesizeX, float CubesizeY, float CubesizeZ, float C1, float C2, float C3)
        {
            try  
            {
                
                //  Get the OpenGL instance that's been passed to us.
                OpenGL gl = openGLControl1.OpenGL;

                //  Clear the color and depth buffers.
                //gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);

                //  Reset the modelview matrix.
                gl.LoadIdentity();

                //  Move into a more central position.
                //gl.Translate(0.0f, -2.0f, -7.0f);
                gl.Translate(tx, ty, tz);

                //  Rotate the cube.
                gl.Rotate(rotateWireCube, 0.0f, 1.0f, 0.0f); 
                //gl.Rotate(rotateline1, rotX, rotY, rotZ);

                gl.LineWidth(2);
                gl.Begin(OpenGL.GL_LINES);

                gl.Color(C1, C2, C3); //red1
                gl.Vertex(OriginX, OriginY, OriginZ);// it is first point  coordinate and all other coordinate are w.r.t. this coordinate
                gl.Vertex(CubesizeX + OriginX, OriginY, OriginZ);

                gl.Color(C1, C2, C3); //red2
                gl.Vertex(CubesizeX + OriginX, OriginY, OriginZ);
                gl.Vertex(CubesizeX + OriginX, OriginY, CubesizeY + OriginZ);

                gl.Color(C1, C2, C3); //red3
                gl.Vertex(CubesizeX + OriginX, OriginY, CubesizeZ + OriginZ);
                gl.Vertex(OriginX, OriginY, CubesizeZ + OriginZ);

                gl.Color(C1, C2, C3); //red4
                gl.Vertex(OriginX, OriginY, CubesizeZ + OriginZ);
                gl.Vertex(OriginX, OriginY, OriginZ);

                gl.Color(C1, C2, C3); //green1
                gl.Vertex(OriginX, CubesizeY + OriginY, OriginZ);
                gl.Vertex(CubesizeX + OriginX, CubesizeY + OriginY, OriginZ);

                gl.Color(C1, C2, C3); //green2
                gl.Vertex(CubesizeX + OriginX, CubesizeY + OriginY, OriginZ);
                gl.Vertex(CubesizeX + OriginX, CubesizeY + OriginY, CubesizeZ + OriginZ);

                gl.Color(C1, C2, C3); //green3
                gl.Vertex(CubesizeX + OriginX, CubesizeY + OriginY, CubesizeZ + OriginZ);
                gl.Vertex(OriginX, CubesizeY + OriginY, CubesizeZ + OriginZ);

                gl.Color(C1, C2, C3);
                gl.Vertex(OriginX, CubesizeY + OriginY, CubesizeZ + OriginZ);
                gl.Vertex(OriginX, CubesizeY + OriginY, OriginZ);

                gl.Color(C1, C2, C3);
                gl.Vertex(OriginX, OriginY, OriginZ);
                gl.Vertex(OriginX, CubesizeY + OriginY, OriginZ);

                gl.Color(C1, C2, C3);
                gl.Vertex(CubesizeX + OriginX, OriginY, OriginZ);
                gl.Vertex(CubesizeX + OriginX, CubesizeY + OriginY, OriginZ);

                gl.Color(C1, C2, C3);
                gl.Vertex(CubesizeX + OriginX, OriginY, CubesizeZ + OriginZ);
                gl.Vertex(CubesizeX + OriginX, CubesizeY + OriginY, CubesizeZ + OriginZ);

                gl.Color(C1, C2, C3);
                gl.Vertex(OriginX, OriginY, CubesizeZ + OriginZ);
                gl.Vertex(OriginX, CubesizeY + OriginY, CubesizeZ + OriginZ);


                gl.End();

                //  Flush OpenGL.
                gl.Flush();

                //  Rotate the geometry a bit.
                //rotateline1 += speed / (numberofcubeX * numberofcubeY * numberofcubeZ);
            }
            catch
            {

            }


        }

        private void RotateCubeToolStripMenuItem_Click(object sender, EventArgs e) //plus for wire cube
        {
            rotateWireCube += 3.0f;
        }

        private void RotateCubeToolStripMenuItem1_Click(object sender, EventArgs e) // minus for wire cube
        {
            rotateWireCube -= 3.0f;
        }

        private void InputCubeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInputCube fcube = new FrmInputCube();
            fcube.Show();
        }
    }
}
