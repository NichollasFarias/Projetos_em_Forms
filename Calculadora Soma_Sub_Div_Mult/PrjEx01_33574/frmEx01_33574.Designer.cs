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
            this.Nome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVal02 = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtVal01 = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.btnSoma = new System.Windows.Forms.Button();
            this.btnmultiplicação = new System.Windows.Forms.Button();
            this.btnSubtração = new System.Windows.Forms.Button();
            this.btndivisão = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.BackColor = System.Drawing.Color.Transparent;
            this.Nome.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.Location = new System.Drawing.Point(120, 9);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(249, 32);
            this.Nome.TabIndex = 0;
            this.Nome.Text = "Calculadora 10/10";
            this.Nome.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valor 01";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor 02";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(349, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Resultado";
            // 
            // txtVal02
            // 
            this.txtVal02.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVal02.Location = new System.Drawing.Point(116, 114);
            this.txtVal02.Name = "txtVal02";
            this.txtVal02.Size = new System.Drawing.Size(66, 26);
            this.txtVal02.TabIndex = 1;
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(353, 114);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(83, 26);
            this.txtResultado.TabIndex = 6;
            // 
            // txtVal01
            // 
            this.txtVal01.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVal01.Location = new System.Drawing.Point(16, 114);
            this.txtVal01.Name = "txtVal01";
            this.txtVal01.Size = new System.Drawing.Size(70, 26);
            this.txtVal01.TabIndex = 0;
            this.txtVal01.TextChanged += new System.EventHandler(this.txtVal01_TextChanged);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(12, 398);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(162, 51);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.Limpar_Click);
            // 
            // btnsair
            // 
            this.btnsair.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.Location = new System.Drawing.Point(310, 398);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(162, 51);
            this.btnsair.TabIndex = 7;
            this.btnsair.TabStop = false;
            this.btnsair.Text = "Sai&r";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.sair_Click);
            // 
            // btnSoma
            // 
            this.btnSoma.Font = new System.Drawing.Font("Arial Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoma.Location = new System.Drawing.Point(12, 166);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(200, 100);
            this.btnSoma.TabIndex = 2;
            this.btnSoma.Text = "&Soma";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.Soma_Click);
            // 
            // btnmultiplicação
            // 
            this.btnmultiplicação.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmultiplicação.Location = new System.Drawing.Point(12, 272);
            this.btnmultiplicação.Name = "btnmultiplicação";
            this.btnmultiplicação.Size = new System.Drawing.Size(200, 100);
            this.btnmultiplicação.TabIndex = 4;
            this.btnmultiplicação.Text = "&Multiplicação";
            this.btnmultiplicação.UseVisualStyleBackColor = true;
            this.btnmultiplicação.Click += new System.EventHandler(this.btnmultiplicação_Click);
            // 
            // btnSubtração
            // 
            this.btnSubtração.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtração.Location = new System.Drawing.Point(272, 166);
            this.btnSubtração.Name = "btnSubtração";
            this.btnSubtração.Size = new System.Drawing.Size(200, 100);
            this.btnSubtração.TabIndex = 3;
            this.btnSubtração.Text = "S&ubtração";
            this.btnSubtração.UseVisualStyleBackColor = true;
            this.btnSubtração.Click += new System.EventHandler(this.btnSubtração_Click);
            // 
            // btndivisão
            // 
            this.btndivisão.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndivisão.Location = new System.Drawing.Point(272, 272);
            this.btndivisão.Name = "btndivisão";
            this.btndivisão.Size = new System.Drawing.Size(200, 100);
            this.btndivisão.TabIndex = 5;
            this.btndivisão.Text = "&Divisão";
            this.btndivisão.UseVisualStyleBackColor = true;
            this.btndivisão.Click += new System.EventHandler(this.button6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(178, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "By: Nichollas F.L.S";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(182, 434);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Alt + ? = Atalho";
            // 
            // frmEx01_33574
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btndivisão);
            this.Controls.Add(this.btnSubtração);
            this.Controls.Add(this.btnmultiplicação);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtVal01);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtVal02);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nome);
            this.Name = "frmEx01_33574";
            this.Text = "Calculadora ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVal02;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtVal01;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Button btnmultiplicação;
        private System.Windows.Forms.Button btnSubtração;
        private System.Windows.Forms.Button btndivisão;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

