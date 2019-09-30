namespace CSAY_DrawSharp
{
    partial class FrmInputCube
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnAccept = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnImport = new System.Windows.Forms.Button();
            this.LblNumberofLine = new System.Windows.Forms.Label();
            this.TxtNumberOfCube = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ColCube = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColOX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColOY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColOZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFirstX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFirstY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFirstZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColC1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColC2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColC3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAccept
            // 
            this.BtnAccept.BackColor = System.Drawing.Color.White;
            this.BtnAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAccept.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnAccept.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAccept.ForeColor = System.Drawing.Color.DimGray;
            this.BtnAccept.Location = new System.Drawing.Point(553, 39);
            this.BtnAccept.Name = "BtnAccept";
            this.BtnAccept.Size = new System.Drawing.Size(202, 34);
            this.BtnAccept.TabIndex = 52;
            this.BtnAccept.Text = "Accept";
            this.BtnAccept.UseVisualStyleBackColor = false;
            this.BtnAccept.Click += new System.EventHandler(this.BtnAccept_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.White;
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnExit.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.Color.DimGray;
            this.BtnExit.Location = new System.Drawing.Point(770, 39);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(202, 34);
            this.BtnExit.TabIndex = 51;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnImport
            // 
            this.BtnImport.BackColor = System.Drawing.Color.White;
            this.BtnImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnImport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnImport.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImport.ForeColor = System.Drawing.Color.DimGray;
            this.BtnImport.Location = new System.Drawing.Point(331, 40);
            this.BtnImport.Name = "BtnImport";
            this.BtnImport.Size = new System.Drawing.Size(202, 34);
            this.BtnImport.TabIndex = 50;
            this.BtnImport.Text = "Import From Excel";
            this.BtnImport.UseVisualStyleBackColor = false;
            this.BtnImport.Click += new System.EventHandler(this.BtnImport_Click);
            // 
            // LblNumberofLine
            // 
            this.LblNumberofLine.AutoSize = true;
            this.LblNumberofLine.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumberofLine.ForeColor = System.Drawing.Color.DimGray;
            this.LblNumberofLine.Location = new System.Drawing.Point(31, 50);
            this.LblNumberofLine.Name = "LblNumberofLine";
            this.LblNumberofLine.Size = new System.Drawing.Size(137, 23);
            this.LblNumberofLine.TabIndex = 49;
            this.LblNumberofLine.Text = "Number of Cubes";
            // 
            // TxtNumberOfCube
            // 
            this.TxtNumberOfCube.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumberOfCube.Location = new System.Drawing.Point(182, 45);
            this.TxtNumberOfCube.Name = "TxtNumberOfCube";
            this.TxtNumberOfCube.Size = new System.Drawing.Size(121, 28);
            this.TxtNumberOfCube.TabIndex = 48;
            this.TxtNumberOfCube.TextChanged += new System.EventHandler(this.TxtNumberOfLine_TextChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCube,
            this.ColOX,
            this.ColOY,
            this.ColOZ,
            this.ColFirstX,
            this.ColFirstY,
            this.ColFirstZ,
            this.ColIX,
            this.ColIY,
            this.ColIZ,
            this.ColC1,
            this.ColC2,
            this.ColC3});
            this.dataGridView.Location = new System.Drawing.Point(28, 89);
            this.dataGridView.Name = "dataGridView";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(956, 349);
            this.dataGridView.TabIndex = 47;
            // 
            // ColCube
            // 
            this.ColCube.Frozen = true;
            this.ColCube.HeaderText = "Cube";
            this.ColCube.Name = "ColCube";
            this.ColCube.ReadOnly = true;
            this.ColCube.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColOX
            // 
            this.ColOX.HeaderText = "OX";
            this.ColOX.Name = "ColOX";
            this.ColOX.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColOY
            // 
            this.ColOY.HeaderText = "OY";
            this.ColOY.Name = "ColOY";
            this.ColOY.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColOZ
            // 
            this.ColOZ.HeaderText = "OZ";
            this.ColOZ.Name = "ColOZ";
            this.ColOZ.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColFirstX
            // 
            this.ColFirstX.HeaderText = "FirstX";
            this.ColFirstX.Name = "ColFirstX";
            this.ColFirstX.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColFirstY
            // 
            this.ColFirstY.HeaderText = "FirstY";
            this.ColFirstY.Name = "ColFirstY";
            this.ColFirstY.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColFirstZ
            // 
            this.ColFirstZ.HeaderText = "FirstZ";
            this.ColFirstZ.Name = "ColFirstZ";
            this.ColFirstZ.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColIX
            // 
            this.ColIX.HeaderText = "SideX";
            this.ColIX.Name = "ColIX";
            this.ColIX.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColIY
            // 
            this.ColIY.HeaderText = "SideY";
            this.ColIY.Name = "ColIY";
            this.ColIY.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColIZ
            // 
            this.ColIZ.HeaderText = "SideZ";
            this.ColIZ.Name = "ColIZ";
            this.ColIZ.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColC1
            // 
            this.ColC1.HeaderText = "Red";
            this.ColC1.Name = "ColC1";
            this.ColC1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColC2
            // 
            this.ColC2.HeaderText = "Green";
            this.ColC2.Name = "ColC2";
            this.ColC2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColC3
            // 
            this.ColC3.HeaderText = "Blue";
            this.ColC3.Name = "ColC3";
            this.ColC3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.Color.DimGray;
            this.LblTitle.Location = new System.Drawing.Point(500, 9);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(149, 23);
            this.LblTitle.TabIndex = 53;
            this.LblTitle.Text = "INPUT FOR CUBE";
            // 
            // FrmInputCube
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1012, 477);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.BtnAccept);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnImport);
            this.Controls.Add(this.LblNumberofLine);
            this.Controls.Add(this.TxtNumberOfCube);
            this.Controls.Add(this.dataGridView);
            this.Name = "FrmInputCube";
            this.Text = "Input Cube";
            this.Load += new System.EventHandler(this.FrmInputCube_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnImport;
        private System.Windows.Forms.Label LblNumberofLine;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Button BtnAccept;
        private System.Windows.Forms.TextBox TxtNumberOfCube;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCube;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColOX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColOY;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColOZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFirstX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFirstY;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFirstZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIY;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColC1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColC2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColC3;
    }
}