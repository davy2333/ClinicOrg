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

        public bool Guardar(Paciente opaciente)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("GuardarPaciente", conexion);
                    cmd.Parameters.AddWithValue("Nombre", opaciente.Nombre);
                    cmd.Parameters.AddWithValue("Apellidos", opaciente.Apellido);
                    cmd.Parameters.AddWithValue("Sexo", opaciente.Sexo);
                    cmd.Parameters.AddWithValue("Telefono", opaciente.Telefono);
                    cmd.Parameters.AddWithValue("FechaNacimiento", opaciente.FechaNacimiento);
                    cmd.Parameters.AddWithValue("Email", opaciente.Email);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }
                rpta = true;
            }
            catch (Exception e)
            {
                String error = e.Message; 
                rpta=false;
            }

            return rpta;
        }

        public bool Editar(Paciente opaciente)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("EditarPaciente", conexion);
                    cmd.Parameters.AddWithValue("Personid", opaciente.Id); 
                    cmd.Parameters.AddWithValue("Nombre", opaciente.Nombre); 
                    cmd.Parameters.AddWithValue("Apellidos", opaciente.Apellido);
                    cmd.Parameters.AddWithValue("Sexo", opaciente.Sexo);
                    cmd.Parameters.AddWithValue("Telefono", opaciente.Telefono);
                    cmd.Parameters.AddWithValue("FechaNacimiento", opaciente.FechaNacimiento);
                    cmd.Parameters.AddWithValue("Email", opaciente.Email);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }
                rpta = true;
            }
            catch (Exception e)
            {
                String error = e.Message;
                rpta = false;
            }


            return rpta;
        }
        public bool Eliminar(int Personid)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("EliminarPaciente", conexion);
                    cmd.Parameters.AddWithValue("Personid", Personid);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }
                rpta = true;
            }
            catch (Exception e)
            {
                String error = e.Message;
                rpta = false;
            }


            return rpta;
        }
    }
}
