using BackEnd.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Data
{
    public class turnosData
    {
        public static List<fturnos> ListarFturnos()
        {
            List<fturnos> oListaFturnos = new List<fturnos>();

            using (SqlConnection oConexion = new SqlConnection(Conexion.dbConexion))
            {
                SqlCommand cmd = new SqlCommand("select * from view_turnos", oConexion);
                cmd.CommandType = CommandType.Text;

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            oListaFturnos.Add(new fturnos()
                            {
                                cmp = dr["Cmp"].ToString(),
                                nombre = dr["NOMB"].ToString(),
                                serv = dr["NOMBRE"].ToString(),
                                codcon = dr["codcon"].ToString(),
                                turcod = dr["Turcod"].ToString(),
                                turini = dr["turuni"].ToString(),
                                turfin = dr["turfin"].ToString(),
                                turtime = dr["turtime"].ToString(),
                                lun = dr["Lun"].ToString(),
                                mar = dr["Mar"].ToString(),
                                mie = dr["Mie"].ToString(),
                                jue = dr["Jue"].ToString(),
                                vier = dr["Vier"].ToString(),
                                sab = dr["Sab"].ToString(),
                                dom = dr["Dom"].ToString(),
                                obs = dr["obs"].ToString(),


                            });
                        }

                    }



                    return oListaFturnos;
                }
                catch (Exception ex)
                {
                    return oListaFturnos;
                }
            }
        }
    }
}
