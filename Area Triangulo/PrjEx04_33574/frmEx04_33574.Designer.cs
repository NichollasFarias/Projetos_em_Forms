namespace PrjEx04_33574
{
    partial class frmEx04_33574
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btmLimp = new System.Windows.Forms.Button();
            this.btmCal = new System.Windows.Forms.Button();
            this.btmSai = new System.Windows.Forms.Button();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.txtAll = new System.Windows.Forms.TextBox();
            this.txtRes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Triangulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nichollas F.L.S ©";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Base";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(490, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Altura";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Resultado";
            // 
            // btmLimp
            // 
            this.btmLimp.Location = new System.Drawing.Point(17, 262);
            this.btmLimp.Name = "btmLimp";
            this.btmLimp.Size = new System.Drawing.Size(150, 45);
            this.btmLimp.TabIndex = 3;
            this.btmLimp.Text = "Limpar";
            this.btmLimp.UseVisualStyleBackColor = true;
            this.btmLimp.Click += new System.EventHandler(this.btmLimp_Click);
            // 
            // btmCal
            // 
            this.btmCal.Location = new System.Drawing.Point(218, 262);
            this.btmCal.Name = "btmCal";
            this.btmCal.Size = new System.Drawing.Size(150, 45);
            this.btmCal.TabIndex = 2;
            this.btmCal.Text = "Calcular";
            this.btmCal.UseVisualStyleBackColor = true;
            this.btmCal.Click += new System.EventHandler(this.btmCal_Click);
            // 
            // btmSai
            // 
            this.btmSai.Location = new System.Drawing.Point(422, 262);
            this.btmSai.Name = "btmSai";
            this.btmSai.Size = new System.Drawing.Size(150, 45);
            this.btmSai.TabIndex = 4;
            this.btmSai.Text = "Sair";
            this.btmSai.UseVisualStyleBackColor = true;
            this.btmSai.Click += new System.EventHandler(this.btmSai_Click);
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(12, 153);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(100, 35);
            this.txtBase.TabIndex = 0;
            // 
            // txtAll
            // 
            this.txtAll.Location = new System.Drawing.Point(472, 153);
            this.txtAll.Name = "txtAll";
            this.txtAll.Size = new System.Drawing.Size(100, 35);
            this.txtAll.TabIndex = 1;
            // 
            // txtRes
            // 
            this.txtRes.Enabled = false;
            this.txtRes.Location = new System.Drawing.Point(227, 153);
            this.txtRes.Name = "txtRes";
            this.txtRes.Size = new System.Drawing.Size(129, 35);
            this.txtRes.TabIndex = 8;
            this.txtRes.TabStop = false;
            // 
            // frmEx04_33574
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.txtRes);
            this.Controls.Add(this.txtAll);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.btmSai);
            this.Controls.Add(this.btmCal);
            this.Controls.Add(this.btmLimp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "frmEx04_33574";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btmLimp;
        private System.Windows.Forms.Button btmCal;
        private System.Windows.Forms.Button btmSai;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.TextBox txtAll;
        private System.Windows.Forms.TextBox txtRes;
    }
}

