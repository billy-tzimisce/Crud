using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class Prestador : Form
    {
        public Prestador()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Inicio.Conect Rodar = new Inicio.Conect();

                string strSql = @"insert Prestador ( RazaoSocial, CNPJ , IM  , CnaeId  , Municipio)
                values ( " + "'" + RazaoSocial.Text + "'"
                                + "," + CNPJ.Text
                                + "," + IM.Text
                                + "," + CNAE.Text
                                + "," + CodIBGE.Text + ")";

                SqlCommand comando = new SqlCommand(strSql);

                comando.Connection = Rodar.conectar();

                comando.ExecuteNonQuery();

                if (comando.NotificationAutoEnlist)
                {
                    MessageBox.Show("Cadastro incluído com sucesso");
                }

                Rodar.Fechar();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Os campos não podem estar em branco ou com dados inválidos \n" + exception.Message);

            }
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Inicio.Conect Rodar = new Inicio.Conect();

                /* SELECT   select * from Prestador where 
                                                            RazaoSocial =  'SÃO PAULO' 
                                                            OR CNPJ = '12.945.116/0001-82' 
                                                            OR IM = '8'
                                                            OR CnaeId = '77777' 
                                                            OR Municipio = '12334'   */

                string strSql = @"select  * from Prestador were  
                                        RazaoSocial =" + RazaoSocial.Text
                                        + "OR CNPJ =" + CNPJ.Text
                                        + " OR IM =" + IM.Text 
                                        + "OR CnaeId =" + CNAE.Text
                                        + "OR Municipio =" + CodIBGE.Text ;

                SqlCommand comando = new SqlCommand(strSql);

                comando.Connection = Rodar.conectar();

                SqlDataReader reader = comando.ExecuteReader();

                Rodar.Fechar();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Os campos não podem estar em branco ou com dados inválidos \n" + exception.Message);
            }
        }
    }
}
