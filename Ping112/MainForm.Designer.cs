
namespace Ping112
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSettingsImport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSettingsParametersPing = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvListDds = new System.Windows.Forms.DataGridView();
            this.ddsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vipNetCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtkCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pcsCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListDds)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1170, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSettingsImport,
            this.tsmiSettingsParametersPing});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 19);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // tsmiSettingsImport
            // 
            this.tsmiSettingsImport.Name = "tsmiSettingsImport";
            this.tsmiSettingsImport.Size = new System.Drawing.Size(169, 22);
            this.tsmiSettingsImport.Text = "Импорт таблицы";
            this.tsmiSettingsImport.Click += new System.EventHandler(this.TsmiSettingsImport_Click);
            // 
            // tsmiSettingsParametersPing
            // 
            this.tsmiSettingsParametersPing.Name = "tsmiSettingsParametersPing";
            this.tsmiSettingsParametersPing.Size = new System.Drawing.Size(169, 22);
            this.tsmiSettingsParametersPing.Text = "Параметры ping";
            this.tsmiSettingsParametersPing.Click += new System.EventHandler(this.TsmiSettingsParametersPing_Click);
            // 
            // dgvListDds
            // 
            this.dgvListDds.AllowUserToAddRows = false;
            this.dgvListDds.AllowUserToDeleteRows = false;
            this.dgvListDds.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvListDds.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListDds.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListDds.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvListDds.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvListDds.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListDds.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListDds.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListDds.ColumnHeadersHeight = 40;
            this.dgvListDds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvListDds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ddsName,
            this.vipNetCol,
            this.rtkCol,
            this.pcsCol,
            this.phoneCol});
            this.dgvListDds.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListDds.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListDds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListDds.Location = new System.Drawing.Point(4, 5);
            this.dgvListDds.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvListDds.MultiSelect = false;
            this.dgvListDds.Name = "dgvListDds";
            this.dgvListDds.ReadOnly = true;
            this.dgvListDds.RowHeadersWidth = 25;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvListDds.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvListDds.Size = new System.Drawing.Size(1162, 655);
            this.dgvListDds.TabIndex = 1;
            this.dgvListDds.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListDds_CellClick);
            this.dgvListDds.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DgvListDds_CellPainting);
            this.dgvListDds.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dataGridView1_Scroll);
            this.dgvListDds.DoubleClick += new System.EventHandler(this.DataGridView1_DoubleClick);
            // 
            // ddsName
            // 
            this.ddsName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ddsName.DataPropertyName = "Name";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.ddsName.DefaultCellStyle = dataGridViewCellStyle3;
            this.ddsName.FillWeight = 82.49639F;
            this.ddsName.HeaderText = "Служба";
            this.ddsName.Name = "ddsName";
            this.ddsName.ReadOnly = true;
            // 
            // vipNetCol
            // 
            this.vipNetCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.vipNetCol.DataPropertyName = "IpVipNet";
            this.vipNetCol.FillWeight = 5F;
            this.vipNetCol.HeaderText = "VipNet";
            this.vipNetCol.Name = "vipNetCol";
            this.vipNetCol.ReadOnly = true;
            this.vipNetCol.Width = 50;
            // 
            // rtkCol
            // 
            this.rtkCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.rtkCol.DataPropertyName = "IpRTK";
            this.rtkCol.FillWeight = 8.653846F;
            this.rtkCol.HeaderText = "RTK";
            this.rtkCol.Name = "rtkCol";
            this.rtkCol.ReadOnly = true;
            this.rtkCol.Width = 50;
            // 
            // pcsCol
            // 
            this.pcsCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.pcsCol.DataPropertyName = "IpPcs";
            this.pcsCol.FillWeight = 4.817307F;
            this.pcsCol.HeaderText = "PCs";
            this.pcsCol.Name = "pcsCol";
            this.pcsCol.ReadOnly = true;
            this.pcsCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pcsCol.Width = 50;
            // 
            // phoneCol
            // 
            this.phoneCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.phoneCol.DataPropertyName = "IpPhones";
            this.phoneCol.FillWeight = 9.032453F;
            this.phoneCol.HeaderText = "SIPs";
            this.phoneCol.Name = "phoneCol";
            this.phoneCol.ReadOnly = true;
            this.phoneCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.phoneCol.Width = 50;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.dgvListDds, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1170, 665);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 690);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Рабочее место системного администратора 112 by Макарьин В.Д.";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListDds)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiSettingsImport;
        private System.Windows.Forms.ToolStripMenuItem tsmiSettingsParametersPing;
        private System.Windows.Forms.DataGridView dgvListDds;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ddsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn vipNetCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn rtkCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn pcsCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneCol;
    }
}

