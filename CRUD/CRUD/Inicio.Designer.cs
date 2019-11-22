namespace CRUD
{
    partial class Inicio
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
            this.Prestador = new System.Windows.Forms.Button();
            this.Tomador = new System.Windows.Forms.Button();
            this.Serviço = new System.Windows.Forms.Button();
            this.XML = new System.Windows.Forms.Button();
            this.BtnNota = new System.Windows.Forms.Button();
            this.btnSql = new System.Windows.Forms.Button();
            this.Texto = new System.Windows.Forms.RichTextBox();
            this.gerar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Prestador
            // 
            this.Prestador.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prestador.Location = new System.Drawing.Point(30, 32);
            this.Prestador.Name = "Prestador";
            this.Prestador.Size = new System.Drawing.Size(125, 53);
            this.Prestador.TabIndex = 0;
            this.Prestador.Text = "Prestador";
            this.Prestador.UseVisualStyleBackColor = true;
            this.Prestador.Click += new System.EventHandler(this.Prestador_Click);
            // 
            // Tomador
            // 
            this.Tomador.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tomador.Location = new System.Drawing.Point(353, 32);
            this.Tomador.Name = "Tomador";
            this.Tomador.Size = new System.Drawing.Size(125, 53);
            this.Tomador.TabIndex = 1;
            this.Tomador.Text = "Tomador";
            this.Tomador.UseVisualStyleBackColor = true;
            // 
            // Serviço
            // 
            this.Serviço.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Serviço.Location = new System.Drawing.Point(30, 281);
            this.Serviço.Name = "Serviço";
            this.Serviço.Size = new System.Drawing.Size(125, 53);
            this.Serviço.TabIndex = 2;
            this.Serviço.Text = "Serviço";
            this.Serviço.UseVisualStyleBackColor = true;
            // 
            // XML
            // 
            this.XML.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XML.Location = new System.Drawing.Point(353, 281);
            this.XML.Name = "XML";
            this.XML.Size = new System.Drawing.Size(125, 53);
            this.XML.TabIndex = 3;
            this.XML.Text = "XML";
            this.XML.UseVisualStyleBackColor = true;
            // 
            // BtnNota
            // 
            this.BtnNota.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNota.Location = new System.Drawing.Point(192, 115);
            this.BtnNota.Name = "BtnNota";
            this.BtnNota.Size = new System.Drawing.Size(129, 115);
            this.BtnNota.TabIndex = 4;
            this.BtnNota.Text = "Nota Fiscal";
            this.BtnNota.UseVisualStyleBackColor = true;
            // 
            // btnSql
            // 
            this.btnSql.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSql.Location = new System.Drawing.Point(196, 281);
            this.btnSql.Margin = new System.Windows.Forms.Padding(0);
            this.btnSql.Name = "btnSql";
            this.btnSql.Size = new System.Drawing.Size(125, 53);
            this.btnSql.TabIndex = 5;
            this.btnSql.Text = "SQL console";
            this.btnSql.UseVisualStyleBackColor = true;
            this.btnSql.Click += new System.EventHandler(this.btnSql_Click);
            // 
            // Texto
            // 
            this.Texto.Location = new System.Drawing.Point(539, 3);
            this.Texto.Name = "Texto";
            this.Texto.Size = new System.Drawing.Size(467, 378);
            this.Texto.TabIndex = 6;
            this.Texto.Text = "";
            // 
            // gerar
            // 
            this.gerar.Location = new System.Drawing.Point(413, 141);
            this.gerar.Name = "gerar";
            this.gerar.Size = new System.Drawing.Size(104, 53);
            this.gerar.TabIndex = 7;
            this.gerar.Text = "Gerar";
            this.gerar.UseVisualStyleBackColor = true;
            this.gerar.Click += new System.EventHandler(this.gerar_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 384);
            this.Controls.Add(this.gerar);
            this.Controls.Add(this.Texto);
            this.Controls.Add(this.btnSql);
            this.Controls.Add(this.BtnNota);
            this.Controls.Add(this.XML);
            this.Controls.Add(this.Serviço);
            this.Controls.Add(this.Tomador);
            this.Controls.Add(this.Prestador);
            this.Location = new System.Drawing.Point(20, 20);
            this.Name = "Inicio";
            this.Text = "Nota Fiscal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Prestador;
        private System.Windows.Forms.Button Tomador;
        private System.Windows.Forms.Button Serviço;
        private System.Windows.Forms.Button XML;
        private System.Windows.Forms.Button BtnNota;
        private System.Windows.Forms.Button btnSql;
        private System.Windows.Forms.RichTextBox Texto;
        private System.Windows.Forms.Button gerar;
    }
}

