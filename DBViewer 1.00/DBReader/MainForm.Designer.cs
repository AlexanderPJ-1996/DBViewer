
namespace DBReader
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PanCoStr = new System.Windows.Forms.Panel();
            this.LabCoStr = new System.Windows.Forms.Label();
            this.BtnConnC = new FontAwesome.Sharp.IconButton();
            this.BtnConnO = new FontAwesome.Sharp.IconButton();
            this.TBxCoStr = new System.Windows.Forms.TextBox();
            this.MsgBox = new System.Windows.Forms.ToolTip(this.components);
            this.BtnCleaD = new FontAwesome.Sharp.IconButton();
            this.BtnShowD = new FontAwesome.Sharp.IconButton();
            this.BtnCleaT = new FontAwesome.Sharp.IconButton();
            this.BtnTable = new FontAwesome.Sharp.IconButton();
            this.CBxState = new System.Windows.Forms.ComboBox();
            this.BtnExecu = new FontAwesome.Sharp.IconButton();
            this.BtnExcel = new FontAwesome.Sharp.IconButton();
            this.TBxState = new System.Windows.Forms.TextBox();
            this.DGVTable = new System.Windows.Forms.DataGridView();
            this.PanTable = new System.Windows.Forms.Panel();
            this.TBxTable = new System.Windows.Forms.TextBox();
            this.LabState = new System.Windows.Forms.Label();
            this.PanState = new System.Windows.Forms.Panel();
            this.TaCColum = new System.Windows.Forms.TabControl();
            this.TPgColum = new System.Windows.Forms.TabPage();
            this.DGVColum = new System.Windows.Forms.DataGridView();
            this.PanCoStr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTable)).BeginInit();
            this.PanTable.SuspendLayout();
            this.PanState.SuspendLayout();
            this.TaCColum.SuspendLayout();
            this.TPgColum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVColum)).BeginInit();
            this.SuspendLayout();
            // 
            // PanCoStr
            // 
            this.PanCoStr.BackColor = System.Drawing.Color.SeaGreen;
            this.PanCoStr.Controls.Add(this.LabCoStr);
            this.PanCoStr.Controls.Add(this.BtnConnC);
            this.PanCoStr.Controls.Add(this.BtnConnO);
            this.PanCoStr.Controls.Add(this.TBxCoStr);
            this.PanCoStr.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanCoStr.Location = new System.Drawing.Point(0, 0);
            this.PanCoStr.Name = "PanCoStr";
            this.PanCoStr.Size = new System.Drawing.Size(984, 90);
            this.PanCoStr.TabIndex = 0;
            // 
            // LabCoStr
            // 
            this.LabCoStr.AutoSize = true;
            this.LabCoStr.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabCoStr.ForeColor = System.Drawing.Color.White;
            this.LabCoStr.Location = new System.Drawing.Point(12, 12);
            this.LabCoStr.Name = "LabCoStr";
            this.LabCoStr.Size = new System.Drawing.Size(137, 19);
            this.LabCoStr.TabIndex = 0;
            this.LabCoStr.Text = "ConnectionString";
            // 
            // BtnConnC
            // 
            this.BtnConnC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnConnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConnC.ForeColor = System.Drawing.Color.White;
            this.BtnConnC.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.BtnConnC.IconColor = System.Drawing.Color.White;
            this.BtnConnC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnConnC.IconSize = 30;
            this.BtnConnC.Location = new System.Drawing.Point(847, 44);
            this.BtnConnC.Name = "BtnConnC";
            this.BtnConnC.Size = new System.Drawing.Size(125, 40);
            this.BtnConnC.TabIndex = 3;
            this.BtnConnC.Text = "Disconnect";
            this.BtnConnC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnConnC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MsgBox.SetToolTip(this.BtnConnC, "Close connection");
            this.BtnConnC.UseVisualStyleBackColor = true;
            this.BtnConnC.Visible = false;
            this.BtnConnC.Click += new System.EventHandler(this.BtnConnC_Click);
            // 
            // BtnConnO
            // 
            this.BtnConnO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConnO.ForeColor = System.Drawing.Color.White;
            this.BtnConnO.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.BtnConnO.IconColor = System.Drawing.Color.White;
            this.BtnConnO.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnConnO.IconSize = 30;
            this.BtnConnO.Location = new System.Drawing.Point(155, 44);
            this.BtnConnO.Name = "BtnConnO";
            this.BtnConnO.Size = new System.Drawing.Size(125, 40);
            this.BtnConnO.TabIndex = 2;
            this.BtnConnO.Text = "Connect";
            this.BtnConnO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnConnO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MsgBox.SetToolTip(this.BtnConnO, "Connect to database");
            this.BtnConnO.UseVisualStyleBackColor = true;
            this.BtnConnO.Visible = false;
            this.BtnConnO.Click += new System.EventHandler(this.BtnConnO_Click);
            // 
            // TBxCoStr
            // 
            this.TBxCoStr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBxCoStr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBxCoStr.Location = new System.Drawing.Point(155, 12);
            this.TBxCoStr.Name = "TBxCoStr";
            this.TBxCoStr.Size = new System.Drawing.Size(817, 26);
            this.TBxCoStr.TabIndex = 1;
            this.MsgBox.SetToolTip(this.TBxCoStr, "ConnectionString for SQL Server database");
            this.TBxCoStr.TextChanged += new System.EventHandler(this.TBxCoStr_TextChanged);
            // 
            // BtnCleaD
            // 
            this.BtnCleaD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnCleaD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCleaD.ForeColor = System.Drawing.Color.White;
            this.BtnCleaD.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.BtnCleaD.IconColor = System.Drawing.Color.White;
            this.BtnCleaD.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCleaD.IconSize = 30;
            this.BtnCleaD.Location = new System.Drawing.Point(237, 429);
            this.BtnCleaD.Name = "BtnCleaD";
            this.BtnCleaD.Size = new System.Drawing.Size(125, 40);
            this.BtnCleaD.TabIndex = 5;
            this.BtnCleaD.Text = "Clear data";
            this.BtnCleaD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCleaD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MsgBox.SetToolTip(this.BtnCleaD, "Clean data from table/view");
            this.BtnCleaD.UseVisualStyleBackColor = true;
            this.BtnCleaD.Click += new System.EventHandler(this.BtnCleaD_Click);
            // 
            // BtnShowD
            // 
            this.BtnShowD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnShowD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnShowD.ForeColor = System.Drawing.Color.White;
            this.BtnShowD.IconChar = FontAwesome.Sharp.IconChar.List;
            this.BtnShowD.IconColor = System.Drawing.Color.White;
            this.BtnShowD.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnShowD.IconSize = 30;
            this.BtnShowD.Location = new System.Drawing.Point(12, 429);
            this.BtnShowD.Name = "BtnShowD";
            this.BtnShowD.Size = new System.Drawing.Size(125, 40);
            this.BtnShowD.TabIndex = 4;
            this.BtnShowD.Text = "Show data";
            this.BtnShowD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnShowD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MsgBox.SetToolTip(this.BtnShowD, "Display data from table/view");
            this.BtnShowD.UseVisualStyleBackColor = true;
            this.BtnShowD.Click += new System.EventHandler(this.BtnShowD_Click);
            // 
            // BtnCleaT
            // 
            this.BtnCleaT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCleaT.ForeColor = System.Drawing.Color.White;
            this.BtnCleaT.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.BtnCleaT.IconColor = System.Drawing.Color.White;
            this.BtnCleaT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCleaT.IconSize = 30;
            this.BtnCleaT.Location = new System.Drawing.Point(237, 6);
            this.BtnCleaT.Name = "BtnCleaT";
            this.BtnCleaT.Size = new System.Drawing.Size(125, 40);
            this.BtnCleaT.TabIndex = 1;
            this.BtnCleaT.Text = "Clean";
            this.BtnCleaT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCleaT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MsgBox.SetToolTip(this.BtnCleaT, "Clean up database tables and views");
            this.BtnCleaT.UseVisualStyleBackColor = true;
            this.BtnCleaT.Click += new System.EventHandler(this.BtnCleaT_Click);
            // 
            // BtnTable
            // 
            this.BtnTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTable.ForeColor = System.Drawing.Color.White;
            this.BtnTable.IconChar = FontAwesome.Sharp.IconChar.List;
            this.BtnTable.IconColor = System.Drawing.Color.White;
            this.BtnTable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnTable.IconSize = 30;
            this.BtnTable.Location = new System.Drawing.Point(12, 6);
            this.BtnTable.Name = "BtnTable";
            this.BtnTable.Size = new System.Drawing.Size(125, 40);
            this.BtnTable.TabIndex = 0;
            this.BtnTable.Text = "List";
            this.BtnTable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MsgBox.SetToolTip(this.BtnTable, "Display database tables and views");
            this.BtnTable.UseVisualStyleBackColor = true;
            this.BtnTable.Click += new System.EventHandler(this.BtnTable_Click);
            // 
            // CBxState
            // 
            this.CBxState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBxState.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CBxState.FormattingEnabled = true;
            this.CBxState.Location = new System.Drawing.Point(133, 54);
            this.CBxState.Name = "CBxState";
            this.CBxState.Size = new System.Drawing.Size(200, 27);
            this.CBxState.TabIndex = 1;
            this.MsgBox.SetToolTip(this.CBxState, "Select SQL statement type");
            this.CBxState.SelectedIndexChanged += new System.EventHandler(this.CBxState_SelectedIndexChanged);
            // 
            // BtnExecu
            // 
            this.BtnExecu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExecu.ForeColor = System.Drawing.Color.White;
            this.BtnExecu.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.BtnExecu.IconColor = System.Drawing.Color.White;
            this.BtnExecu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnExecu.IconSize = 30;
            this.BtnExecu.Location = new System.Drawing.Point(381, 8);
            this.BtnExecu.Name = "BtnExecu";
            this.BtnExecu.Size = new System.Drawing.Size(125, 40);
            this.BtnExecu.TabIndex = 4;
            this.BtnExecu.Text = "Execute";
            this.BtnExecu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExecu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MsgBox.SetToolTip(this.BtnExecu, "Execute SQL statement");
            this.BtnExecu.UseVisualStyleBackColor = true;
            this.BtnExecu.Click += new System.EventHandler(this.BtnExecu_Click);
            // 
            // BtnExcel
            // 
            this.BtnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExcel.ForeColor = System.Drawing.Color.White;
            this.BtnExcel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.BtnExcel.IconColor = System.Drawing.Color.White;
            this.BtnExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnExcel.IconSize = 30;
            this.BtnExcel.Location = new System.Drawing.Point(847, 8);
            this.BtnExcel.Name = "BtnExcel";
            this.BtnExcel.Size = new System.Drawing.Size(125, 40);
            this.BtnExcel.TabIndex = 5;
            this.BtnExcel.Text = "Export";
            this.BtnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MsgBox.SetToolTip(this.BtnExcel, "Export data to Excel file");
            this.BtnExcel.UseVisualStyleBackColor = true;
            this.BtnExcel.Click += new System.EventHandler(this.BtnExcel_Click);
            // 
            // TBxState
            // 
            this.TBxState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBxState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBxState.Location = new System.Drawing.Point(339, 54);
            this.TBxState.Name = "TBxState";
            this.TBxState.Size = new System.Drawing.Size(633, 26);
            this.TBxState.TabIndex = 2;
            this.MsgBox.SetToolTip(this.TBxState, "Write SQL statement to execute");
            // 
            // DGVTable
            // 
            this.DGVTable.AllowUserToAddRows = false;
            this.DGVTable.AllowUserToDeleteRows = false;
            this.DGVTable.AllowUserToOrderColumns = true;
            this.DGVTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DGVTable.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DGVTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTable.Location = new System.Drawing.Point(12, 52);
            this.DGVTable.Name = "DGVTable";
            this.DGVTable.ReadOnly = true;
            this.DGVTable.RowTemplate.Height = 30;
            this.DGVTable.Size = new System.Drawing.Size(350, 366);
            this.DGVTable.TabIndex = 2;
            this.DGVTable.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVTable_CellEnter);
            // 
            // PanTable
            // 
            this.PanTable.Controls.Add(this.DGVTable);
            this.PanTable.Controls.Add(this.BtnCleaT);
            this.PanTable.Controls.Add(this.BtnTable);
            this.PanTable.Controls.Add(this.TBxTable);
            this.PanTable.Controls.Add(this.BtnCleaD);
            this.PanTable.Controls.Add(this.BtnShowD);
            this.PanTable.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanTable.Location = new System.Drawing.Point(0, 90);
            this.PanTable.Name = "PanTable";
            this.PanTable.Size = new System.Drawing.Size(375, 481);
            this.PanTable.TabIndex = 1;
            this.PanTable.Visible = false;
            // 
            // TBxTable
            // 
            this.TBxTable.Enabled = false;
            this.TBxTable.Location = new System.Drawing.Point(37, 76);
            this.TBxTable.Name = "TBxTable";
            this.TBxTable.Size = new System.Drawing.Size(100, 26);
            this.TBxTable.TabIndex = 3;
            // 
            // LabState
            // 
            this.LabState.AutoSize = true;
            this.LabState.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabState.ForeColor = System.Drawing.Color.White;
            this.LabState.Location = new System.Drawing.Point(8, 54);
            this.LabState.Name = "LabState";
            this.LabState.Size = new System.Drawing.Size(115, 19);
            this.LabState.TabIndex = 0;
            this.LabState.Text = "SQL statement";
            // 
            // PanState
            // 
            this.PanState.BackColor = System.Drawing.Color.SeaGreen;
            this.PanState.Controls.Add(this.BtnExcel);
            this.PanState.Controls.Add(this.BtnExecu);
            this.PanState.Controls.Add(this.TBxState);
            this.PanState.Controls.Add(this.CBxState);
            this.PanState.Controls.Add(this.LabState);
            this.PanState.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanState.Location = new System.Drawing.Point(0, 571);
            this.PanState.Name = "PanState";
            this.PanState.Size = new System.Drawing.Size(984, 90);
            this.PanState.TabIndex = 3;
            this.PanState.Visible = false;
            // 
            // TaCColum
            // 
            this.TaCColum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TaCColum.Controls.Add(this.TPgColum);
            this.TaCColum.Location = new System.Drawing.Point(381, 96);
            this.TaCColum.Multiline = true;
            this.TaCColum.Name = "TaCColum";
            this.TaCColum.SelectedIndex = 0;
            this.TaCColum.Size = new System.Drawing.Size(591, 469);
            this.TaCColum.TabIndex = 2;
            // 
            // TPgColum
            // 
            this.TPgColum.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TPgColum.Controls.Add(this.DGVColum);
            this.TPgColum.Location = new System.Drawing.Point(4, 28);
            this.TPgColum.Name = "TPgColum";
            this.TPgColum.Padding = new System.Windows.Forms.Padding(3);
            this.TPgColum.Size = new System.Drawing.Size(583, 437);
            this.TPgColum.TabIndex = 0;
            this.TPgColum.Text = "Table/View Columns";
            // 
            // DGVColum
            // 
            this.DGVColum.AllowUserToAddRows = false;
            this.DGVColum.AllowUserToDeleteRows = false;
            this.DGVColum.AllowUserToOrderColumns = true;
            this.DGVColum.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DGVColum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVColum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVColum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVColum.Location = new System.Drawing.Point(3, 3);
            this.DGVColum.Name = "DGVColum";
            this.DGVColum.ReadOnly = true;
            this.DGVColum.RowTemplate.Height = 30;
            this.DGVColum.Size = new System.Drawing.Size(577, 431);
            this.DGVColum.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.TaCColum);
            this.Controls.Add(this.PanTable);
            this.Controls.Add(this.PanCoStr);
            this.Controls.Add(this.PanState);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.PanCoStr.ResumeLayout(false);
            this.PanCoStr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTable)).EndInit();
            this.PanTable.ResumeLayout(false);
            this.PanTable.PerformLayout();
            this.PanState.ResumeLayout(false);
            this.PanState.PerformLayout();
            this.TaCColum.ResumeLayout(false);
            this.TPgColum.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVColum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanCoStr;
        private FontAwesome.Sharp.IconButton BtnConnO;
        private System.Windows.Forms.TextBox TBxCoStr;
        private FontAwesome.Sharp.IconButton BtnConnC;
        private System.Windows.Forms.ToolTip MsgBox;
        private System.Windows.Forms.Label LabCoStr;
        private System.Windows.Forms.DataGridView DGVTable;
        private System.Windows.Forms.Panel PanTable;
        private FontAwesome.Sharp.IconButton BtnCleaD;
        private FontAwesome.Sharp.IconButton BtnShowD;
        private System.Windows.Forms.TextBox TBxTable;
        private FontAwesome.Sharp.IconButton BtnCleaT;
        private FontAwesome.Sharp.IconButton BtnTable;
        private System.Windows.Forms.ComboBox CBxState;
        private System.Windows.Forms.Label LabState;
        private System.Windows.Forms.TextBox TBxState;
        private FontAwesome.Sharp.IconButton BtnExecu;
        private System.Windows.Forms.Panel PanState;
        private FontAwesome.Sharp.IconButton BtnExcel;
        private System.Windows.Forms.TabControl TaCColum;
        private System.Windows.Forms.TabPage TPgColum;
        private System.Windows.Forms.DataGridView DGVColum;
    }
}

