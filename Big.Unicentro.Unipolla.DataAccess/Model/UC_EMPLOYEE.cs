//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Big.Unicentro.Unipolla.DataAccess.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class UC_EMPLOYEE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UC_EMPLOYEE()
        {
            this.UNIPOLLA_CODES_WINNER = new HashSet<UNIPOLLA_CODES_WINNER>();
        }
    
        public string GUID { get; set; }
        public decimal ID { get; set; }
        public decimal IDENTIFICATION_TYPE_ID { get; set; }
        public string IDENTIFICATION_NUMBER { get; set; }
        public string ACCEPTANCE_NUMBER { get; set; }
        public decimal GENRE_ID { get; set; }
        public string NAME_1 { get; set; }
        public string NAME_2 { get; set; }
        public string LAST_NAME_1 { get; set; }
        public string LAST_NAME_2 { get; set; }
        public string PHONE { get; set; }
        public Nullable<decimal> MARITAL_STATUS_ID { get; set; }
        public Nullable<System.DateTime> BORN_DATE { get; set; }
        public string ADDRESS { get; set; }
        public string EMAIL { get; set; }
        public string BUSINESS_ID { get; set; }
        public Nullable<System.DateTime> ADMISSION_DATE { get; set; }
        public bool WORK_WEEKEND { get; set; }
        public Nullable<decimal> CHARGE_ID { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public Nullable<System.DateTime> REGISTER_DATE { get; set; }
        public Nullable<System.DateTime> LAST_UPDATE { get; set; }
        public bool IS_ACTIVE { get; set; }
        public string NEIGHBORHOOD_ID { get; set; }
        public Nullable<System.DateTime> DATE_IN_UNICENTRO { get; set; }
        public string ADDITIONAL_ADDRESS_INFO { get; set; }
        public Nullable<bool> HAS_CHILDREN { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UNIPOLLA_CODES_WINNER> UNIPOLLA_CODES_WINNER { get; set; }
    }
}