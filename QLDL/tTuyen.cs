//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLDL
{
    using System;
    using System.Collections.Generic;
    
    public partial class tTuyen
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tTuyen()
        {
            this.tChuyenDuLich = new HashSet<tChuyenDuLich>();
        }
    
        public string MaTuyen { get; set; }
        public string TenTuyen { get; set; }
        public Nullable<int> SoNgay { get; set; }
        public string GhiChu { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tChuyenDuLich> tChuyenDuLich { get; set; }
    }
}
