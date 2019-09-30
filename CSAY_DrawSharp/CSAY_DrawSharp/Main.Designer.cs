namespace CSAY_DrawSharp
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MenuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lineInputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawLinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.falseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateLineToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cubeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputCubeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawCubeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.falseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateCubeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateCubeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quadsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputQuadsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawQuadsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trueToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.falseToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateQuadsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateQuadsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openGLControl1 = new SharpGL.OpenGLControl();
            this.ColorDialogBG = new System.Windows.Forms.ColorDialog();
            this.MainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.SideSplitContainer = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.visibleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notVisibleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ComboBoxMain = new System.Windows.Forms.ComboBox();
            this.TxtWCubeNumber = new System.Windows.Forms.TextBox();
            this.LblSelectedCubeName = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.MenuStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).BeginInit();
            this.MainSplitContainer.Panel1.SuspendLayout();
            this.MainSplitContainer.Panel2.SuspendLayout();
            this.MainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SideSplitContainer)).BeginInit();
            this.SideSplitContainer.Panel1.SuspendLayout();
            this.SideSplitContainer.Panel2.SuspendLayout();
            this.SideSplitContainer.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuStripMain
            // 
            this.MenuStripMain.BackColor = System.Drawing.Color.DimGray;
            this.MenuStripMain.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.rotateToolStripMenuItem,
            this.lineInputToolStripMenuItem,
            this.cubeToolStripMenuItem,
            this.quadsToolStripMenuItem});
            this.MenuStripMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.MenuStripMain.Location = new System.Drawing.Point(0, 0);
            this.MenuStripMain.Name = "MenuStripMain";
            this.MenuStripMain.Size = new System.Drawing.Size(940, 26);
            this.MenuStripMain.TabIndex = 0;
            this.MenuStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(43, 22);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.DropDownOpening += new System.EventHandler(this.FileToolStripMenuItem_DropDownOpening);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(109, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // rotateToolStripMenuItem
            // 
            this.rotateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allToolStripMenuItem,
            this.allToolStripMenuItem1});
            this.rotateToolStripMenuItem.Name = "rotateToolStripMenuItem";
            this.rotateToolStripMenuItem.Size = new System.Drawing.Size(59, 22);
            this.rotateToolStripMenuItem.Text = "Rotate";
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.allToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.allToolStripMenuItem.Text = "All (+)";
            this.allToolStripMenuItem.Click += new System.EventHandler(this.AllToolStripMenuItem_Click);
            // 
            // allToolStripMenuItem1
            // 
            this.allToolStripMenuItem1.Name = "allToolStripMenuItem1";
            this.allToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.allToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.allToolStripMenuItem1.Text = "All (-)";
            this.allToolStripMenuItem1.Click += new System.EventHandler(this.AllToolStripMenuItem1_Click);
            // 
            // lineInputToolStripMenuItem
            // 
            this.lineInputToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputLineToolStripMenuItem,
            this.drawLinesToolStripMenuItem,
            this.rotateLineToolStripMenuItem,
            this.rotateLineToolStripMenuItem1});
            this.lineInputToolStripMenuItem.Name = "lineInputToolStripMenuItem";
            this.lineInputToolStripMenuItem.Size = new System.Drawing.Size(45, 22);
            this.lineInputToolStripMenuItem.Text = "Line";
            // 
            // inputLineToolStripMenuItem
            // 
            this.inputLineToolStripMenuItem.Name = "inputLineToolStripMenuItem";
            this.inputLineToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.inputLineToolStripMenuItem.Text = "Input Line";
            this.inputLineToolStripMenuItem.Click += new System.EventHandler(this.InputLineToolStripMenuItem_Click);
            // 
            // drawLinesToolStripMenuItem
            // 
            this.drawLinesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trueToolStripMenuItem,
            this.falseToolStripMenuItem});
            this.drawLinesToolStripMenuItem.Name = "drawLinesToolStripMenuItem";
            this.drawLinesToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.drawLinesToolStripMenuItem.Text = "Draw Lines";
            // 
            // trueToolStripMenuItem
            // 
            this.trueToolStripMenuItem.Name = "trueToolStripMenuItem";
            this.trueToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.trueToolStripMenuItem.Text = "True";
            this.trueToolStripMenuItem.Click += new System.EventHandler(this.TrueToolStripMenuItem_Click);
            // 
            // falseToolStripMenuItem
            // 
            this.falseToolStripMenuItem.Name = "falseToolStripMenuItem";
            this.falseToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.falseToolStripMenuItem.Text = "False";
            this.falseToolStripMenuItem.Click += new System.EventHandler(this.FalseToolStripMenuItem_Click);
            // 
            // rotateLineToolStripMenuItem
            // 
            this.rotateLineToolStripMenuItem.Name = "rotateLineToolStripMenuItem";
            this.rotateLineToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Left)));
            this.rotateLineToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.rotateLineToolStripMenuItem.Text = "Rotate Line (+)";
            this.rotateLineToolStripMenuItem.Click += new System.EventHandler(this.RotateLineToolStripMenuItem_Click);
            // 
            // rotateLineToolStripMenuItem1
            // 
            this.rotateLineToolStripMenuItem1.Name = "rotateLineToolStripMenuItem1";
            this.rotateLineToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Right)));
            this.rotateLineToolStripMenuItem1.Size = new System.Drawing.Size(226, 22);
            this.rotateLineToolStripMenuItem1.Text = "Rotate Line (-)";
            this.rotateLineToolStripMenuItem1.Click += new System.EventHandler(this.RotateLineToolStripMenuItem1_Click);
            // 
            // cubeToolStripMenuItem
            // 
            this.cubeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputCubeToolStripMenuItem,
            this.drawCubeToolStripMenuItem,
            this.rotateCubeToolStripMenuItem,
            this.rotateCubeToolStripMenuItem1});
            this.cubeToolStripMenuItem.Name = "cubeToolStripMenuItem";
            this.cubeToolStripMenuItem.Size = new System.Drawing.Size(50, 22);
            this.cubeToolStripMenuItem.Text = "Cube";
            // 
            // inputCubeToolStripMenuItem
            // 
            this.inputCubeToolStripMenuItem.Name = "inputCubeToolStripMenuItem";
            this.inputCubeToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.inputCubeToolStripMenuItem.Text = "Input Cube";
            this.inputCubeToolStripMenuItem.Click += new System.EventHandler(this.InputCubeToolStripMenuItem_Click);
            // 
            // drawCubeToolStripMenuItem
            // 
            this.drawCubeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trueToolStripMenuItem1,
            this.falseToolStripMenuItem1});
            this.drawCubeToolStripMenuItem.Name = "drawCubeToolStripMenuItem";
            this.drawCubeToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.drawCubeToolStripMenuItem.Text = "Draw Cube";
            // 
            // trueToolStripMenuItem1
            // 
            this.trueToolStripMenuItem1.Name = "trueToolStripMenuItem1";
            this.trueToolStripMenuItem1.Size = new System.Drawing.Size(108, 22);
            this.trueToolStripMenuItem1.Text = "True";
            this.trueToolStripMenuItem1.Click += new System.EventHandler(this.TrueToolStripMenuItem1_Click);
            // 
            // falseToolStripMenuItem1
            // 
            this.falseToolStripMenuItem1.Name = "falseToolStripMenuItem1";
            this.falseToolStripMenuItem1.Size = new System.Drawing.Size(108, 22);
            this.falseToolStripMenuItem1.Text = "False";
            this.falseToolStripMenuItem1.Click += new System.EventHandler(this.FalseToolStripMenuItem1_Click);
            // 
            // rotateCubeToolStripMenuItem
            // 
            this.rotateCubeToolStripMenuItem.Name = "rotateCubeToolStripMenuItem";
            this.rotateCubeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Left)));
            this.rotateCubeToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.rotateCubeToolStripMenuItem.Text = "Rotate Cube (+)";
            this.rotateCubeToolStripMenuItem.Click += new System.EventHandler(this.RotateCubeToolStripMenuItem_Click);
            // 
            // rotateCubeToolStripMenuItem1
            // 
            this.rotateCubeToolStripMenuItem1.Name = "rotateCubeToolStripMenuItem1";
            this.rotateCubeToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Right)));
            this.rotateCubeToolStripMenuItem1.Size = new System.Drawing.Size(236, 22);
            this.rotateCubeToolStripMenuItem1.Text = "Rotate Cube (-)";
            this.rotateCubeToolStripMenuItem1.Click += new System.EventHandler(this.RotateCubeToolStripMenuItem1_Click);
            // 
            // quadsToolStripMenuItem
            // 
            this.quadsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputQuadsToolStripMenuItem,
            this.drawQuadsToolStripMenuItem,
            this.rotateQuadsToolStripMenuItem,
            this.rotateQuadsToolStripMenuItem1});
            this.quadsToolStripMenuItem.Name = "quadsToolStripMenuItem";
            this.quadsToolStripMenuItem.Size = new System.Drawing.Size(59, 22);
            this.quadsToolStripMenuItem.Text = "Quads";
            // 
            // inputQuadsToolStripMenuItem
            // 
            this.inputQuadsToolStripMenuItem.Name = "inputQuadsToolStripMenuItem";
            this.inputQuadsToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.inputQuadsToolStripMenuItem.Text = "Input Quads";
            this.inputQuadsToolStripMenuItem.Click += new System.EventHandler(this.InputQuadsToolStripMenuItem_Click);
            // 
            // drawQuadsToolStripMenuItem
            // 
            this.drawQuadsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trueToolStripMenuItem2,
            this.falseToolStripMenuItem2});
            this.drawQuadsToolStripMenuItem.Name = "drawQuadsToolStripMenuItem";
            this.drawQuadsToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.drawQuadsToolStripMenuItem.Text = "Draw Quads";
            // 
            // trueToolStripMenuItem2
            // 
            this.trueToolStripMenuItem2.Name = "trueToolStripMenuItem2";
            this.trueToolStripMenuItem2.Size = new System.Drawing.Size(108, 22);
            this.trueToolStripMenuItem2.Text = "True";
            this.trueToolStripMenuItem2.Click += new System.EventHandler(this.TrueToolStripMenuItem2_Click);
            // 
            // falseToolStripMenuItem2
            // 
            this.falseToolStripMenuItem2.Name = "falseToolStripMenuItem2";
            this.falseToolStripMenuItem2.Size = new System.Drawing.Size(108, 22);
            this.falseToolStripMenuItem2.Text = "False";
            this.falseToolStripMenuItem2.Click += new System.EventHandler(this.FalseToolStripMenuItem2_Click);
            // 
            // rotateQuadsToolStripMenuItem
            // 
            this.rotateQuadsToolStripMenuItem.Name = "rotateQuadsToolStripMenuItem";
            this.rotateQuadsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.NumPad1)));
            this.rotateQuadsToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.rotateQuadsToolStripMenuItem.Text = "Rotate Quads (+)";
            this.rotateQuadsToolStripMenuItem.Click += new System.EventHandler(this.RotateQuadsToolStripMenuItem_Click);
            // 
            // rotateQuadsToolStripMenuItem1
            // 
            this.rotateQuadsToolStripMenuItem1.Name = "rotateQuadsToolStripMenuItem1";
            this.rotateQuadsToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.NumPad3)));
            this.rotateQuadsToolStripMenuItem1.Size = new System.Drawing.Size(270, 22);
            this.rotateQuadsToolStripMenuItem1.Text = "Rotate Quads (-)";
            this.rotateQuadsToolStripMenuItem1.Click += new System.EventHandler(this.RotateQuadsToolStripMenuItem1_Click);
            // 
            // openGLControl1
            // 
            this.openGLControl1.BackColor = System.Drawing.Color.White;
            this.openGLControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openGLControl1.DrawFPS = false;
            this.openGLControl1.Location = new System.Drawing.Point(0, 0);
            this.openGLControl1.Name = "openGLControl1";
            this.openGLControl1.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.openGLControl1.RenderContextType = SharpGL.RenderContextType.DIBSection;
            this.openGLControl1.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.openGLControl1.Size = new System.Drawing.Size(775, 516);
            this.openGLControl1.TabIndex = 1;
            this.openGLControl1.OpenGLInitialized += new System.EventHandler(this.OpenGLControl1_OpenGLInitialized);
            this.openGLControl1.OpenGLDraw += new SharpGL.RenderEventHandler(this.OpenGLControl1_OpenGLDraw);
            this.openGLControl1.Resized += new System.EventHandler(this.OpenGLControl1_Resized);
            // 
            // MainSplitContainer
            // 
            this.MainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplitContainer.Location = new System.Drawing.Point(0, 26);
            this.MainSplitContainer.Name = "MainSplitContainer";
            // 
            // MainSplitContainer.Panel1
            // 
            this.MainSplitContainer.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MainSplitContainer.Panel1.Controls.Add(this.SideSplitContainer);
            // 
            // MainSplitContainer.Panel2
            // 
            this.MainSplitContainer.Panel2.Controls.Add(this.openGLControl1);
            this.MainSplitContainer.Size = new System.Drawing.Size(940, 516);
            this.MainSplitContainer.SplitterDistance = 161;
            this.MainSplitContainer.TabIndex = 2;
            // 
            // SideSplitContainer
            // 
            this.SideSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SideSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.SideSplitContainer.Name = "SideSplitContainer";
            this.SideSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SideSplitContainer.Panel1
            // 
            this.SideSplitContainer.Panel1.Controls.Add(this.treeView1);
            // 
            // SideSplitContainer.Panel2
            // 
            this.SideSplitContainer.Panel2.Controls.Add(this.ComboBoxMain);
            this.SideSplitContainer.Panel2.Controls.Add(this.TxtWCubeNumber);
            this.SideSplitContainer.Panel2.Controls.Add(this.LblSelectedCubeName);
            this.SideSplitContainer.Panel2.Controls.Add(this.dataGridView);
            this.SideSplitContainer.Size = new System.Drawing.Size(161, 516);
            this.SideSplitContainer.SplitterDistance = 175;
            this.SideSplitContainer.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.treeView1.ContextMenuStrip = this.contextMenuStrip1;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(161, 175);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView1_AfterSelect);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visibleToolStripMenuItem,
            this.notVisibleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(141, 48);
            // 
            // visibleToolStripMenuItem
            // 
            this.visibleToolStripMenuItem.Name = "visibleToolStripMenuItem";
            this.visibleToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.visibleToolStripMenuItem.Text = "Visible";
            this.visibleToolStripMenuItem.Click += new System.EventHandler(this.VisibleToolStripMenuItem_Click);
            // 
            // notVisibleToolStripMenuItem
            // 
            this.notVisibleToolStripMenuItem.Name = "notVisibleToolStripMenuItem";
            this.notVisibleToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.notVisibleToolStripMenuItem.Text = "Not Visible";
            this.notVisibleToolStripMenuItem.Click += new System.EventHandler(this.NotVisibleToolStripMenuItem_Click);
            // 
            // ComboBoxMain
            // 
            this.ComboBoxMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ComboBoxMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxMain.ForeColor = System.Drawing.Color.White;
            this.ComboBoxMain.FormattingEnabled = true;
            this.ComboBoxMain.Location = new System.Drawing.Point(12, 32);
            this.ComboBoxMain.Name = "ComboBoxMain";
            this.ComboBoxMain.Size = new System.Drawing.Size(164, 26);
            this.ComboBoxMain.TabIndex = 2;
            this.ComboBoxMain.Text = "Select what to Show";
            this.ComboBoxMain.SelectedIndexChanged += new System.EventHandler(this.ComboBoxMain_SelectedIndexChanged);
            // 
            // TxtWCubeNumber
            // 
            this.TxtWCubeNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtWCubeNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtWCubeNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtWCubeNumber.ForeColor = System.Drawing.Color.White;
            this.TxtWCubeNumber.Location = new System.Drawing.Point(111, 131);
            this.TxtWCubeNumber.Name = "TxtWCubeNumber";
            this.TxtWCubeNumber.ReadOnly = true;
            this.TxtWCubeNumber.Size = new System.Drawing.Size(76, 22);
            this.TxtWCubeNumber.TabIndex = 7;
            // 
            // LblSelectedCubeName
            // 
            this.LblSelectedCubeName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblSelectedCubeName.AutoSize = true;
            this.LblSelectedCubeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSelectedCubeName.ForeColor = System.Drawing.Color.White;
            this.LblSelectedCubeName.Location = new System.Drawing.Point(8, 134);
            this.LblSelectedCubeName.Name = "LblSelectedCubeName";
            this.LblSelectedCubeName.Size = new System.Drawing.Size(97, 16);
            this.LblSelectedCubeName.TabIndex = 6;
            this.LblSelectedCubeName.Text = "Selected Cube";
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(0, 157);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(298, 168);
            this.dataGridView.TabIndex = 5;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(940, 542);
            this.Controls.Add(this.MainSplitContainer);
            this.Controls.Add(this.MenuStripMain);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MainMenuStrip = this.MenuStripMain;
            this.Name = "FrmMain";
            this.Text = "CSAY Sharp Draw 3D";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuStripMain.ResumeLayout(false);
            this.MenuStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl1)).EndInit();
            this.MainSplitContainer.Panel1.ResumeLayout(false);
            this.MainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).EndInit();
            this.MainSplitContainer.ResumeLayout(false);
            this.SideSplitContainer.Panel1.ResumeLayout(false);
            this.SideSplitContainer.Panel2.ResumeLayout(false);
            this.SideSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SideSplitContainer)).EndInit();
            this.SideSplitContainer.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineInputToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputLineToolStripMenuItem;
        private SharpGL.OpenGLControl openGLControl1;
        private System.Windows.Forms.ToolStripMenuItem drawLinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateLineToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cubeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputCubeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drawCubeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateCubeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateCubeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rotateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quadsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputQuadsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drawQuadsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateQuadsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateQuadsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ColorDialog ColorDialogBG;
        private System.Windows.Forms.ToolStripMenuItem trueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem falseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trueToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem falseToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem trueToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem falseToolStripMenuItem2;
        private System.Windows.Forms.SplitContainer MainSplitContainer;
        private System.Windows.Forms.SplitContainer SideSplitContainer;
        private System.Windows.Forms.Label LblSelectedCubeName;
        public System.Windows.Forms.TextBox TxtWCubeNumber;
        public System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem visibleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notVisibleToolStripMenuItem;
        private System.Windows.Forms.ComboBox ComboBoxMain;
    }
}

