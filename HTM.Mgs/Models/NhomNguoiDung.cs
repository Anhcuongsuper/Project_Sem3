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
    
    public partial class NhomNguoiDung
    {
        public string NhomQuyenSuDungID { get; set; }
        public string ChucNangNguoiDungID { get; set; }
        public string MoTa { get; set; }
        public Nullable<bool> TrangThai { get; set; }
    
        public virtual ChucNangNguoiDung ChucNangNguoiDung { get; set; }
        public virtual NhomQuyenSuDung NhomQuyenSuDung { get; set; }
    }
}
