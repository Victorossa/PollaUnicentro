using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Big.Unicentro.Unipolla.Core.BLL;
using Big.Unicentro.Unipolla.DataAccess.Common;
using Big.Unicentro.Unipolla.DataAccess.Common.Diagnostics;
using Big.Unicentro.Unipolla.DataAccess.Common.Helpers;
using Big.Unicentro.Unipolla.DataAccess.Model;

namespace Big.Unicentro.Unipolla.UI.Controllers
{
    public class AccountController : Controller
    {

        public ActionResult terminos_condiciones()
        {
            ClsResponse<int> TournamentsID = TournamentBLL.GetTournamentID();

            if (TournamentsID.Result == 1)
            {
                return View("Terms");
            }
            if (TournamentsID.Result == 2)
            {
                return View("TermsCAmerica");
            }
            return View("Terms");
        }

        // GET: Account
        public ActionResult Login()
        {
            ClsResponse<int> TournamentsID = TournamentBLL.GetTournamentID();
            if (TournamentsID.Result == 1)
            {
                return View("Login");
            }
            if (TournamentsID.Result == 2)
            {
                return View("loginCAmerica");
            }
            return View("");
        }

        // POST: Account/Create
        [HttpPost]
        public ActionResult Login(string document, string code)
        {
            ClsResponse<bool> objResponse = new ClsResponse<bool>();

            ClsResponse<List<UNIPOLLA_TOURNAMENT>> objTournament = TournamentBLL.GetTournamentsList();

            if (objTournament.Result != null && objTournament.Result.Count == 1)
            {
                ClsResponse<UNIPOLLA_CODES> objPerson = CodeBLL.GetCode(code);

                if (objPerson.Result != null && objPerson.StatusCode.Equals("1"))
                {

                    ClsResponse<UNIPOLLA_CODES_WINNER> customerCode = CodeBLL.GetCodeWinner(objPerson.Result.ID);
                    if (customerCode.Result != null && customerCode.StatusCode.Equals("1"))
                    {
                        string documentCustomer = null;

                        if (customerCode.Result.ID_CLIENTE != null)
                        {
                            ClsResponse<UC_CUSTOMER> client = PersonBLL.GetClient(customerCode.Result.ID_CLIENTE);

                            if (client.Result != null && client.StatusCode.Equals("1"))
                            {
                                documentCustomer = client.Result.IDENTIFICATION_NUMBER;
                            }
                        }
                        else
                        {
                            ClsResponse<UC_EMPLOYEE> employee = PersonBLL.GetEmployee(customerCode.Result.EMPLOYEE_ID);

                            if (employee.Result != null && employee.StatusCode.Equals("1"))
                            {
                                documentCustomer = employee.Result.IDENTIFICATION_NUMBER;
                            }
                        }

                        if (!string.IsNullOrEmpty(documentCustomer))
                        {
                            if (documentCustomer.Equals(document))
                            {
                                string idUser = customerCode.Result.ID_CLIENTE ?? customerCode.Result.EMPLOYEE_ID;

                                SessionHelper.IdCurrentCustomer = idUser;
                                SessionHelper.IdCurrentCodesWinner = customerCode.Result.GUID;
                                FormsAuthentication.SetAuthCookie(idUser, false);

                                objResponse.Result = true;
                            }
                            else
                            {
                                objResponse.Result = false;
                                objResponse.Message = new ClsMessage { Message = "El código ingresado no corresponde con el número de cedula ingresado." };
                            }
                        }
                        else
                        {
                            objResponse.Result = false;
                            objResponse.Message = new ClsMessage { Message = "validar el código ingresado,éste no es correcto." };
                        }

                    }
                    else
                    {
                        string idPersonClient = null;
                        string idPersonEmployee = null;
                        int countCodesWinnerClient = 0;
                        int countCodesWinnerEmployee = 0;
                        bool isEmployee = false;
                        ClsResponse<List<UNIPOLLA_CODES_WINNER>> codesWinner = new ClsResponse<List<UNIPOLLA_CODES_WINNER>>();



                        ClsResponse<UC_EMPLOYEE> employee = PersonBLL.GetEmployeeBydocument(document);


                        if (employee.Result != null && employee.StatusCode.Equals("1"))
                        {
                            idPersonEmployee = employee.Result.GUID;
                            codesWinner = CodeBLL.GetCodeWinnerByEmployee(idPersonEmployee);
                            if (codesWinner.Result != null)
                            {
                                countCodesWinnerEmployee = codesWinner.Result.Count;
                            }
                        }
                        else
                        {
                            ClsResponse<UC_CUSTOMER> client = PersonBLL.GetClientByDocument(document);

                            if (client.Result != null && client.StatusCode.Equals("1"))
                            {
                                idPersonClient = client.Result.GUID;
                                codesWinner = CodeBLL.GetCodeWinnerByClient(idPersonClient);
                                if (codesWinner.Result != null)
                                {
                                    countCodesWinnerClient = codesWinner.Result.Count;
                                    foreach (var item in codesWinner.Result)
                                    {
                                        var codeById = CodeBLL.GetCodeById(item.CODE_ID);
                                        if (codeById.Result.ROL != null && codeById.Result.ROL.ToUpper().Contains("EMPLEADO"))
                                        {
                                            isEmployee = true;
                                        }
                                    }

                                }
                            }

                        }

                        if (!string.IsNullOrEmpty(idPersonClient) || !string.IsNullOrEmpty(idPersonEmployee))
                        {
                            if (countCodesWinnerClient >= 3 || countCodesWinnerEmployee >= 1 || isEmployee)
                            {
                                objResponse.Result = false;
                                objResponse.Message = new ClsMessage { Message = "El usuario " + document + ", ya alcanzó el limite de participaciones permitidas." };
                            }
                            else
                            {
                                UNIPOLLA_CODES_WINNER codeWinnerPerson = new UNIPOLLA_CODES_WINNER();

                                codeWinnerPerson.GUID = Guid.NewGuid().ToString();
                                codeWinnerPerson.CODE_ID = objPerson.Result.ID;
                                if (!string.IsNullOrEmpty(idPersonClient))
                                {
                                    codeWinnerPerson.ID_CLIENTE = idPersonClient;
                                }
                                else if (!string.IsNullOrEmpty(idPersonEmployee))
                                {
                                    codeWinnerPerson.EMPLOYEE_ID = idPersonEmployee;
                                }
                                codeWinnerPerson.ID_EVENT = ConfigurationManager.AppSettings.Get("IdEvent");
                                codeWinnerPerson.REGISTER_DATE = DateTime.Now;
                                codeWinnerPerson.IS_ACTIVE = true;

                                ClsResponse<bool> codes = CodeBLL.SaveCodeWinner(codeWinnerPerson);

                                if (codes.Result)
                                {
                                    SessionHelper.IdCurrentCustomer = idPersonClient;
                                    SessionHelper.IdCurrentCodesWinner = codeWinnerPerson.GUID;
                                    FormsAuthentication.SetAuthCookie(idPersonClient, false);

                                    objResponse.Result = true;
                                }
                                else
                                {
                                    objResponse.Result = false;
                                    objResponse.Message = codes.Message;
                                }

                            }
                        }
                        else
                        {
                            objResponse.Result = false;
                            objResponse.Message = new ClsMessage { Message = "Usuario no registrado, por favor realice el registro por el sitio web o desde un punto de información" };
                        }


                    }

                }

                else
                {
                    objResponse.Result = false;
                    objResponse.Message = new ClsMessage { Message = "validar el código ingresado,éste no es correcto." };
                }
            }
            else
            {
                objResponse.Result = false;
                objResponse.Message = new ClsMessage { Message = "Existe mas de Un Torneo Activado o No hay ninguno, Favor Verificar" };
            }

            try
            {
               
            }
            catch (Exception ex)
            {
                ExceptionLogging.LogException(ex);
                objResponse.Result = false;
                objResponse.Message = new ClsMessage { Message = "Se presento un error consultando la informacion." };

            }

            return Json(objResponse);
        }

        public ActionResult Logout()
        {
            SessionHelper.LimpiarSesion();
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Account");
        }
    }
}
