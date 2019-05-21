using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Big.Unicentro.Unipolla.DataAccess.Common;
using Big.Unicentro.Unipolla.DataAccess.Common.Diagnostics;
using Big.Unicentro.Unipolla.DataAccess.Model;

namespace Big.Unicentro.Unipolla.DataAccess.DAL
{
   public  class MatchDAL
    {
        public static ClsResponse<List<UNIPOLLA_TEAM>> GetTeams()
        {
            ClsResponse<List<UNIPOLLA_TEAM>> obj = new ClsResponse<List<UNIPOLLA_TEAM>>();
            try
            {
                List<UNIPOLLA_TEAM> team;
                using (dbUnicentroCRMEntities db = new dbUnicentroCRMEntities())
                {
                    team = db.UNIPOLLA_TEAM.Where(x => x.ACTIVE == true).ToList();
                }
                if (team != null && team.Count > 0)
                {
                    obj.Result = team;
                    obj.StatusCode = "1";
                }
                else
                {
                    obj.Message = new ClsMessage() { Link = "", Message = "No se pudo obtener los equipos.", Title = "", Buttontext = "Aceptar" };
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
