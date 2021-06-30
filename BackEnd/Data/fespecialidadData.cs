using BackEnd.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Data
{
    public class fespecialidadData
    {
        /*
       public static bool RegistrarFespecialidad(fespecialidad oEspecialidad)
       {
           using (SqlConnection oConexion = new SqlConnection(Conexion.rutaConexion))
           {
               SqlCommand cmd = new SqlCommand("usp_registrar", oConexion);
               cmd.CommandType = System.Data.CommandType.StoredProcedure;
               cmd.Parameters.AddWithValue("@documentoidentidad", oEspecialidad.DocumentoIdentidad);
               cmd.Parameters.AddWithValue("@nombres", oEspecialidad.Nombres);


               try
               {
                   oConexion.Open();
                   cmd.ExecuteNonQuery();
                   return true;
               }
               catch (Exception ex)
               {
                   return false;
               }
           }
       }
       */
        /*
        public static bool Modificar(Usuario oUsuario)
        {
            using (SqlConnection oConexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("usp_modificar", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idusuario", oUsuario.IdUsuario);
                cmd.Parameters.AddWithValue("@documentoidentidad", oUsuario.DocumentoIdentidad);
                cmd.Parameters.AddWithValue("@nombres", oUsuario.Nombres);
                cmd.Parameters.AddWithValue("@telefono", oUsuario.Telefono);
                cmd.Parameters.AddWithValue("@correo", oUsuario.Correo);
                cmd.Parameters.AddWithValue("@ciudad", oUsuario.Ciudad);

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }
        */
        public static List<fespecialidad> ListarFespecialidad()
        {
            List<fespecialidad> oListaFespecialidad = new List<fespecialidad>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.dbConexion))
            {
                SqlCommand cmd = new SqlCommand("select * from fespecialidad", oConexion);
                cmd.CommandType = CommandType.Text;

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            oListaFespecialidad.Add(new fespecialidad()
                            {
                                id = dr["Nº_ESP"].ToString(),
                                nombre = dr["NOMBRE"].ToString(),

                            });
                        }

                    }



                    return oListaFespecialidad;
                }
                catch (Exception ex)
                {
                    return oListaFespecialidad;
                }
            }
        }
        /*
        public static Usuario Obtener(int idusuario)
        {
            Usuario oUsuario = new Usuario();
            using (SqlConnection oConexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("usp_obtener", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idusuario", idusuario);

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            oUsuario = new Usuario()
                            {
                                IdUsuario = Convert.ToInt32(dr["IdUsuario"]),
                                DocumentoIdentidad = dr["DocumentoIdentidad"].ToString(),
                                Nombres = dr["Nombres"].ToString(),
                                Telefono = dr["Telefono"].ToString(),
                                Correo = dr["Correo"].ToString(),
                                Ciudad = dr["Ciudad"].ToString(),
                                FechaRegistro = Convert.ToDateTime(dr["FechaRegistro"].ToString())
                            };
                        }

                    }



                    return oUsuario;
                }
                catch (Exception ex)
                {
                    return oUsuario;
                }
            }
        }
        */
        /*
        public static bool Eliminar(int id)
        {
            using (SqlConnection oConexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("usp_eliminar", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idusuario", id);

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }
        */

    }
}
