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
    
    public partial class BaoCao
    {
        public int BaoCaoId { get; set; }
        public string MaBaoCao { get; set; }
        public string TenSanPham { get; set; }
        public string TenBaoCao { get; set; }
        public string DiaChi { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public Nullable<double> DonGia { get; set; }
        public Nullable<double> ThanhTien { get; set; }
        public Nullable<System.DateTime> NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public Nullable<bool> TrangThai { get; set; }
        public Nullable<bool> DaXoa { get; set; }
        public Nullable<int> NhapKhoId { get; set; }
    
        public virtual NhapKho NhapKho { get; set; }
    }
}
