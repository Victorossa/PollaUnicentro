using System;
using System.Collections.Generic;
using System.Text;
using Big.Unicentro.Unipolla.DataAccess.Common;
using Big.Unicentro.Unipolla.DataAccess.DAL;
using Big.Unicentro.Unipolla.DataAccess.Model;

namespace Big.Unicentro.Unipolla.Core.BLL
{
   public class MatchBLL
    {
        public static ClsResponse<List<UNIPOLLA_TEAM>> GetTeams(int ID_TOURNAMENT)
        {
            return MatchDAL.GetTeams(ID_TOURNAMENT);
        }
    }
}
