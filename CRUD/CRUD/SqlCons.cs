using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class frmSQL : Form
    {
        public frmSQL()
        {
            InitializeComponent();
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bntExec_Click(object sender, EventArgs e)
        {
            Inicio.Conect   Rodar = new Inicio.Conect();

            SqlCommand comando = new SqlCommand(comandoSQLtexto.Text);
            
            comando.Connection = Rodar.conectar();
            
            SqlDataReader reader = comando.ExecuteReader();

            
            int CountL = 1;
            int CountC = 0;
            while (reader.Read())
           {
               retornoTxt.Text = retornoTxt.Text + CountL.ToString() + " - ";

                while (CountC < reader.VisibleFieldCount)
               {
                   retornoTxt.Text = retornoTxt.Text + reader[CountC].ToString() ;
                   retornoTxt.Text = retornoTxt.Text + " | ";
                    CountC++;
               }
               retornoTxt.Text = retornoTxt.Text + "\n";
               CountC = 0;
               CountL++;
            }

            reader.Close();

            Rodar.Fechar();
        }
    }
}
