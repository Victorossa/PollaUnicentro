using System;
using System.Collections.Generic;
using System.Text;

namespace Big.Unicentro.Unipolla.DataAccess.Common
{
   public class ClsResponse<T>
    {
        public string StatusCode { set; get; }
        //public string StatusMessage { get; set; }
        public ClsMessage Message { get; set; }
        public T Result { set; get; }
        /// <summary>
        /// Results: Listado de objetos T
        /// </summary>
        public List<T> Results { set; get; }
        public string Title { get; set; }
    }

    public class ClsMessage
    {
        #region Atribusto
        public string Message { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public string Buttontext { get; set; }
        #endregion
    }
}
