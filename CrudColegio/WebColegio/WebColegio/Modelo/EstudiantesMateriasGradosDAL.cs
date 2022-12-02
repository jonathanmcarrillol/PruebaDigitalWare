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
    public class EstudiantesMateriasGradosDAL
    {
        string conexionsql = "Server=FRG01ADMTICSE01\\SQLEXPRESS;Initial Catalog=NotasColegio;User ID=Jonathan;Password=Avocato22.;Trusted_Connection=True;MultipleActiveResultSets=true";

        public Task<DataTable> Insert(EstudiantesMateriasGradosEntity estudiantesMateriasGradosEntity)
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
                        SqlCommand command = new SqlCommand("uspEstudiantesMateriasGrados ", connection)
                        {
                            CommandType = CommandType.StoredProcedure
                        };
                        command.Parameters.AddWithValue("@DataAction", estudiantesMateriasGradosEntity.DataAction);
                        command.Parameters.AddWithValue("@EstudiantesMateriasGradosId", estudiantesMateriasGradosEntity.EstudiantesMateriasGradosId);
                        command.Parameters.AddWithValue("@EstudianteId", estudiantesMateriasGradosEntity.EstudianteId);
                        command.Parameters.AddWithValue("@MateriasGradosId", estudiantesMateriasGradosEntity.MateriasGradosId);
                        command.Parameters.AddWithValue("@Notas", estudiantesMateriasGradosEntity.Notas);

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

        public Task<DataTable> Update(EstudiantesMateriasGradosEntity estudiantesMateriasGradosEntity)
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
                        SqlCommand command = new SqlCommand("uspEstudiantesMateriasGrados ", connection)
                        {
                            CommandType = CommandType.StoredProcedure
                        };
                        command.Parameters.AddWithValue("@DataAction", estudiantesMateriasGradosEntity.DataAction);
                        command.Parameters.AddWithValue("@EstudiantesMateriasGradosId", estudiantesMateriasGradosEntity.EstudiantesMateriasGradosId);
                        command.Parameters.AddWithValue("@EstudianteId", estudiantesMateriasGradosEntity.EstudianteId);
                        command.Parameters.AddWithValue("@MateriasGradosId", estudiantesMateriasGradosEntity.MateriasGradosId);
                        command.Parameters.AddWithValue("@Notas", estudiantesMateriasGradosEntity.Notas);
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

        public Task<DataTable> Delete(EstudiantesMateriasGradosEntity estudiantesMateriasGradosEntity)
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
                        SqlCommand command = new SqlCommand("uspEstudiantesMateriasGrados ", connection)
                        {
                            CommandType = CommandType.StoredProcedure
                        };
                        command.Parameters.AddWithValue("@DataAction", estudiantesMateriasGradosEntity.DataAction);
                        command.Parameters.AddWithValue("@EstudiantesMateriasGradosId", estudiantesMateriasGradosEntity.EstudiantesMateriasGradosId);

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

        public Task<DataTable> Select(EstudiantesMateriasGradosEntity estudiantesMateriasGradosEntity)
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
                        SqlCommand command = new SqlCommand("uspEstudiantesMateriasGrados", connection)
                        {
                            CommandType = CommandType.StoredProcedure
                        };

                        command.Parameters.AddWithValue("@DataAction", estudiantesMateriasGradosEntity.DataAction);
                        command.Parameters.AddWithValue("@EstudianteId", estudiantesMateriasGradosEntity.EstudianteId);


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
