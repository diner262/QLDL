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
    
    public partial class tNhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tNhanVien()
        {
            this.tPhieuDky = new HashSet<tPhieuDky>();
        }
    
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string TenDangNhap { get; set; }
        public string TenDNAdmin { get; set; }
    
        public virtual tAdmin tAdmin { get; set; }
        public virtual tUser tUser { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tPhieuDky> tPhieuDky { get; set; }
    }
}
