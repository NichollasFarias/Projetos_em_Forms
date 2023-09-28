namespace PrjEx02_33574
{
    partial class frmex02_33574
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
            this.btmLimp = new System.Windows.Forms.Button();
            this.btmCal = new System.Windows.Forms.Button();
            this.btmSai = new System.Windows.Forms.Button();
            this.txtAres = new System.Windows.Forms.TextBox();
            this.txtRes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(134, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quadrado TOP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(188, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Aresta";
            // 
            // btmLimp
            // 
            this.btmLimp.Location = new System.Drawing.Point(12, 189);
            this.btmLimp.Name = "btmLimp";
            this.btmLimp.Size = new System.Drawing.Size(126, 71);
            this.btmLimp.TabIndex = 2;
            this.btmLimp.Text = "Limpar";
            this.btmLimp.UseVisualStyleBackColor = true;
            this.btmLimp.Click += new System.EventHandler(this.btmLimp_Click);
            // 
            // btmCal
            // 
            this.btmCal.Location = new System.Drawing.Point(175, 189);
            this.btmCal.Name = "btmCal";
            this.btmCal.Size = new System.Drawing.Size(132, 71);
            this.btmCal.TabIndex = 1;
            this.btmCal.Text = "Calcular";
            this.btmCal.UseVisualStyleBackColor = true;
            this.btmCal.Click += new System.EventHandler(this.btmCal_Click);
            // 
            // btmSai
            // 
            this.btmSai.Location = new System.Drawing.Point(346, 189);
            this.btmSai.Name = "btmSai";
            this.btmSai.Size = new System.Drawing.Size(126, 71);
            this.btmSai.TabIndex = 3;
            this.btmSai.Text = "Sair";
            this.btmSai.UseVisualStyleBackColor = true;
            this.btmSai.Click += new System.EventHandler(this.btmSai_Click);
            // 
            // txtAres
            // 
            this.txtAres.Location = new System.Drawing.Point(129, 117);
            this.txtAres.Name = "txtAres";
            this.txtAres.Size = new System.Drawing.Size(215, 39);
            this.txtAres.TabIndex = 0;
            // 
            // txtRes
            // 
            this.txtRes.Enabled = false;
            this.txtRes.Location = new System.Drawing.Point(129, 335);
            this.txtRes.Name = "txtRes";
            this.txtRes.Size = new System.Drawing.Size(215, 39);
            this.txtRes.TabIndex = 7;
            this.txtRes.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(170, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Resposta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(123, 420);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nichollas F.L.S ©";
            // 
            // frmex02_33574
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAres);
            this.Controls.Add(this.btmSai);
            this.Controls.Add(this.btmCal);
            this.Controls.Add(this.btmLimp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "frmex02_33574";
            this.Text = "Quadrado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btmLimp;
        private System.Windows.Forms.Button btmCal;
        private System.Windows.Forms.Button btmSai;
        private System.Windows.Forms.TextBox txtAres;
        private System.Windows.Forms.TextBox txtRes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

