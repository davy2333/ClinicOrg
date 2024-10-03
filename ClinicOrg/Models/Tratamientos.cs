namespace ClinicOrg.Models
{
    public class Tratamientos
    {
        public int Id { get; set; }
        public String? Nombre { get; set; }
        public String? Descripcion { get; set; }
        public Decimal Costo{ get; set; }
        public int PacienteId { get; set; }



    }
}
