using Big.Unicentro.Unipolla.DataAccess.Common;
using Big.Unicentro.Unipolla.DataAccess.Common.Diagnostics;
using Big.Unicentro.Unipolla.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big.Unicentro.Unipolla.DataAccess.DAL
{
    public class TournamentDAL
    {
        public static ClsResponse<int> GetTournametID()
        {
            ClsResponse<int> obj = new ClsResponse<int>();
            try
            {
                List<UNIPOLLA_TOURNAMENT> Tournament;
                using (dbUnicentroCRMEntities db = new dbUnicentroCRMEntities())
                {
                    Tournament = db.UNIPOLLA_TOURNAMENT.Where(x => x.ACTIVE_TOURNAMENT == true).ToList();
                }
                if (Tournament != null)
                {
                    obj.Result = Tournament.FirstOrDefault().ID_TOURNAMENT;
                    obj.StatusCode = "1";
                }
                else
                {
                    obj.Message = new ClsMessage() { Link = "", Message = "No se pudo obtener los Torneos.", Title = "", Buttontext = "Aceptar" };
                    obj.StatusCode = "0";
                }
            }
            catch (Exception ex)
            {
                ExceptionLogging.LogException(ex);

                obj.Message = new ClsMessage() { Link = "", Message = "Error", Title = "Error", Buttontext = "Aceptar" };
                obj.StatusCode = "0";
                obj.Title = "Error";
            }
            return obj;
        }

        public static ClsResponse<List<UNIPOLLA_TOURNAMENT>> GetTournamentsList()
        {
            ClsResponse<List<UNIPOLLA_TOURNAMENT>> obj1 = new ClsResponse<List<UNIPOLLA_TOURNAMENT>>();
            try
            {
                List<UNIPOLLA_TOURNAMENT> Tournaments;
                using (dbUnicentroCRMEntities db = new dbUnicentroCRMEntities())
                {
                    Tournaments = db.UNIPOLLA_TOURNAMENT.Where(x => x.ACTIVE_TOURNAMENT == true).ToList();
                }
                if (Tournaments != null && Tournaments.Count > 0)
                {
                    obj1.Result = Tournaments;
                    obj1.StatusCode = "1";
                }
                else
                {
                    obj1.Message = new ClsMessage() { Link = "", Message = "No se pudo obtener los equipos.", Title = "", Buttontext = "Aceptar" };
                    obj1.Result = null;
                    obj1.StatusCode = "0";
                }
            }
            catch (Exception ex)
            {
                ExceptionLogging.LogException(ex);

                obj1.Message = new ClsMessage() { Link = "", Message = "Error", Title = "Error", Buttontext = "Aceptar" };
                obj1.Result = null;
                obj1.StatusCode = "0";
                obj1.Title = "Error";
            }
            return obj1;
        }
    }
}
