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
    
    public partial class UNIPOLLA_MATCH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UNIPOLLA_MATCH()
        {
            this.UNIPOLLA_BET = new HashSet<UNIPOLLA_BET>();
        }
    
        public int ID_MATCH { get; set; }
        public Nullable<int> ID_TEAM_1 { get; set; }
        public Nullable<int> ID_TEAM_2 { get; set; }
        public Nullable<int> ID_WINNER_TEAM { get; set; }
        public int WINNER_POINTS { get; set; }
        public string DESCRIPTION { get; set; }
        public Nullable<int> ID_TOURNAMENT { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UNIPOLLA_BET> UNIPOLLA_BET { get; set; }
        public virtual UNIPOLLA_TEAM UNIPOLLA_TEAM { get; set; }
        public virtual UNIPOLLA_TEAM UNIPOLLA_TEAM1 { get; set; }
        public virtual UNIPOLLA_TEAM UNIPOLLA_TEAM2 { get; set; }
    }
}
