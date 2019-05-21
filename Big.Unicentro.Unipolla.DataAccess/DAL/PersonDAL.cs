using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Big.Unicentro.Unipolla.DataAccess.Common;
using Big.Unicentro.Unipolla.DataAccess.Common.Diagnostics;
using Big.Unicentro.Unipolla.DataAccess.Model;

namespace Big.Unicentro.Unipolla.DataAccess.DAL
{
   public class PersonDAL
    {
        public static ClsResponse<UC_CUSTOMER> GetClient(string idCustomer)
        {
            ClsResponse<UC_CUSTOMER> obj = new ClsResponse<UC_CUSTOMER>();
            try
            {
                UC_CUSTOMER codes;
                using (dbUnicentroCRMEntities db = new dbUnicentroCRMEntities())
                {
                    codes = db.UC_CUSTOMER.FirstOrDefault(x => x.GUID == idCustomer);
                }
                if (codes != null)
                {
                    obj.Result = codes;
                    obj.StatusCode = "1";
                }
                else
                {
                    obj.Message = new ClsMessage() { Link = "", Message = "No se pudo obtener el Cliente", Title = "", Buttontext = "Aceptar" };
                    obj.Result = null;
                    obj.StatusCode = "0";
                }
            }
            catch (Exception ex)
            {
                ExceptionLogging.LogException(ex);

                obj.Message = new ClsMessage() { Link = "", Message = "Error", Title = "Error", Buttontext = "Aceptar" };
                obj.Result = null;
                obj.StatusCode = "0";
                obj.Title = "Error";
            }
            return obj;
        }

        public static ClsResponse<UC_CUSTOMER> GetClientByDocument(string document)
        {
            ClsResponse<UC_CUSTOMER> obj = new ClsResponse<UC_CUSTOMER>();
            try
            {
                UC_CUSTOMER codes;
                using (dbUnicentroCRMEntities db = new dbUnicentroCRMEntities())
                {
                    codes = db.UC_CUSTOMER.FirstOrDefault(x => x.IDENTIFICATION_NUMBER == document);
                }
                if (codes != null)
                {
                    obj.Result = codes;
                    obj.StatusCode = "1";
                }
                else
                {
                    obj.Message = new ClsMessage() { Link = "", Message = "No se pudo obtener el Cliente", Title = "", Buttontext = "Aceptar" };
                    obj.Result = null;
                    obj.StatusCode = "0";
                }
            }
            catch (Exception ex)
            {
                ExceptionLogging.LogException(ex);

                obj.Message = new ClsMessage() { Link = "", Message = "Error", Title = "Error", Buttontext = "Aceptar" };
                obj.Result = null;
                obj.StatusCode = "0";
                obj.Title = "Error";
            }
            return obj;
        }

        public static ClsResponse<UC_EMPLOYEE> GetEmployee(string idEmployee)
        {
            ClsResponse<UC_EMPLOYEE> obj = new ClsResponse<UC_EMPLOYEE>();
            try
            {
                UC_EMPLOYEE codes;
                using (dbUnicentroCRMEntities db = new dbUnicentroCRMEntities())
                {
                    codes = db.UC_EMPLOYEE.FirstOrDefault(x => x.GUID == idEmployee);
                }
                if (codes != null)
                {
                    obj.Result = codes;
                    obj.StatusCode = "1";
                }
                else
                {
                    obj.Message = new ClsMessage() { Link = "", Message = "No se pudo obtener el Empleado", Title = "", Buttontext = "Aceptar" };
                    obj.Result = null;
                    obj.StatusCode = "0";
                }
            }
            catch (Exception ex)
            {
                ExceptionLogging.LogException(ex);

                obj.Message = new ClsMessage() { Link = "", Message = "Error", Title = "Error", Buttontext = "Aceptar" };
                obj.Result = null;
                obj.StatusCode = "0";
                obj.Title = "Error";
            }
            return obj;
        }

        public static ClsResponse<UC_EMPLOYEE> GetEmployeeBydocument(string document)
        {
            ClsResponse<UC_EMPLOYEE> obj = new ClsResponse<UC_EMPLOYEE>();
            try
            {
                UC_EMPLOYEE codes;
                using (dbUnicentroCRMEntities db = new dbUnicentroCRMEntities())
                {
                    codes = db.UC_EMPLOYEE.FirstOrDefault(x => x.IDENTIFICATION_NUMBER == document);
                }
                if (codes != null)
                {
                    obj.Result = codes;
                    obj.StatusCode = "1";
                }
                else
                {
                    obj.Message = new ClsMessage() { Link = "", Message = "No se pudo obtener el Empleado", Title = "", Buttontext = "Aceptar" };
                    obj.Result = null;
                    obj.StatusCode = "0";
                }
            }
            catch (Exception ex)
            {
                ExceptionLogging.LogException(ex);

                obj.Message = new ClsMessage() { Link = "", Message = "Error", Title = "Error", Buttontext = "Aceptar" };
                obj.Result = null;
                obj.StatusCode = "0";
                obj.Title = "Error";
            }
            return obj;
        }
    }
}
