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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbase = new System.Windows.Forms.TextBox();
            this.txtaltura = new System.Windows.Forms.TextBox();
            this.txtres = new System.Windows.Forms.TextBox();
            this.btmCalc = new System.Windows.Forms.Button();
            this.btmLimp = new System.Windows.Forms.Button();
            this.btmSai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculadora de Área";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Base";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Altura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(170, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "By: Nichollas F.L.S ©";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(373, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Resultado";
            // 
            // txtbase
            // 
            this.txtbase.Location = new System.Drawing.Point(13, 111);
            this.txtbase.Name = "txtbase";
            this.txtbase.Size = new System.Drawing.Size(75, 29);
            this.txtbase.TabIndex = 5;
            // 
            // txtaltura
            // 
            this.txtaltura.Location = new System.Drawing.Point(12, 183);
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.Size = new System.Drawing.Size(75, 29);
            this.txtaltura.TabIndex = 6;
            // 
            // txtres
            // 
            this.txtres.Enabled = false;
            this.txtres.Location = new System.Drawing.Point(375, 136);
            this.txtres.Name = "txtres";
            this.txtres.Size = new System.Drawing.Size(92, 29);
            this.txtres.TabIndex = 7;
            // 
            // btmCalc
            // 
            this.btmCalc.Location = new System.Drawing.Point(149, 91);
            this.btmCalc.Name = "btmCalc";
            this.btmCalc.Size = new System.Drawing.Size(182, 35);
            this.btmCalc.TabIndex = 8;
            this.btmCalc.Text = "Calcular";
            this.btmCalc.UseVisualStyleBackColor = true;
            this.btmCalc.Click += new System.EventHandler(this.btmCalc_Click);
            // 
            // btmLimp
            // 
            this.btmLimp.Location = new System.Drawing.Point(149, 136);
            this.btmLimp.Name = "btmLimp";
            this.btmLimp.Size = new System.Drawing.Size(182, 35);
            this.btmLimp.TabIndex = 9;
            this.btmLimp.Text = "Limpar";
            this.btmLimp.UseVisualStyleBackColor = true;
            this.btmLimp.Click += new System.EventHandler(this.btmLimp_Click);
            // 
            // btmSai
            // 
            this.btmSai.Location = new System.Drawing.Point(149, 183);
            this.btmSai.Name = "btmSai";
            this.btmSai.Size = new System.Drawing.Size(182, 35);
            this.btmSai.TabIndex = 10;
            this.btmSai.Text = "Sair";
            this.btmSai.UseVisualStyleBackColor = true;
            this.btmSai.Click += new System.EventHandler(this.btmSai_Click);
            // 
            // frmEx01_33574
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(490, 267);
            this.Controls.Add(this.btmSai);
            this.Controls.Add(this.btmLimp);
            this.Controls.Add(this.btmCalc);
            this.Controls.Add(this.txtres);
            this.Controls.Add(this.txtaltura);
            this.Controls.Add(this.txtbase);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmEx01_33574";
            this.Text = "Calculadora de Área";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbase;
        private System.Windows.Forms.TextBox txtaltura;
        private System.Windows.Forms.TextBox txtres;
        private System.Windows.Forms.Button btmCalc;
        private System.Windows.Forms.Button btmLimp;
        private System.Windows.Forms.Button btmSai;
    }
}

