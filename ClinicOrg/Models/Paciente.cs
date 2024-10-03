namespace ClinicOrg.Models
{
    public class Paciente
    {
        public int Id { get; set; }

        public String? Nombre { get; set; }

        public String? Apellido { get; set; }

        public String? Sexo { get; set; }

        public String? Telefono { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public String? Email { get; set; }
    }
}
