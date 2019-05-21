using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Big.Unicentro.Unipolla.DataAccess.Common;
using Big.Unicentro.Unipolla.DataAccess.Common.Diagnostics;
using Big.Unicentro.Unipolla.DataAccess.Model;

namespace Big.Unicentro.Unipolla.DataAccess.DAL
{
    public class BetDAL
    {
        public static ClsResponse<List<UNIPOLLA_BET>> GetBets(string idCodeWinner)
        {
            ClsResponse<List<UNIPOLLA_BET>> obj = new ClsResponse<List<UNIPOLLA_BET>>();
            try
            {
                List<UNIPOLLA_BET> bets;
                using (dbUnicentroCRMEntities db = new dbUnicentroCRMEntities())
                {
                    bets = db.UNIPOLLA_BET.Where(x => x.ID_CODES_WINNER == idCodeWinner).ToList();
                }
                if (bets != null && bets.Count > 0)
                {
                    obj.Result = bets;
                    obj.StatusCode = "1";
                }
                else
                {
                    obj.Message = new ClsMessage() { Link = "", Message = "no hay apuestas para este usuario.", Title = "", Buttontext = "Aceptar" };
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

        public static ClsResponse<bool> SaveBets(UNIPOLLA_BET bet)
        {
            ClsResponse<bool> obj = new ClsResponse<bool>();
            try
            {
                List<UNIPOLLA_BET> bets;

                using (dbUnicentroCRMEntities db = new dbUnicentroCRMEntities())
                {
                     db.UNIPOLLA_BET.Add(bet);
                      db.SaveChanges();
                }

               
                    obj.Result = true;
                    obj.StatusCode = "1";
                
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
