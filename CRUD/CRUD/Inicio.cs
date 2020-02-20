using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using static CRUD.Conectar;

namespace CRUD
{
    public partial class Inicio : Form
    {

   
  /*      public class Conect
        {
            SqlConnection conexao = new SqlConnection(@"Data Source = INVENT018; Initial Catalog = SBO_TaxOne; User Id = sa; Password=sap@123");
            public SqlConnection conectar()
            {
                conexao.Open();
                return conexao;
            }
            public void  Fechar()
            {
                conexao.Close();
            }
        }           */

     
        public Inicio()
        {
            InitializeComponent();

        }

        private void Prestador_Click(object sender, EventArgs e)
        {   
            //chamando outro form
            Prestador cadPrestador = new Prestador();
            cadPrestador.ShowDialog();
            cadPrestador.SetDesktopLocation(20,20);
        }

        private void btnSql_Click(object sender, EventArgs e)
        {
            //chamando outro form
            frmSQL SqlConsole = new  frmSQL();
            SqlConsole.ShowDialog();
            SqlConsole.SetDesktopLocation(20, 20);
        }

        private void gerar_Click(object sender, EventArgs e)
        {
            String[ ] vet = Texto.Text.Split('\t');
            int  Count = 0;
            while (Count < vet.Length)
            {
                MessageBox.Show(vet[Count]);
                Count++;
            }
            MessageBox.Show(vet.Length.ToString());
        }
    }
}
