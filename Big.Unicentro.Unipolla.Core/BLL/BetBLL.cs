using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Big.Unicentro.Unipolla.DataAccess.Common;
using Big.Unicentro.Unipolla.DataAccess.DAL;
using Big.Unicentro.Unipolla.DataAccess.Model;

namespace Big.Unicentro.Unipolla.Core.BLL
{
    public class BetBLL
    {
        public static ClsResponse<List<UNIPOLLA_BET>> GetBets(string idCodeWinner)
        {
            return BetDAL.GetBets(idCodeWinner);
        }

        public static ClsResponse<bool> SaveBets(UNIPOLLA_BET bet)
        {
            return BetDAL.SaveBets(bet);
        }
    }
}
