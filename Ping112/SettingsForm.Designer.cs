
namespace Ping112
{
    partial class SettingsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.nudPingTimeout = new System.Windows.Forms.NumericUpDown();
            this.nudPingDelay = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPingTimeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPingDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ping timeout:";
            // 
            // nudPingTimeout
            // 
            this.nudPingTimeout.Location = new System.Drawing.Point(86, 16);
            this.nudPingTimeout.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudPingTimeout.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudPingTimeout.Name = "nudPingTimeout";
            this.nudPingTimeout.Size = new System.Drawing.Size(135, 20);
            this.nudPingTimeout.TabIndex = 1;
            this.nudPingTimeout.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // nudPingDelay
            // 
            this.nudPingDelay.Location = new System.Drawing.Point(106, 42);
            this.nudPingDelay.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudPingDelay.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudPingDelay.Name = "nudPingDelay";
            this.nudPingDelay.Size = new System.Drawing.Size(115, 20);
            this.nudPingDelay.TabIndex = 3;
            this.nudPingDelay.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ping query delay:";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(146, 68);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 111);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.nudPingDelay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudPingTimeout);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройки Ping";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPingTimeout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPingDelay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudPingTimeout;
        private System.Windows.Forms.NumericUpDown nudPingDelay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_save;
    }
}