using System.Data.SqlClient;


namespace CRUD
{
    public class Conectar
    {
        public class Conect
        {
            SqlConnection conexao = new SqlConnection(@"Data Source = INVENT018; Initial Catalog = SBO_TaxOne; User Id = sa; Password=sap@123");
            public SqlConnection conectar()
            {
                conexao.Open();
                return conexao;
            }
            public void Fechar()
            {
                conexao.Close();
            }
        }
    }
}
