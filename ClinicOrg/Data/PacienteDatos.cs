using ClinicOrg.Models;
using System.Data.SqlClient;
using System.Data;
using ClinicOrg.Models.Datos;
using Microsoft.AspNetCore.Identity;
namespace ClinicOrg.Data


{
    public class PacienteDatos
    {
        public List<Paciente> Listar()
        {
            var oLista = new List<Paciente>();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("listar_pacientes", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oLista.Add(new Paciente()
                        {
                            Id = Convert.ToInt32(dr["ID"]),
                            Nombre = dr["Nombre"].ToString(),
                            Apellido = dr["Apellido"].ToString(),
                            Sexo = dr["Sexo"].ToString(),
                            Telefono = dr["Telefono"].ToString(),
                            FechaNacimiento = Convert.ToDateTime(dr["fecha de nacimiento"]),
                            Email = dr["Email"].ToString(),
                        });
                    }
                }
            }
            return oLista;
        }
        public Paciente Obterner(int Personid)
        {
            var oPaciente = new Paciente();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("Obtener_pacientes", conexion);
                cmd.Parameters.AddWithValue("Personid", Personid);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {

                        oPaciente.Id = Convert.ToInt32(dr["ID"]);
                        oPaciente.Nombre = dr["Nombre"].ToString();
                        oPaciente.Apellido = dr["Apellido"].ToString();
                        oPaciente.Sexo = dr["Sexo"].ToString();
                        oPaciente.Telefono = dr["Telefono"].ToString();
                        oPaciente.FechaNacimiento = Convert.ToDateTime(dr["fecha de nacimiento"]);
                        oPaciente.Email = dr["Email"].ToString();
                        
                    }
                }
            }
            return oPaciente;
        }

    }
}
