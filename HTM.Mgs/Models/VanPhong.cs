//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HTM.Mgs.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class VanPhong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VanPhong()
        {
            this.NguoiDungs = new HashSet<NguoiDung>();
        }
    
        public int VanPhongId { get; set; }
        public string TenVanPhong { get; set; }
        public string SoPhong { get; set; }
        public Nullable<bool> TrangThai { get; set; }
        public Nullable<bool> DaXoa { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NguoiDung> NguoiDungs { get; set; }
    }
}
