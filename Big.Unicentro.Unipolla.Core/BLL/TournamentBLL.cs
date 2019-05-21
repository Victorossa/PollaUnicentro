using Big.Unicentro.Unipolla.DataAccess.Common;
using Big.Unicentro.Unipolla.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Big.Unicentro.Unipolla.DataAccess.DAL;

namespace Big.Unicentro.Unipolla.Core.BLL
{
    public class TournamentBLL
    {
        public static ClsResponse<int> GetTournamentID()
        {
            return TournamentDAL.GetTournametID();
        }

        public static ClsResponse<List<UNIPOLLA_TOURNAMENT>> GetTournamentsList()
        {
            return TournamentDAL.GetTournamentsList();
        }
    }
}
