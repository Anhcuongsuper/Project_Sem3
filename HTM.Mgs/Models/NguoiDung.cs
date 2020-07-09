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
    using System.Configuration;

    public partial class NguoiDung
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NguoiDung()
        {
            this.SanPhams = new HashSet<SanPham>();
            this.YeuCauNguoiDungs = new HashSet<YeuCauNguoiDung>();
        }
    
        public int NguoiDungID { get; set; }
        public string MaNhanVien { get; set; }
        public string HoVaTen { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string Email { get; set; }
        public string DienThoai { get; set; }
        public string SoCMT { get; set; }
        public Nullable<int> ChucVuId { get; set; }
        public Nullable<int> VanPhongId { get; set; }
        public Nullable<bool> DaXoa { get; set; }
        public Nullable<bool> TrangThai { get; set; }
        public string AnhDaiDien { get; set; }
        public string NhomQuyenSuDungID { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public Nullable<System.DateTime> NgayXoa { get; set; }
        public Nullable<System.DateTime> NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public string NguoiXoa { get; set; }
        public Nullable<System.DateTime> NgaySua { get; set; }
        public string NguoiSua { get; set; }
        public Nullable<double> GioiHan { get; set; }
        public Nullable<int> SanPhamId { get; set; }
        public Nullable<int> YeuCauNguoiDungId { get; set; }
    
        public virtual ChucVu ChucVu { get; set; }
        public virtual NhomQuyenSuDung NhomQuyenSuDung { get; set; }
        public virtual VanPhong VanPhong { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SanPham> SanPhams { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<YeuCauNguoiDung> YeuCauNguoiDungs { get; set; }
        public virtual SanPham SanPham { get; set; }
        public virtual YeuCauNguoiDung YeuCauNguoiDung { get; set; }
        public string GetDefautThumbnail()
        {
            if (AnhDaiDien != null && AnhDaiDien.Length > 0)
            {
                var arr = AnhDaiDien.Split(',');
                if (arr.Length > 0)
                {
                    return ConfigurationManager.AppSettings["CloudinaryPrefix"] + arr[0];
                }
            }
            return ConfigurationManager.AppSettings["DefautImage"];
        }
        public string[] GetThumbnails()
        {
            if (AnhDaiDien != null && AnhDaiDien.Length > 0)
            {
                var arr = AnhDaiDien.Split(',');
                if (arr.Length > 0)
                {
                    return arr;
                }
            }
            return new string[0];
        }
        public string[] GetThumbnailsIds()
        {
            var ids = new List<string>();
            var thumbnail = GetThumbnails();
            foreach (var thumd in thumbnail)
            {
                var splitedThumb = thumd.Split('/'); // cat theo "/" 
                if (splitedThumb.Length != 4)
                {
                    continue;
                }
                ids.Add(splitedThumb[3].Split('.')[0]);
            }
            return ids.ToArray();
        }
    }
}
