//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyThuVien
{
    using System;
    using System.Collections.Generic;
    
    public partial class CHITIETPHIEUMUON
    {
        public int MaSach { get; set; }
        public int MaPhieuMuon { get; set; }
        public Nullable<System.DateTime> NgayTra { get; set; }
    
        public virtual PHIEUMUONSACH PHIEUMUONSACH { get; set; }
        public virtual SACH SACH { get; set; }
    }
}