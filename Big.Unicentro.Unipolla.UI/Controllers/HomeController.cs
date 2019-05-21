using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Big.Unicentro.Unipolla.Core.BLL;
using Big.Unicentro.Unipolla.DataAccess.Common;
using Big.Unicentro.Unipolla.DataAccess.Common.Diagnostics;
using Big.Unicentro.Unipolla.DataAccess.Common.Filters;
using Big.Unicentro.Unipolla.DataAccess.Common.Helpers;
using Big.Unicentro.Unipolla.DataAccess.Entities;
using Big.Unicentro.Unipolla.DataAccess.Model;

namespace Big.Unicentro.Unipolla.UI.Controllers
{
    [Authorize]
    [CheckSession]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ClsResponse<int> TournamentsID = TournamentBLL.GetTournamentID();
            ClsResponse<List<UNIPOLLA_TEAM>> objTeams = MatchBLL.GetTeams(TournamentsID.Result);
            ClsResponse<List<UNIPOLLA_BET>> objBets = BetBLL.GetBets(SessionHelper.IdCurrentCodesWinner);



            ViewBag.Teams = objTeams.Result;
            if (objBets.Result == null)
            {
                objBets.Result = new List<UNIPOLLA_BET>();
            }
            ViewBag.Bets = objBets.Result;



            if (TournamentsID.Result == 1)
            {
                return View("CMundial");
            }
            if (TournamentsID.Result == 2)
            {
                return View("CAmerica");
            }
            if (TournamentsID.Result == 3)
            {
                return View("CCorto");
            }

            return View();


        }

        public ActionResult CMundial()
        {
            return View();
        }

        public ActionResult CAmerica()
        {
            return View();
        }

        public ActionResult CCorto()
        {
            return View();
        }



        [HttpPost]
        public ActionResult SaveBet(List<Entities.ListBet> listBets)
        {

            ClsResponse<bool> objResponse = new ClsResponse<bool>();
            try
            {
                if (DateTime.Now < Convert.ToDateTime(ConfigurationManager.AppSettings.Get("FinishDate")))
                {


                    var objBets = BetBLL.GetBets(SessionHelper.IdCurrentCodesWinner);

                    if (objBets.Result != null && objBets.Result.Count > 0)
                    {
                        objResponse.Result = false;
                        objResponse.Message = new ClsMessage { Message = "Usted ya tiene marcadores guardados." };
                    }
                    else
                    {
                        foreach (var item in listBets)
                        {
                            try
                            {
                                UNIPOLLA_BET bet = new UNIPOLLA_BET
                                {
                                    ID_CODES_WINNER = SessionHelper.IdCurrentCodesWinner,
                                    ID_MATCH = Convert.ToInt32(item.IdMatch),
                                    ID_TEAM_1 = Convert.ToInt32(item.IdTeam1),
                                    ID_TEAM_2 = Convert.ToInt32(item.IdTeam2),
                                    REGISTER_DATE_MATCH = DateTime.Now
                                };


                                ClsResponse<bool> saveBets = BetBLL.SaveBets(bet);

                            }
                            catch (Exception ex)
                            {
                                ExceptionLogging.LogException(ex);
                                ExceptionLogging.LogException(new Exception(
                                    $"IdCurrentCodesWinner:{SessionHelper.IdCurrentCodesWinner},IdMatch:{item.IdMatch},IdTeam1:{item.IdTeam1},IdTeam2:{item.IdTeam2} "));
                            }

                        }

                        objResponse.Result = true;
                        objResponse.Message = new ClsMessage { Message = "Los registros fueron guardados exitosamente." };
                    }
                }
                else
                {
                    objResponse.Result = false;
                    objResponse.Message = new ClsMessage { Message = "La fecha limite para registrar ya acabó." };
                }
            }
            catch (Exception ex)
            {
                ExceptionLogging.LogException(ex);
                objResponse.Result = false;
                objResponse.Message = new ClsMessage { Message = "Se presento un error guardando la informacion." };

            }

            return Json(objResponse);

        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}