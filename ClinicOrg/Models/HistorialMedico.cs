namespace ClinicOrg.Models
{
    public class HistorialMedico
    {
        public int id { get; set; }
        public int pacientId { get; set; }
        public DateTime fecha { get; set; }
        public String? descripcion { get; set; }
        public int TratamientoId { get; set; }
        public int MedicoId { get; set; }



    }
}
