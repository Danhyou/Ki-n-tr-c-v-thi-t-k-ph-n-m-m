//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebStieBanSach.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DonHang
    {
        public int MaDonHang { get; set; }
        public Nullable<int> DaThanhToan { get; set; }
        public Nullable<int> TinhTrangDonHang { get; set; }
        public System.DateTime NgayDat { get; set; }
        public Nullable<System.DateTime> NgayGiao { get; set; }
        public Nullable<int> MaKH { get; set; }
    
        public virtual KhachHang KhachHang { get; set; }
    }
}
