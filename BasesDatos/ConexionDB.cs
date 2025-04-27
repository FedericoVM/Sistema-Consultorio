using Microsoft.Data.SqlClient;


namespace BasesDatos
{
    public class BasesDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        public SqlDataReader Lector { get; private set; }
      

        public BasesDatos()
        {
            conexion = new SqlConnection("server=.\\SQLEXPRESS;database = DB_Consultorio; integrated security = true;");
            comando = new SqlCommand();
            comando.Connection = conexion;
        }

        public void SetConsulta(string consulta)
        {
        
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
            comando.Parameters.Clear();
        }

        public void AgregarParametro(string nombreParametro, object valor)
        {
            if (!nombreParametro.StartsWith("@"))
            {
                nombreParametro = "@" + nombreParametro;
            }

            comando.Parameters.AddWithValue(nombreParametro, valor);
        }
        public void SolicitarDatos()
        {
            comando.Connection = conexion;

            try
            {
                comando.Connection.Open();
                Lector = comando.ExecuteReader();

            }
            catch (Exception ex)
            {

                throw new Exception("Error al solicitar datos de la Base de datos", ex);
            }
        }
        public void enviarSoloConsulta()
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
        public void cerrarConexion()
        {
            if (Lector != null)
            {
                Lector.Close();
            }

            conexion.Close();
        }

    }
}
