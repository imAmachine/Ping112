﻿
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.импортТаблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.параметрыPingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ddsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vipNetCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtkCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pcsCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnFilterAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
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
            this.menuStrip1.Size = new System.Drawing.Size(933, 24);
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
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Snow;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ddsName,
            this.vipNetCol,
            this.rtkCol,
            this.pcsCol,
            this.phoneCol});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(714, 420);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.VirtualMode = true;
            this.dataGridView1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dataGridView1_Scroll);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // ddsName
            // 
            this.ddsName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ddsName.DataPropertyName = "Name";
            this.ddsName.FillWeight = 150F;
            this.ddsName.HeaderText = "Служба";
            this.ddsName.Name = "ddsName";
            this.ddsName.ReadOnly = true;
            this.ddsName.Width = 82;
            // 
            // vipNetCol
            // 
            this.vipNetCol.DataPropertyName = "IpVipNet";
            this.vipNetCol.FillWeight = 50F;
            this.vipNetCol.HeaderText = "VipNet";
            this.vipNetCol.Name = "vipNetCol";
            this.vipNetCol.ReadOnly = true;
            // 
            // rtkCol
            // 
            this.rtkCol.DataPropertyName = "IpRTK";
            this.rtkCol.FillWeight = 49.34382F;
            this.rtkCol.HeaderText = "Коммутатор РТК";
            this.rtkCol.Name = "rtkCol";
            this.rtkCol.ReadOnly = true;
            // 
            // pcsCol
            // 
            this.pcsCol.DataPropertyName = "IpPcs";
            this.pcsCol.FillWeight = 49.34382F;
            this.pcsCol.HeaderText = "Компьютеры";
            this.pcsCol.Name = "pcsCol";
            this.pcsCol.ReadOnly = true;
            this.pcsCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // phoneCol
            // 
            this.phoneCol.DataPropertyName = "IpPhones";
            this.phoneCol.FillWeight = 49.34382F;
            this.phoneCol.HeaderText = "Телефоны";
            this.phoneCol.Name = "phoneCol";
            this.phoneCol.ReadOnly = true;
            this.phoneCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.232F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.76799F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(933, 426);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Controls.Add(this.btnFilterAdd);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(723, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 420);
            this.panel2.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(117, 59);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 29);
            this.button3.TabIndex = 11;
            this.button3.Text = "+ secondary";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(9, 387);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Удалить выбранные";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(9, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Очистить все";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(9, 335);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(147, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Использовать фильтры";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(5, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Выборки по фильтрам:";
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(9, 212);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(189, 109);
            this.listBox1.TabIndex = 6;
            // 
            // btnFilterAdd
            // 
            this.btnFilterAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFilterAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterAdd.Location = new System.Drawing.Point(9, 59);
            this.btnFilterAdd.Name = "btnFilterAdd";
            this.btnFilterAdd.Size = new System.Drawing.Size(81, 29);
            this.btnFilterAdd.TabIndex = 5;
            this.btnFilterAdd.Text = "+ primary";
            this.btnFilterAdd.UseVisualStyleBackColor = true;
            this.btnFilterAdd.Click += new System.EventHandler(this.btnFilterAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Фильтрация по названию";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(9, 24);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(189, 29);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(5, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Первичный фильтр:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 133);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(189, 20);
            this.textBox1.TabIndex = 13;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(9, 159);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(189, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "Удалить фильтр";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monitoring 112 by Макарьин В.Д.";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ClientSizeChanged += new System.EventHandler(this.MainForm_ClientSizeChanged);
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
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ddsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn vipNetCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn rtkCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn pcsCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneCol;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
    }
}
