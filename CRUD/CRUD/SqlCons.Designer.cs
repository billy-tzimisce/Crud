namespace CRUD
{
    partial class frmSQL
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
            this.comandoSQLtexto = new System.Windows.Forms.RichTextBox();
            this.retornoTxt = new System.Windows.Forms.RichTextBox();
            this.bntExec = new System.Windows.Forms.Button();
            this.bntSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comandoSQLtexto
            // 
            this.comandoSQLtexto.Location = new System.Drawing.Point(6, 46);
            this.comandoSQLtexto.Name = "comandoSQLtexto";
            this.comandoSQLtexto.Size = new System.Drawing.Size(495, 188);
            this.comandoSQLtexto.TabIndex = 0;
            this.comandoSQLtexto.Text = "";
            // 
            // retornoTxt
            // 
            this.retornoTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.retornoTxt.Location = new System.Drawing.Point(6, 239);
            this.retornoTxt.Name = "retornoTxt";
            this.retornoTxt.Size = new System.Drawing.Size(495, 142);
            this.retornoTxt.TabIndex = 1;
            this.retornoTxt.Text = "";
            this.retornoTxt.WordWrap = false;
            // 
            // bntExec
            // 
            this.bntExec.Location = new System.Drawing.Point(6, 10);
            this.bntExec.Name = "bntExec";
            this.bntExec.Size = new System.Drawing.Size(75, 23);
            this.bntExec.TabIndex = 2;
            this.bntExec.Text = "Executar";
            this.bntExec.UseVisualStyleBackColor = true;
            this.bntExec.Click += new System.EventHandler(this.bntExec_Click);
            // 
            // bntSair
            // 
            this.bntSair.Location = new System.Drawing.Point(98, 10);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(75, 23);
            this.bntSair.TabIndex = 3;
            this.bntSair.Text = "Sair";
            this.bntSair.UseVisualStyleBackColor = true;
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
            // 
            // frmSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 384);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.bntExec);
            this.Controls.Add(this.retornoTxt);
            this.Controls.Add(this.comandoSQLtexto);
            this.Name = "frmSQL";
            this.Text = "SQL Console";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox comandoSQLtexto;
        private System.Windows.Forms.RichTextBox retornoTxt;
        private System.Windows.Forms.Button bntExec;
        private System.Windows.Forms.Button bntSair;
    }
}