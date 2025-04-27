namespace Dominio
{
    public class Paciente
    {
        public int IdPaciente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Genero { get; set; }
        public string Domicilio { get; set; }
        public string Localidad { get; set; }
        public string CodigoPostal { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
    


        public Paciente(int idPaciente, string nombre, string apellido, string dni, DateTime fechaNacimiento, string genero, string domicilio, string localidad, string codigoPostal, string telefono, string email)
        {
            IdPaciente = idPaciente;
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            FechaNacimiento = fechaNacimiento;
            Genero = genero;
            Domicilio = domicilio;
            Localidad = localidad;
            CodigoPostal = codigoPostal;
            Telefono = telefono;
            Email = email;
        }





    }
}
