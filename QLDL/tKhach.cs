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
    
    public partial class tKhach
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tKhach()
        {
            this.tDangKy = new HashSet<tDangKy>();
            this.tVeDuLich = new HashSet<tVeDuLich>();
        }
    
        public string MaKhach { get; set; }
        public string TenKhach { get; set; }
        public string DienThoai { get; set; }
        public string DiaChi { get; set; }
        public string TenDangNhap { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tDangKy> tDangKy { get; set; }
        public virtual tUser tUser { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tVeDuLich> tVeDuLich { get; set; }
    }
}
