namespace PrjEx02_33574
{
    partial class frmEx02_33574
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtVal2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btmCal = new System.Windows.Forms.Button();
            this.btmLimp = new System.Windows.Forms.Button();
            this.btmSai = new System.Windows.Forms.Button();
            this.txtRes = new System.Windows.Forms.TextBox();
            this.labRes = new System.Windows.Forms.Label();
            this.rdMulher = new System.Windows.Forms.RadioButton();
            this.rdHomem = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 111);
            this.label1.TabIndex = 0;
            this.label1.Text = "IMC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sexo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Peso:";
            // 
            // txtVal1
            // 
            this.txtVal1.Location = new System.Drawing.Point(82, 234);
            this.txtVal1.Name = "txtVal1";
            this.txtVal1.Size = new System.Drawing.Size(100, 35);
            this.txtVal1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Altura:";
            // 
            // txtVal2
            // 
            this.txtVal2.Location = new System.Drawing.Point(272, 231);
            this.txtVal2.Name = "txtVal2";
            this.txtVal2.Size = new System.Drawing.Size(100, 35);
            this.txtVal2.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 435);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "IMC:";
            // 
            // btmCal
            // 
            this.btmCal.Location = new System.Drawing.Point(12, 307);
            this.btmCal.Name = "btmCal";
            this.btmCal.Size = new System.Drawing.Size(154, 73);
            this.btmCal.TabIndex = 4;
            this.btmCal.Text = "Calcular";
            this.btmCal.UseVisualStyleBackColor = true;
            this.btmCal.Click += new System.EventHandler(this.btmCal_Click);
            // 
            // btmLimp
            // 
            this.btmLimp.Location = new System.Drawing.Point(218, 307);
            this.btmLimp.Name = "btmLimp";
            this.btmLimp.Size = new System.Drawing.Size(154, 73);
            this.btmLimp.TabIndex = 5;
            this.btmLimp.Text = "Limpar";
            this.btmLimp.UseVisualStyleBackColor = true;
            this.btmLimp.Click += new System.EventHandler(this.btmLimp_Click);
            // 
            // btmSai
            // 
            this.btmSai.Location = new System.Drawing.Point(117, 386);
            this.btmSai.Name = "btmSai";
            this.btmSai.Size = new System.Drawing.Size(141, 33);
            this.btmSai.TabIndex = 6;
            this.btmSai.Text = "Sair";
            this.btmSai.UseVisualStyleBackColor = true;
            this.btmSai.Click += new System.EventHandler(this.btmSai_Click);
            // 
            // txtRes
            // 
            this.txtRes.Enabled = false;
            this.txtRes.Location = new System.Drawing.Point(82, 432);
            this.txtRes.Name = "txtRes";
            this.txtRes.Size = new System.Drawing.Size(100, 35);
            this.txtRes.TabIndex = 5;
            this.txtRes.TabStop = false;
            // 
            // labRes
            // 
            this.labRes.Location = new System.Drawing.Point(12, 479);
            this.labRes.Name = "labRes";
            this.labRes.Size = new System.Drawing.Size(360, 73);
            this.labRes.TabIndex = 6;
            // 
            // rdMulher
            // 
            this.rdMulher.AutoSize = true;
            this.rdMulher.Location = new System.Drawing.Point(12, 162);
            this.rdMulher.Name = "rdMulher";
            this.rdMulher.Size = new System.Drawing.Size(111, 33);
            this.rdMulher.TabIndex = 0;
            this.rdMulher.Text = "Mulher";
            this.rdMulher.UseVisualStyleBackColor = true;
            // 
            // rdHomem
            // 
            this.rdHomem.AutoSize = true;
            this.rdHomem.Location = new System.Drawing.Point(254, 162);
            this.rdHomem.Name = "rdHomem";
            this.rdHomem.Size = new System.Drawing.Size(118, 33);
            this.rdHomem.TabIndex = 1;
            this.rdHomem.Text = "Homem";
            this.rdHomem.UseVisualStyleBackColor = true;
            // 
            // frmEx02_33574
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.rdHomem);
            this.Controls.Add(this.rdMulher);
            this.Controls.Add(this.labRes);
            this.Controls.Add(this.txtRes);
            this.Controls.Add(this.btmSai);
            this.Controls.Add(this.btmLimp);
            this.Controls.Add(this.btmCal);
            this.Controls.Add(this.txtVal2);
            this.Controls.Add(this.txtVal1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "frmEx02_33574";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVal1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVal2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btmCal;
        private System.Windows.Forms.Button btmLimp;
        private System.Windows.Forms.Button btmSai;
        private System.Windows.Forms.TextBox txtRes;
        private System.Windows.Forms.Label labRes;
        private System.Windows.Forms.RadioButton rdMulher;
        private System.Windows.Forms.RadioButton rdHomem;
    }
}

