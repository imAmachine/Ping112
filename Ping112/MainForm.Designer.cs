
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.импортТаблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.параметрыPingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_ShowClose = new System.Windows.Forms.Button();
            this.btn_DeletePrimary = new System.Windows.Forms.Button();
            this.tb_PrimaryFilter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_DelSelected = new System.Windows.Forms.Button();
            this.btn_ClearSecondaryFilters = new System.Windows.Forms.Button();
            this.chkb_UseFilters = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_SecondaryFilters = new System.Windows.Forms.ListBox();
            this.btnFilterAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.ddsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vipNetCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtkCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pcsCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(655, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.импортТаблицыToolStripMenuItem,
            this.параметрыPingToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // импортТаблицыToolStripMenuItem
            // 
            this.импортТаблицыToolStripMenuItem.Name = "импортТаблицыToolStripMenuItem";
            this.импортТаблицыToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.импортТаблицыToolStripMenuItem.Text = "Импорт таблицы";
            this.импортТаблицыToolStripMenuItem.Click += new System.EventHandler(this.импортТаблицыToolStripMenuItem_Click);
            // 
            // параметрыPingToolStripMenuItem
            // 
            this.параметрыPingToolStripMenuItem.Name = "параметрыPingToolStripMenuItem";
            this.параметрыPingToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.параметрыPingToolStripMenuItem.Text = "Параметры ping";
            this.параметрыPingToolStripMenuItem.Click += new System.EventHandler(this.параметрыPingToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Snow;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ddsName,
            this.vipNetCol,
            this.rtkCol,
            this.pcsCol,
            this.phoneCol});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowHeadersWidth = 25;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Size = new System.Drawing.Size(382, 420);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
            this.dataGridView1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dataGridView1_Scroll);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 267F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(655, 426);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_ShowClose);
            this.panel2.Controls.Add(this.btn_DeletePrimary);
            this.panel2.Controls.Add(this.tb_PrimaryFilter);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.btn_DelSelected);
            this.panel2.Controls.Add(this.btn_ClearSecondaryFilters);
            this.panel2.Controls.Add(this.chkb_UseFilters);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lb_SecondaryFilters);
            this.panel2.Controls.Add(this.btnFilterAdd);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tb_Search);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(391, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 420);
            this.panel2.TabIndex = 3;
            // 
            // btn_ShowClose
            // 
            this.btn_ShowClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_ShowClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ShowClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_ShowClose.FlatAppearance.BorderSize = 0;
            this.btn_ShowClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_ShowClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ShowClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_ShowClose.Location = new System.Drawing.Point(-1, -1);
            this.btn_ShowClose.Name = "btn_ShowClose";
            this.btn_ShowClose.Size = new System.Drawing.Size(41, 423);
            this.btn_ShowClose.TabIndex = 15;
            this.btn_ShowClose.Text = "<<";
            this.btn_ShowClose.UseVisualStyleBackColor = true;
            this.btn_ShowClose.Click += new System.EventHandler(this.btn_ShowClose_Click);
            // 
            // btn_DeletePrimary
            // 
            this.btn_DeletePrimary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DeletePrimary.Location = new System.Drawing.Point(46, 159);
            this.btn_DeletePrimary.Name = "btn_DeletePrimary";
            this.btn_DeletePrimary.Size = new System.Drawing.Size(207, 23);
            this.btn_DeletePrimary.TabIndex = 14;
            this.btn_DeletePrimary.Text = "Удалить первичный фильтр";
            this.btn_DeletePrimary.UseVisualStyleBackColor = true;
            this.btn_DeletePrimary.Click += new System.EventHandler(this.btnDeletePrimary_Click);
            // 
            // tb_PrimaryFilter
            // 
            this.tb_PrimaryFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_PrimaryFilter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_PrimaryFilter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_PrimaryFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_PrimaryFilter.Location = new System.Drawing.Point(46, 133);
            this.tb_PrimaryFilter.Name = "tb_PrimaryFilter";
            this.tb_PrimaryFilter.ReadOnly = true;
            this.tb_PrimaryFilter.Size = new System.Drawing.Size(205, 16);
            this.tb_PrimaryFilter.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(42, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Первичный фильтр:";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(162, 59);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 29);
            this.button3.TabIndex = 11;
            this.button3.Text = "+ secondary";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnSecondaryAdd_Click);
            // 
            // btn_DelSelected
            // 
            this.btn_DelSelected.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DelSelected.Location = new System.Drawing.Point(46, 387);
            this.btn_DelSelected.Name = "btn_DelSelected";
            this.btn_DelSelected.Size = new System.Drawing.Size(206, 23);
            this.btn_DelSelected.TabIndex = 10;
            this.btn_DelSelected.Text = "Удалить выбранные вторичные";
            this.btn_DelSelected.UseVisualStyleBackColor = true;
            this.btn_DelSelected.Click += new System.EventHandler(this.btn_DelSelected_Click);
            // 
            // btn_ClearSecondaryFilters
            // 
            this.btn_ClearSecondaryFilters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ClearSecondaryFilters.Location = new System.Drawing.Point(46, 358);
            this.btn_ClearSecondaryFilters.Name = "btn_ClearSecondaryFilters";
            this.btn_ClearSecondaryFilters.Size = new System.Drawing.Size(206, 23);
            this.btn_ClearSecondaryFilters.TabIndex = 9;
            this.btn_ClearSecondaryFilters.Text = "Очистить все вторичные";
            this.btn_ClearSecondaryFilters.UseVisualStyleBackColor = true;
            this.btn_ClearSecondaryFilters.Click += new System.EventHandler(this.button1_Click);
            // 
            // chkb_UseFilters
            // 
            this.chkb_UseFilters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkb_UseFilters.AutoSize = true;
            this.chkb_UseFilters.Checked = true;
            this.chkb_UseFilters.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkb_UseFilters.Location = new System.Drawing.Point(46, 335);
            this.chkb_UseFilters.Name = "chkb_UseFilters";
            this.chkb_UseFilters.Size = new System.Drawing.Size(147, 17);
            this.chkb_UseFilters.TabIndex = 8;
            this.chkb_UseFilters.Text = "Использовать фильтры";
            this.chkb_UseFilters.UseVisualStyleBackColor = true;
            this.chkb_UseFilters.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(42, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Выборки по фильтрам:";
            // 
            // lb_SecondaryFilters
            // 
            this.lb_SecondaryFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_SecondaryFilters.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_SecondaryFilters.FormattingEnabled = true;
            this.lb_SecondaryFilters.ItemHeight = 21;
            this.lb_SecondaryFilters.Location = new System.Drawing.Point(46, 212);
            this.lb_SecondaryFilters.Name = "lb_SecondaryFilters";
            this.lb_SecondaryFilters.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lb_SecondaryFilters.Size = new System.Drawing.Size(206, 109);
            this.lb_SecondaryFilters.TabIndex = 6;
            // 
            // btnFilterAdd
            // 
            this.btnFilterAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFilterAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterAdd.Location = new System.Drawing.Point(46, 59);
            this.btnFilterAdd.Name = "btnFilterAdd";
            this.btnFilterAdd.Size = new System.Drawing.Size(90, 29);
            this.btnFilterAdd.TabIndex = 5;
            this.btnFilterAdd.Text = "+ primary";
            this.btnFilterAdd.UseVisualStyleBackColor = true;
            this.btnFilterAdd.Click += new System.EventHandler(this.btnFilterAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(42, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Фильтрация по названию";
            // 
            // tb_Search
            // 
            this.tb_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_Search.Location = new System.Drawing.Point(46, 24);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(206, 29);
            this.tb_Search.TabIndex = 3;
            this.tb_Search.TextChanged += new System.EventHandler(this.tb_Search_TextChanged);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Рабочее место системного администратора 112 by Макарьин В.Д.";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem импортТаблицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem параметрыPingToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnFilterAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.ListBox lb_SecondaryFilters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_DelSelected;
        private System.Windows.Forms.Button btn_ClearSecondaryFilters;
        private System.Windows.Forms.CheckBox chkb_UseFilters;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_PrimaryFilter;
        private System.Windows.Forms.Button btn_DeletePrimary;
        private System.Windows.Forms.Button btn_ShowClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn ddsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn vipNetCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn rtkCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn pcsCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneCol;
    }
}

