namespace ClinicOrg.Models
{
    public class Citas
    {
        public int Id { get; set; }

        public int PacienteId  { get; set; }
        public int MedicoId  { get; set; }
        public DateTime Fecha  { get; set; }
        public String? Estado  { get; set; }
        
        



    }
}
