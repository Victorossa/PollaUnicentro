using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Big.Unicentro.Unipolla.DataAccess.Common;
using Big.Unicentro.Unipolla.DataAccess.DAL;
using Big.Unicentro.Unipolla.DataAccess.Model;

namespace Big.Unicentro.Unipolla.Core.BLL
{
   public class CodeBLL
    {
        public static ClsResponse<UNIPOLLA_CODES> GetCode(string code)
        {
            return CodeDAL.GetCode(code);
        }
        public static ClsResponse<UNIPOLLA_CODES> GetCodeById(decimal idCode)
        {
            return CodeDAL.GetCodeById(idCode);
        }
        public static ClsResponse<UNIPOLLA_CODES_WINNER> GetCodeWinner(decimal idCode)
        {
            return CodeDAL.GetCodeWinner(idCode);
        }
        public static ClsResponse<List<UNIPOLLA_CODES_WINNER>> GetCodeWinnerByClient(string idClient)
        {
            return CodeDAL.GetCodeWinnerByClient(idClient);
        }
        public static ClsResponse<List<UNIPOLLA_CODES_WINNER>> GetCodeWinnerByEmployee(string idEmployee)
        {
            return CodeDAL.GetCodeWinnerByEmployee(idEmployee);
        }
        public static ClsResponse<bool> SaveCodeWinner(UNIPOLLA_CODES_WINNER codeWinner)
        {
            return CodeDAL.SaveCodeWinner(codeWinner);
        }
    }
}
