using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class EstudiantesDAL
    {
        string conexionsql = "Server=FRG01ADMTICSE01\\SQLEXPRESS;Initial Catalog=NotasColegio;User ID=Jonathan;Password=Avocato22.;Trusted_Connection=True;MultipleActiveResultSets=true";

        public Task<DataTable> Insert(EstudiantesEntity estudiantesEntity)
        {
            return Task.Run(() =>
            {
                try
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter();
                    DataTable dt = new DataTable();

                    using (SqlConnection connection = new SqlConnection(conexionsql))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand("uspEstudiantes ", connection)
                        {
                            CommandType = CommandType.StoredProcedure
                        };
                        command.Parameters.AddWithValue("@DataAction", estudiantesEntity.DataAction);
                        command.Parameters.AddWithValue("@EstudianteId", estudiantesEntity.EstudianteId);
                        command.Parameters.AddWithValue("@EstudianteNombre", estudiantesEntity.EstudianteNombre);

                        dataAdapter.SelectCommand = command;
                        dataAdapter.Fill(dt);
                    }

                    if (dt.Rows.Count > 0)
                    {
                        return dt;
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                return null;
            });
        }

        public Task<DataTable> Update(EstudiantesEntity estudiantesEntity)
        {
            return Task.Run(() =>
            {
                try
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter();
                    DataTable dt = new DataTable();

                    using (SqlConnection connection = new SqlConnection(conexionsql))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand("uspEstudiantes ", connection)
                        {
                            CommandType = CommandType.StoredProcedure
                        };
                        command.Parameters.AddWithValue("@DataAction", estudiantesEntity.DataAction);
                        command.Parameters.AddWithValue("@EstudianteId", estudiantesEntity.EstudianteId);
                        command.Parameters.AddWithValue("@EstudianteNombre", estudiantesEntity.EstudianteNombre);
                        dataAdapter.SelectCommand = command;
                        dataAdapter.Fill(dt);
                    }

                    if (dt.Rows.Count > 0)
                    {
                        return dt;
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                return null;
            });
        }

        public Task<DataTable> Delete(EstudiantesEntity estudiantesEntity)
        {
            return Task.Run(() =>
            {
                try
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter();
                    DataTable dt = new DataTable();

                    using (SqlConnection connection = new SqlConnection(conexionsql))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand("uspEstudiantes ", connection)
                        {
                            CommandType = CommandType.StoredProcedure
                        };
                        command.Parameters.AddWithValue("@DataAction", estudiantesEntity.DataAction);
                        command.Parameters.AddWithValue("@EstudianteId", estudiantesEntity.EstudianteId);

                        dataAdapter.SelectCommand = command;
                        dataAdapter.Fill(dt);
                    }

                    if (dt.Rows.Count > 0)
                    {
                        return dt;
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                return null;
            });
        }

        public Task<DataTable> Select(EstudiantesEntity estudiantesEntity)
        {
            return Task.Run(() =>
            {
                try
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter();
                    DataTable dt = new DataTable();

                    using (SqlConnection connection = new SqlConnection(conexionsql))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand("uspEstudiantes", connection)
                        {
                            CommandType = CommandType.StoredProcedure
                        };

                        command.Parameters.AddWithValue("@DataAction", estudiantesEntity.DataAction);

                        dataAdapter.SelectCommand = command;
                        dataAdapter.Fill(dt);
                    }

                    if (dt.Rows.Count > 0)
                    {
                        return dt;
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                return null;
            });


        }

    }
}
