using Microsoft.Data.SqlClient;


namespace BasesDatos
{
    public class BasesDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        public SqlDataReader Lector { get; private set; }
      

        public BasesDatos()
        {
            conexion = new SqlConnection("server=.\\SQLEXPRESS;database = DB_Consultorio; integrated security = true;");
            comando = new SqlCommand();
        }

        public void IngresarConsulta(string consulta)
        {
        
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        public void SolicitarDatos()
        {
            comando.Connection = conexion;

            try
            {
                comando.Connection.Open();
                Lector = comando.ExecuteReader();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void EnviarSoloConsulta()
        {
            comando.Connection = conexion;

            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void CerrarConexion()
        {
            if (lector != null)
            {
                lector.Close();
            }

            conexion.Close();
        }

    }
}
