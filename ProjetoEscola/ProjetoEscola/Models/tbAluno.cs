//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjetoEscola.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbAluno
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbAluno()
        {
            this.tbAlunoProfessor = new HashSet<tbAlunoProfessor>();
        }
    
        public int cdAluno { get; set; }
        public string nmAluno { get; set; }
        public Nullable<decimal> valorMensalidade { get; set; }
        public Nullable<System.DateTime> vencimentoMensalidade { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbAlunoProfessor> tbAlunoProfessor { get; set; }
    }
}
