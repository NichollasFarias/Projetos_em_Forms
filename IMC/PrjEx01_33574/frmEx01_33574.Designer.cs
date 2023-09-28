namespace PrjEx01_33574
{
    partial class frmEx01_33574
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
            this.txtVal2 = new System.Windows.Forms.TextBox();
            this.btmCal = new System.Windows.Forms.Button();
            this.btmLimp = new System.Windows.Forms.Button();
            this.btmSai = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labRes = new System.Windows.Forms.Label();
            this.txtR = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 111);
            this.label1.TabIndex = 0;
            this.label1.Text = " I";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(409, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Peso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(409, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Altura";
            // 
            // txtVal1
            // 
            this.txtVal1.Location = new System.Drawing.Point(413, 83);
            this.txtVal1.Name = "txtVal1";
            this.txtVal1.Size = new System.Drawing.Size(100, 32);
            this.txtVal1.TabIndex = 1;
            // 
            // txtVal2
            // 
            this.txtVal2.Location = new System.Drawing.Point(413, 177);
            this.txtVal2.Name = "txtVal2";
            this.txtVal2.Size = new System.Drawing.Size(100, 32);
            this.txtVal2.TabIndex = 2;
            // 
            // btmCal
            // 
            this.btmCal.Location = new System.Drawing.Point(133, 52);
            this.btmCal.Name = "btmCal";
            this.btmCal.Size = new System.Drawing.Size(250, 41);
            this.btmCal.TabIndex = 3;
            this.btmCal.Text = "Calcular";
            this.btmCal.UseVisualStyleBackColor = true;
            this.btmCal.Click += new System.EventHandler(this.button1_Click);
            // 
            // btmLimp
            // 
            this.btmLimp.Location = new System.Drawing.Point(133, 115);
            this.btmLimp.Name = "btmLimp";
            this.btmLimp.Size = new System.Drawing.Size(250, 41);
            this.btmLimp.TabIndex = 4;
            this.btmLimp.Text = "Limpar";
            this.btmLimp.UseVisualStyleBackColor = true;
            this.btmLimp.Click += new System.EventHandler(this.button2_Click);
            // 
            // btmSai
            // 
            this.btmSai.Location = new System.Drawing.Point(133, 177);
            this.btmSai.Name = "btmSai";
            this.btmSai.Size = new System.Drawing.Size(250, 41);
            this.btmSai.TabIndex = 5;
            this.btmSai.Text = "Sair";
            this.btmSai.UseVisualStyleBackColor = true;
            this.btmSai.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 111);
            this.label4.TabIndex = 0;
            this.label4.Text = "M";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 111);
            this.label5.TabIndex = 0;
            this.label5.Text = "C";
            // 
            // labRes
            // 
            this.labRes.Location = new System.Drawing.Point(133, 229);
            this.labRes.Name = "labRes";
            this.labRes.Size = new System.Drawing.Size(336, 82);
            this.labRes.TabIndex = 4;
            // 
            // txtR
            // 
            this.txtR.Enabled = false;
            this.txtR.Location = new System.Drawing.Point(510, 241);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(100, 32);
            this.txtR.TabIndex = 7;
            this.txtR.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(475, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Valor do IMC";
            // 
            // frmEx01_33574
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(622, 335);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labRes);
            this.Controls.Add(this.btmSai);
            this.Controls.Add(this.btmLimp);
            this.Controls.Add(this.btmCal);
            this.Controls.Add(this.txtVal2);
            this.Controls.Add(this.txtVal1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "frmEx01_33574";
            this.Text = "IMC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVal1;
        private System.Windows.Forms.TextBox txtVal2;
        private System.Windows.Forms.Button btmCal;
        private System.Windows.Forms.Button btmLimp;
        private System.Windows.Forms.Button btmSai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labRes;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.Label label6;
    }
}

