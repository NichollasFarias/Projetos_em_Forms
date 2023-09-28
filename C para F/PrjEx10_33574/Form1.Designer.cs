namespace PrjEx10_33574
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVal1 = new System.Windows.Forms.TextBox();
            this.txtRes = new System.Windows.Forms.TextBox();
            this.btmCal = new System.Windows.Forms.Button();
            this.btmLimp = new System.Windows.Forms.Button();
            this.btmSai = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "°C → °F";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(118, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "°C";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(339, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "°F";
            // 
            // txtVal1
            // 
            this.txtVal1.Location = new System.Drawing.Point(12, 82);
            this.txtVal1.Name = "txtVal1";
            this.txtVal1.Size = new System.Drawing.Size(100, 32);
            this.txtVal1.TabIndex = 0;
            // 
            // txtRes
            // 
            this.txtRes.Enabled = false;
            this.txtRes.Location = new System.Drawing.Point(233, 82);
            this.txtRes.Name = "txtRes";
            this.txtRes.Size = new System.Drawing.Size(100, 32);
            this.txtRes.TabIndex = 2;
            this.txtRes.TabStop = false;
            // 
            // btmCal
            // 
            this.btmCal.Location = new System.Drawing.Point(12, 136);
            this.btmCal.Name = "btmCal";
            this.btmCal.Size = new System.Drawing.Size(360, 56);
            this.btmCal.TabIndex = 1;
            this.btmCal.Text = "Converter";
            this.btmCal.UseVisualStyleBackColor = true;
            this.btmCal.Click += new System.EventHandler(this.btmCal_Click);
            // 
            // btmLimp
            // 
            this.btmLimp.Location = new System.Drawing.Point(12, 198);
            this.btmLimp.Name = "btmLimp";
            this.btmLimp.Size = new System.Drawing.Size(360, 56);
            this.btmLimp.TabIndex = 2;
            this.btmLimp.Text = "Limpar";
            this.btmLimp.UseVisualStyleBackColor = true;
            this.btmLimp.Click += new System.EventHandler(this.btmLimp_Click);
            // 
            // btmSai
            // 
            this.btmSai.Location = new System.Drawing.Point(12, 260);
            this.btmSai.Name = "btmSai";
            this.btmSai.Size = new System.Drawing.Size(360, 56);
            this.btmSai.TabIndex = 3;
            this.btmSai.Text = "Sair";
            this.btmSai.UseVisualStyleBackColor = true;
            this.btmSai.Click += new System.EventHandler(this.btmSai_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(104, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nichollas F.L.S ©";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.btmSai);
            this.Controls.Add(this.btmLimp);
            this.Controls.Add(this.btmCal);
            this.Controls.Add(this.txtRes);
            this.Controls.Add(this.txtVal1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVal1;
        private System.Windows.Forms.TextBox txtRes;
        private System.Windows.Forms.Button btmCal;
        private System.Windows.Forms.Button btmLimp;
        private System.Windows.Forms.Button btmSai;
        private System.Windows.Forms.Label label4;
    }
}

