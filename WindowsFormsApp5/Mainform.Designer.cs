namespace WindowsFormsApp5
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
            this.textBoxVAT = new System.Windows.Forms.TextBox();
            this.gbVAT = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.gbVAT.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxVAT
            // 
            this.textBoxVAT.Location = new System.Drawing.Point(6, 19);
            this.textBoxVAT.MaxLength = 11;
            this.textBoxVAT.Name = "textBoxVAT";
            this.textBoxVAT.Size = new System.Drawing.Size(196, 20);
            this.textBoxVAT.TabIndex = 2;
            this.textBoxVAT.TextChanged += new System.EventHandler(this.textBoxVAT_TextChanged);
            this.textBoxVAT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVAT_KeyPress);
            // 
            // gbVAT
            // 
            this.gbVAT.AutoSize = true;
            this.gbVAT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbVAT.Controls.Add(this.textBoxVAT);
            this.gbVAT.Location = new System.Drawing.Point(23, 12);
            this.gbVAT.Name = "gbVAT";
            this.gbVAT.Size = new System.Drawing.Size(208, 58);
            this.gbVAT.TabIndex = 3;
            this.gbVAT.TabStop = false;
            this.gbVAT.Text = "Enter VAT (11 digits):";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResult.Location = new System.Drawing.Point(237, 27);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(62, 24);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "Result";
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(346, 27);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(436, 77);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.gbVAT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VAT Verify";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.gbVAT.ResumeLayout(false);
            this.gbVAT.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxVAT;
        private System.Windows.Forms.GroupBox gbVAT;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnClear;
    }
}

