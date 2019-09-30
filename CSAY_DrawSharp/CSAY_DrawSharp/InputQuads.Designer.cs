namespace CSAY_DrawSharp
{
    partial class FrmInputQuads
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LblTitle = new System.Windows.Forms.Label();
            this.BtnAccept = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnImport = new System.Windows.Forms.Button();
            this.LblNumberofLine = new System.Windows.Forms.Label();
            this.TxtNumberOfQuads = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ColLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColOX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColOY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColOZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColX3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColY3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColZ3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColX4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColY4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColZ4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColC1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColC2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColC3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.Color.DimGray;
            this.LblTitle.Location = new System.Drawing.Point(500, 11);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(168, 23);
            this.LblTitle.TabIndex = 61;
            this.LblTitle.Text = "INPUT FOR QUADS";
            // 
            // BtnAccept
            // 
            this.BtnAccept.BackColor = System.Drawing.Color.White;
            this.BtnAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAccept.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnAccept.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAccept.ForeColor = System.Drawing.Color.DimGray;
            this.BtnAccept.Location = new System.Drawing.Point(537, 41);
            this.BtnAccept.Name = "BtnAccept";
            this.BtnAccept.Size = new System.Drawing.Size(202, 34);
            this.BtnAccept.TabIndex = 60;
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
            this.BtnExit.Location = new System.Drawing.Point(754, 41);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(202, 34);
            this.BtnExit.TabIndex = 59;
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
            this.BtnImport.Location = new System.Drawing.Point(315, 42);
            this.BtnImport.Name = "BtnImport";
            this.BtnImport.Size = new System.Drawing.Size(202, 34);
            this.BtnImport.TabIndex = 58;
            this.BtnImport.Text = "Import From Excel";
            this.BtnImport.UseVisualStyleBackColor = false;
            this.BtnImport.Click += new System.EventHandler(this.BtnImport_Click);
            // 
            // LblNumberofLine
            // 
            this.LblNumberofLine.AutoSize = true;
            this.LblNumberofLine.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumberofLine.ForeColor = System.Drawing.Color.DimGray;
            this.LblNumberofLine.Location = new System.Drawing.Point(15, 50);
            this.LblNumberofLine.Name = "LblNumberofLine";
            this.LblNumberofLine.Size = new System.Drawing.Size(140, 23);
            this.LblNumberofLine.TabIndex = 57;
            this.LblNumberofLine.Text = "Number of Quads";
            // 
            // TxtNumberOfQuads
            // 
            this.TxtNumberOfQuads.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumberOfQuads.Location = new System.Drawing.Point(166, 47);
            this.TxtNumberOfQuads.Name = "TxtNumberOfQuads";
            this.TxtNumberOfQuads.Size = new System.Drawing.Size(121, 28);
            this.TxtNumberOfQuads.TabIndex = 56;
            this.TxtNumberOfQuads.TextChanged += new System.EventHandler(this.TxtNumberOfQuads_TextChanged);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColLine,
            this.ColOX,
            this.ColOY,
            this.ColOZ,
            this.ColIX,
            this.ColIY,
            this.ColIZ,
            this.ColFX,
            this.ColFY,
            this.ColFZ,
            this.ColX3,
            this.ColY3,
            this.ColZ3,
            this.ColX4,
            this.ColY4,
            this.ColZ4,
            this.ColC1,
            this.ColC2,
            this.ColC3});
            this.dataGridView.Location = new System.Drawing.Point(12, 91);
            this.dataGridView.Name = "dataGridView";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(956, 349);
            this.dataGridView.TabIndex = 55;
            // 
            // ColLine
            // 
            this.ColLine.Frozen = true;
            this.ColLine.HeaderText = "Line";
            this.ColLine.Name = "ColLine";
            this.ColLine.ReadOnly = true;
            this.ColLine.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColLine.Width = 60;
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
            // ColIX
            // 
            this.ColIX.HeaderText = "X1";
            this.ColIX.Name = "ColIX";
            this.ColIX.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColIY
            // 
            this.ColIY.HeaderText = "Y1";
            this.ColIY.Name = "ColIY";
            this.ColIY.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColIZ
            // 
            this.ColIZ.HeaderText = "Z1";
            this.ColIZ.Name = "ColIZ";
            this.ColIZ.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColFX
            // 
            this.ColFX.HeaderText = "X2";
            this.ColFX.Name = "ColFX";
            this.ColFX.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColFY
            // 
            this.ColFY.HeaderText = "Y2";
            this.ColFY.Name = "ColFY";
            this.ColFY.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColFZ
            // 
            this.ColFZ.HeaderText = "Z2";
            this.ColFZ.Name = "ColFZ";
            this.ColFZ.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColX3
            // 
            this.ColX3.HeaderText = "X3";
            this.ColX3.Name = "ColX3";
            this.ColX3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColY3
            // 
            this.ColY3.HeaderText = "Y3";
            this.ColY3.Name = "ColY3";
            this.ColY3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColZ3
            // 
            this.ColZ3.HeaderText = "Z3";
            this.ColZ3.Name = "ColZ3";
            this.ColZ3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColX4
            // 
            this.ColX4.HeaderText = "X4";
            this.ColX4.Name = "ColX4";
            this.ColX4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColY4
            // 
            this.ColY4.HeaderText = "Y4";
            this.ColY4.Name = "ColY4";
            this.ColY4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColZ4
            // 
            this.ColZ4.HeaderText = "Z4";
            this.ColZ4.Name = "ColZ4";
            this.ColZ4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColC1
            // 
            this.ColC1.HeaderText = "C1";
            this.ColC1.Name = "ColC1";
            this.ColC1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColC2
            // 
            this.ColC2.HeaderText = "C2";
            this.ColC2.Name = "ColC2";
            this.ColC2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColC3
            // 
            this.ColC3.HeaderText = "C3";
            this.ColC3.Name = "ColC3";
            this.ColC3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FrmInputQuads
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(980, 450);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.BtnAccept);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnImport);
            this.Controls.Add(this.LblNumberofLine);
            this.Controls.Add(this.TxtNumberOfQuads);
            this.Controls.Add(this.dataGridView);
            this.Name = "FrmInputQuads";
            this.Text = "InputQuads";
            this.Load += new System.EventHandler(this.FrmInputQuads_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Button BtnAccept;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnImport;
        private System.Windows.Forms.Label LblNumberofLine;
        private System.Windows.Forms.TextBox TxtNumberOfQuads;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColOX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColOY;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColOZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIY;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFY;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColX3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColY3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColZ3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColX4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColY4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColZ4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColC1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColC2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColC3;
    }
}