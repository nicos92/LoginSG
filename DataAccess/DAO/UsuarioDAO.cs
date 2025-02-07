
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.Common;
using Common.Cache;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class UsuarioDAO
    {
        public async Task<bool> Login(string user, string pass)
        {


            try
            {


                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = await BDNpgsql.Instance.GetConnectionAsync();
                    cmd.CommandText = "select id, nombre, apellido, legajo, sector, puesto, usuario from Usuarios where usuario = '@user' and contra = '@pass'";
                    cmd.Parameters.AddWithValue("@user", user);
                    cmd.Parameters.AddWithValue("@pass", pass);

                    using (DbDataReader reader = await cmd.ExecuteReaderAsync())
                    {

                        if (reader.HasRows)
                        {

                            while (await reader.ReadAsync())
                            {

                                UserDaoCache.id = reader.GetInt64(0);
                                UserDaoCache.nombre = reader.GetString(1);
                                UserDaoCache.apelllido = reader.GetString(2);
                                UserDaoCache.legajo = reader.GetInt32(3);
                                UserDaoCache.sector = reader.GetString(4);
                                UserDaoCache.puesto = reader.GetString(5);
                                UserDaoCache.usuario = reader.GetString(6);
                            }
                            BDNpgsql.Instance.CloseConnection();
                            return true;

                        }
                        else
                        {
                            return false;
                        }

                    }
                }

            }
            catch (NpgsqlException e)
            {

                BDNpgsql.Instance.CloseConnection();
                System.Windows.Forms.MessageBox.Show(e.Message, "Error en base de datos SQL EXCEPTION");

            }
            return false;
        }
    }
}
