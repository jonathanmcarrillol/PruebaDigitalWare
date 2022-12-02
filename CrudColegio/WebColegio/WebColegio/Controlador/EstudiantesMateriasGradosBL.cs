using Entity;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
   public class EstudiantesMateriasGradosBL
    {
        private EstudiantesMateriasGradosDAL estudiantesMateriasGradosDAL = new EstudiantesMateriasGradosDAL();

        public async Task<bool> Insert(EstudiantesMateriasGradosEntity estudiantesMateriasGradosEntity)
        {
            try
            {
                DataTable dt = await estudiantesMateriasGradosDAL.Insert(estudiantesMateriasGradosEntity);
                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0]["TranCompleted"].ToString() == "OK")
                    {
                        return true;
                    }
                    else
                    {
                        string TranCompleted = dt.Rows[0]["TranCompleted"].ToString();
                        string ErrorNumber = dt.Rows[0]["ErrorNumber"].ToString();
                        string ErrorSeverity = dt.Rows[0]["ErrorSeverity"].ToString();
                        string ErrorState = dt.Rows[0]["ErrorState"].ToString();
                        string ErrorProcedurer = dt.Rows[0]["ErrorProcedure"].ToString();
                        string ErrorLine = dt.Rows[0]["ErrorLine"].ToString();
                        string ErrorMessage = dt.Rows[0]["ErrorMessage"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }

            return false;
        }

        public async Task<bool> Update(EstudiantesMateriasGradosEntity estudiantesMateriasGradosEntity)
        {
            try
            {
                DataTable dt = await estudiantesMateriasGradosDAL.Update(estudiantesMateriasGradosEntity);
                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0]["TranCompleted"].ToString() == "OK")
                    {
                        return true;
                    }
                    else
                    {
                        string TranCompleted = dt.Rows[0]["TranCompleted"].ToString();
                        string ErrorNumber = dt.Rows[0]["ErrorNumber"].ToString();
                        string ErrorSeverity = dt.Rows[0]["ErrorSeverity"].ToString();
                        string ErrorState = dt.Rows[0]["ErrorState"].ToString();
                        string ErrorProcedurer = dt.Rows[0]["ErrorProcedure"].ToString();
                        string ErrorLine = dt.Rows[0]["ErrorLine"].ToString();
                        string ErrorMessage = dt.Rows[0]["ErrorMessage"].ToString();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return false;
        }

        public async Task<bool> Delete(EstudiantesMateriasGradosEntity estudiantesMateriasGradosEntity)
        {
            try
            {
                DataTable dt = await estudiantesMateriasGradosDAL.Delete(estudiantesMateriasGradosEntity);
                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0]["TranCompleted"].ToString() == "OK")
                    {
                        return true;
                    }
                    else
                    {
                        string TranCompleted = dt.Rows[0]["TranCompleted"].ToString();
                        string ErrorNumber = dt.Rows[0]["ErrorNumber"].ToString();
                        string ErrorSeverity = dt.Rows[0]["ErrorSeverity"].ToString();
                        string ErrorState = dt.Rows[0]["ErrorState"].ToString();
                        string ErrorProcedurer = dt.Rows[0]["ErrorProcedure"].ToString();
                        string ErrorLine = dt.Rows[0]["ErrorLine"].ToString();
                        string ErrorMessage = dt.Rows[0]["ErrorMessage"].ToString();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return false;
        }

        public async Task<DataTable> Select(EstudiantesMateriasGradosEntity estudiantesMateriasGradosEntity)
        {
            try
            {
                DataTable dt = await estudiantesMateriasGradosDAL.Select(estudiantesMateriasGradosEntity);
                if (dt == null)
                {
                    return dt;
                }

                else if (dt.Rows.Count > 0)
                {
                    return dt;
                }
                else
                {
                    string TranCompleted = dt.Rows[0]["TranCompleted"].ToString();
                    string ErrorNumber = dt.Rows[0]["ErrorNumber"].ToString();
                    string ErrorSeverity = dt.Rows[0]["ErrorSeverity"].ToString();
                    string ErrorState = dt.Rows[0]["ErrorState"].ToString();
                    string ErrorProcedurer = dt.Rows[0]["ErrorProcedure"].ToString();
                    string ErrorLine = dt.Rows[0]["ErrorLine"].ToString();
                    string ErrorMessage = dt.Rows[0]["ErrorMessage"].ToString();
                }
            }
            catch (Exception)
            {
                throw;
            }

            return null;

        }

    }
}
