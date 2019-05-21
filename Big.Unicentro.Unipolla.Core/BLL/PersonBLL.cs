using System;
using System.Collections.Generic;
using System.Text;
using Big.Unicentro.Unipolla.DataAccess.Common;
using Big.Unicentro.Unipolla.DataAccess.DAL;
using Big.Unicentro.Unipolla.DataAccess.Model;

namespace Big.Unicentro.Unipolla.Core.BLL
{
    public class PersonBLL
    {
        public static ClsResponse<UC_CUSTOMER> GetClient(string idClient)
        {
            return PersonDAL.GetClient(idClient);
        }
        public static ClsResponse<UC_CUSTOMER> GetClientByDocument(string document)
        {
            return PersonDAL.GetClientByDocument(document);
        }
        public static ClsResponse<UC_EMPLOYEE> GetEmployee(string idEmployee)
        {
            return PersonDAL.GetEmployee(idEmployee);
        }
        public static ClsResponse<UC_EMPLOYEE> GetEmployeeBydocument(string document)
        {
            return PersonDAL.GetEmployeeBydocument(document);
        }
    }
}
