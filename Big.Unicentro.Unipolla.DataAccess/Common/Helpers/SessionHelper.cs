using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Big.Unicentro.Unipolla.DataAccess.Common.Helpers
{
   public static class SessionHelper
    {
        public static string IdCurrentCustomer
        {
            get => (HttpContext.Current.Session["IdCurrentCustomer"] ?? string.Empty).ToString();
            set => HttpContext.Current.Session["IdCurrentCustomer"] = value;
        }
        public static string IdCurrentCodesWinner
        {
            get => (HttpContext.Current.Session["IdCurrentCodesWinner"] ?? string.Empty).ToString();
            set => HttpContext.Current.Session["IdCurrentCodesWinner"] = value;
        }

        public static void LimpiarSesion()
        {
            IdCurrentCustomer = null;
            IdCurrentCodesWinner = null;
        }
    }
}
