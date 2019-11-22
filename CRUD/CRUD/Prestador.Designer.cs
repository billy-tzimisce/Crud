namespace CRUD
{
    partial class Prestador
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
            this.RazaoSocial = new System.Windows.Forms.TextBox();
            this.lbRazao = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CNPJ = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CNAE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CodIBGE = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RazaoSocial
            // 
            this.RazaoSocial.Location = new System.Drawing.Point(157, 123);
            this.RazaoSocial.Name = "RazaoSocial";
            this.RazaoSocial.Size = new System.Drawing.Size(252, 20);
            this.RazaoSocial.TabIndex = 0;
            // 
            // lbRazao
            // 
            this.lbRazao.AutoSize = true;
            this.lbRazao.Location = new System.Drawing.Point(83, 130);
            this.lbRazao.Name = "lbRazao";
            this.lbRazao.Size = new System.Drawing.Size(68, 13);
            this.lbRazao.TabIndex = 1;
            this.lbRazao.Text = "Razão social";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CNPJ";
            // 
            // CNPJ
            // 
            this.CNPJ.Location = new System.Drawing.Point(157, 160);
            this.CNPJ.Name = "CNPJ";
            this.CNPJ.Size = new System.Drawing.Size(252, 20);
            this.CNPJ.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "IM";
            // 
            // IM
            // 
            this.IM.Location = new System.Drawing.Point(157, 195);
            this.IM.Name = "IM";
            this.IM.Size = new System.Drawing.Size(252, 20);
            this.IM.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "CNAE";
            // 
            // CNAE
            // 
            this.CNAE.Location = new System.Drawing.Point(157, 231);
            this.CNAE.Name = "CNAE";
            this.CNAE.Size = new System.Drawing.Size(252, 20);
            this.CNAE.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Código IBGE Municipio";
            // 
            // CodIBGE
            // 
            this.CodIBGE.Location = new System.Drawing.Point(205, 272);
            this.CodIBGE.Name = "CodIBGE";
            this.CodIBGE.Size = new System.Drawing.Size(200, 20);
            this.CodIBGE.TabIndex = 8;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(86, 59);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(209, 59);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 11;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(334, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Sair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Prestador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 384);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CodIBGE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CNAE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CNPJ);
            this.Controls.Add(this.lbRazao);
            this.Controls.Add(this.RazaoSocial);
            this.Location = new System.Drawing.Point(20, 20);
            this.Name = "Prestador";
            this.Text = "Cadastro de Prestador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RazaoSocial;
        private System.Windows.Forms.Label lbRazao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CNPJ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CNAE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CodIBGE;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button button2;
    }
}