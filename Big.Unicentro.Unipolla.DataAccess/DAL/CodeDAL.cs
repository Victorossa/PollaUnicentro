using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Big.Unicentro.Unipolla.DataAccess.Common;
using Big.Unicentro.Unipolla.DataAccess.Common.Diagnostics;
using Big.Unicentro.Unipolla.DataAccess.Model;

namespace Big.Unicentro.Unipolla.DataAccess.DAL
{
    public class CodeDAL
    {
        public static ClsResponse<UNIPOLLA_CODES> GetCode(string code)
        {
            ClsResponse<UNIPOLLA_CODES> obj = new ClsResponse<UNIPOLLA_CODES>();
            try
            {
                UNIPOLLA_CODES codes;
                using (dbUnicentroCRMEntities db = new dbUnicentroCRMEntities())
                {
                    codes = db.UNIPOLLA_CODES.FirstOrDefault(x => x.DESCRIPTION == code && x.ACTIVE);
                }
                if (codes != null)
                {
                    obj.Result = codes;
                    obj.StatusCode = "1";
                }
                else
                {
                    obj.Message = new ClsMessage() { Link = "", Message = "No se pudo obtener el codigo", Title = "", Buttontext = "Aceptar" };
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

        public static ClsResponse<UNIPOLLA_CODES> GetCodeById(decimal idCode)
        {
            ClsResponse<UNIPOLLA_CODES> obj = new ClsResponse<UNIPOLLA_CODES>();
            try
            {
                UNIPOLLA_CODES codes;
                using (dbUnicentroCRMEntities db = new dbUnicentroCRMEntities())
                {
                    codes = db.UNIPOLLA_CODES.FirstOrDefault(x => x.ID == idCode);
                }
                if (codes != null)
                {
                    obj.Result = codes;
                    obj.StatusCode = "1";
                }
                else
                {
                    obj.Message = new ClsMessage() { Link = "", Message = "No se pudo obtener el codigo", Title = "", Buttontext = "Aceptar" };
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

        public static ClsResponse<UNIPOLLA_CODES_WINNER> GetCodeWinner(decimal idCode)
        {
            ClsResponse<UNIPOLLA_CODES_WINNER> obj = new ClsResponse<UNIPOLLA_CODES_WINNER>();
            try
            {
                UNIPOLLA_CODES_WINNER codes;
                using (dbUnicentroCRMEntities db = new dbUnicentroCRMEntities())
                {
                    codes = db.UNIPOLLA_CODES_WINNER.FirstOrDefault(x => x.CODE_ID == idCode);
                }
                if (codes != null)
                {
                    obj.Result = codes;
                    obj.StatusCode = "1";
                }
                else
                {
                    obj.Message = new ClsMessage() { Link = "", Message = "No se pudo obtener el customer asignado al codigo", Title = "", Buttontext = "Aceptar" };
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

        public static ClsResponse<List<UNIPOLLA_CODES_WINNER>> GetCodeWinnerByClient(string idClient)
        {
            ClsResponse<List<UNIPOLLA_CODES_WINNER>> obj = new ClsResponse<List<UNIPOLLA_CODES_WINNER>>();
            try
            {
                List<UNIPOLLA_CODES_WINNER> codes;
                using (dbUnicentroCRMEntities db = new dbUnicentroCRMEntities())
                {
                    codes = db.UNIPOLLA_CODES_WINNER.Where(x => x.ID_CLIENTE == idClient).ToList();
                }
                if (codes != null && codes.Count > 0)
                {
                    obj.Result = codes;
                    obj.StatusCode = "1";
                }
                else
                {
                    obj.Message = new ClsMessage() { Link = "", Message = "No se pudo obtener el customer asignado al codigo", Title = "", Buttontext = "Aceptar" };
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
        public static ClsResponse<List<UNIPOLLA_CODES_WINNER>> GetCodeWinnerByEmployee(string idEmployee)
        {
            ClsResponse<List<UNIPOLLA_CODES_WINNER>> obj = new ClsResponse<List<UNIPOLLA_CODES_WINNER>>();
            try
            {
                List<UNIPOLLA_CODES_WINNER> codes;
                using (dbUnicentroCRMEntities db = new dbUnicentroCRMEntities())
                {
                    codes = db.UNIPOLLA_CODES_WINNER.Where(x => x.EMPLOYEE_ID == idEmployee).ToList();
                }
                if (codes != null && codes.Count > 0)
                {
                    obj.Result = codes;
                    obj.StatusCode = "1";
                }
                else
                {
                    obj.Message = new ClsMessage() { Link = "", Message = "No se pudo obtener el customer asignado al codigo", Title = "", Buttontext = "Aceptar" };
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

        public static ClsResponse<bool> SaveCodeWinner(UNIPOLLA_CODES_WINNER codeWinner)
        {
            ClsResponse<bool> obj = new ClsResponse<bool>();
            try
            {
                UNIPOLLA_CODES codes;
                using (dbUnicentroCRMEntities db = new dbUnicentroCRMEntities())
                {
                    db.UNIPOLLA_CODES_WINNER.Add(codeWinner);
                    db.SaveChanges();
                }

                obj.Result = true;
                obj.StatusCode = "1";

            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    ExceptionLogging.LogException(new Exception(string.Format("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",eve.Entry.Entity.GetType().Name, eve.Entry.State)));
                   
                    foreach (var ve in eve.ValidationErrors)
                    {
                        ExceptionLogging.LogException(new Exception(string.Format("- Property: \"{0}\", Error: \"{1}\"",ve.PropertyName, ve.ErrorMessage)));
                      
                    }
                }

                obj.Message = new ClsMessage() { Link = "", Message = "Se presentó un error, por favor intentelo nuevamente.", Title = "Error", Buttontext = "Aceptar" };
                obj.Result = false;
                obj.StatusCode = "0";
                obj.Title = "Error";
            }
            catch (Exception ex)
            {
                ExceptionLogging.LogException(ex);

                obj.Message = new ClsMessage() { Link = "", Message = "Error", Title = "Error", Buttontext = "Aceptar" };
                obj.Result = false;
                obj.StatusCode = "0";
                obj.Title = "Error";
            }
            return obj;
        }
    }
}
