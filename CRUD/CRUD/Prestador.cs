using System;
using System.Data.SqlClient;
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
                Conectar.Conect Rodar = new Conectar.Conect();

                string strSql = @"insert Prestador ( RazaoSocial, CNPJ , IM  , CnaeId  , Municipio)
                values ( " + "'" + RazaoSocial.Text + "'"
                                + "," + "'" + CNPJ.Text + "'"
                                + "," + "'" + IM.Text + "'"
                                + "," + "'" + CNAE.Text + "'"
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
                Conectar.Conect Rodar = new Conectar.Conect();

                string strSql = @"select  * from Prestador where RazaoSocial like '%" + RazaoSocial.Text + "%\'"
                                        + " OR CNPJ like '%" + CNPJ.Text + "%\'"
                                        + "  OR IM like '%" + IM.Text + "%\'"
                                        + " OR CnaeId like '%" + CNAE.Text + "%\'"
                                        + "OR Municipio like '%" + CodIBGE.Text + "%\'";

                SqlCommand comando = new SqlCommand(strSql);

                comando.Connection = Rodar.conectar();

                SqlDataReader reader = comando.ExecuteReader();

                reader.Read();
                RazaoSocial.Text = reader[0].ToString();
                CNPJ.Text = reader[1].ToString();
                IM.Text = reader[2].ToString();
                CNAE.Text = reader[3].ToString();
                CodIBGE.Text = reader[4].ToString();
                reader.Close();
                Rodar.Fechar();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Nenhum Prestador encontrado \n" + exception.Message);
            }
        }
    }
}
