﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DaoTaoTinChiCIT.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class daotaotinchiEntities : DbContext
    {
        public daotaotinchiEntities()
            : base("name=daotaotinchiEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<diemrenluyen> diemrenluyens { get; set; }
        public virtual DbSet<dm_capdaotao> dm_capdaotao { get; set; }
        public virtual DbSet<dm_capquyetdinh> dm_capquyetdinh { get; set; }
        public virtual DbSet<dm_chucdanh> dm_chucdanh { get; set; }
        public virtual DbSet<dm_chucvu_cb> dm_chucvu_cb { get; set; }
        public virtual DbSet<dm_chucvu_doanthe> dm_chucvu_doanthe { get; set; }
        public virtual DbSet<dm_chucvu_sv> dm_chucvu_sv { get; set; }
        public virtual DbSet<dm_congthuc> dm_congthuc { get; set; }
        public virtual DbSet<dm_cotdiem> dm_cotdiem { get; set; }
        public virtual DbSet<dm_danhhieu> dm_danhhieu { get; set; }
        public virtual DbSet<dm_dantoc> dm_dantoc { get; set; }
        public virtual DbSet<dm_diemchu> dm_diemchu { get; set; }
        public virtual DbSet<dm_doituongmiengiam> dm_doituongmiengiam { get; set; }
        public virtual DbSet<dm_gio> dm_gio { get; set; }
        public virtual DbSet<dm_hocham> dm_hocham { get; set; }
        public virtual DbSet<dm_hocvi> dm_hocvi { get; set; }
        public virtual DbSet<dm_ht_daotao> dm_ht_daotao { get; set; }
        public virtual DbSet<dm_ht_khenthuong> dm_ht_khenthuong { get; set; }
        public virtual DbSet<dm_ht_kyluat> dm_ht_kyluat { get; set; }
        public virtual DbSet<dm_ht_thi> dm_ht_thi { get; set; }
        public virtual DbSet<dm_khoanthuchi> dm_khoanthuchi { get; set; }
        public virtual DbSet<dm_khuvucts> dm_khuvucts { get; set; }
        public virtual DbSet<dm_kieuhocphan> dm_kieuhocphan { get; set; }
        public virtual DbSet<dm_loaihocky> dm_loaihocky { get; set; }
        public virtual DbSet<dm_loaihocphan> dm_loaihocphan { get; set; }
        public virtual DbSet<dm_muchocphi> dm_muchocphi { get; set; }
        public virtual DbSet<dm_nganhang> dm_nganhang { get; set; }
        public virtual DbSet<dm_ngoaingu> dm_ngoaingu { get; set; }
        public virtual DbSet<dm_quanhegd> dm_quanhegd { get; set; }
        public virtual DbSet<dm_quoctich> dm_quoctich { get; set; }
        public virtual DbSet<dm_thanhphan_banthan> dm_thanhphan_banthan { get; set; }
        public virtual DbSet<dm_thanhphan_giadinh> dm_thanhphan_giadinh { get; set; }
        public virtual DbSet<dm_tongiao> dm_tongiao { get; set; }
        public virtual DbSet<donvi> donvis { get; set; }
        public virtual DbSet<form> forms { get; set; }
        public virtual DbSet<funtion_form> funtion_form { get; set; }
        public virtual DbSet<funtion> funtions { get; set; }
        public virtual DbSet<group> groups { get; set; }
        public virtual DbSet<hinhthuc_khenthuong> hinhthuc_khenthuong { get; set; }
        public virtual DbSet<hinhthuc_kyluat> hinhthuc_kyluat { get; set; }
        public virtual DbSet<hocbong> hocbongs { get; set; }
        public virtual DbSet<hocky> hockies { get; set; }
        public virtual DbSet<hocphan> hocphans { get; set; }
        public virtual DbSet<hocphan_quanhe> hocphan_quanhe { get; set; }
        public virtual DbSet<hocphi> hocphis { get; set; }
        public virtual DbSet<hocvu> hocvus { get; set; }
        public virtual DbSet<hocvu_dk> hocvu_dk { get; set; }
        public virtual DbSet<hocvu_test> hocvu_test { get; set; }
        public virtual DbSet<hoso_cb> hoso_cb { get; set; }
        public virtual DbSet<hoso_sv> hoso_sv { get; set; }
        public virtual DbSet<khoahoc> khoahocs { get; set; }
        public virtual DbSet<khung> khungs { get; set; }
        public virtual DbSet<khung_hp> khung_hp { get; set; }
        public virtual DbSet<lop> lops { get; set; }
        public virtual DbSet<lop_gvcn> lop_gvcn { get; set; }
        public virtual DbSet<lophocphan> lophocphans { get; set; }
        public virtual DbSet<lophocphandiem> lophocphandiems { get; set; }
        public virtual DbSet<lophocphandiemchung> lophocphandiemchungs { get; set; }
        public virtual DbSet<lophp> lophps { get; set; }
        public virtual DbSet<lophpdanhsach> lophpdanhsaches { get; set; }
        public virtual DbSet<lophpdktamthoi> lophpdktamthois { get; set; }
        public virtual DbSet<lophpnamhoc> lophpnamhocs { get; set; }
        public virtual DbSet<mienhoc> mienhocs { get; set; }
        public virtual DbSet<namdaotao> namdaotaos { get; set; }
        public virtual DbSet<nganh> nganhs { get; set; }
        public virtual DbSet<nhieunghanh> nhieunghanhs { get; set; }
        public virtual DbSet<nhom_tienquyet> nhom_tienquyet { get; set; }
        public virtual DbSet<phieuthu> phieuthus { get; set; }
        public virtual DbSet<phonghoc> phonghocs { get; set; }
        public virtual DbSet<role_group> role_group { get; set; }
        public virtual DbSet<role> roles { get; set; }
        public virtual DbSet<thanhtoan_nganhang> thanhtoan_nganhang { get; set; }
        public virtual DbSet<thi> @this { get; set; }
        public virtual DbSet<thietlaphesodiemrl> thietlaphesodiemrls { get; set; }
        public virtual DbSet<thoikhoabieu> thoikhoabieux { get; set; }
        public virtual DbSet<thuchi> thuchis { get; set; }
        public virtual DbSet<thuhocphi> thuhocphis { get; set; }
        public virtual DbSet<treeview> treeviews { get; set; }
        public virtual DbSet<tuan> tuans { get; set; }
        public virtual DbSet<user> users { get; set; }
        public virtual DbSet<web_dangky_hp> web_dangky_hp { get; set; }
        public virtual DbSet<web_dm_nhomhoidap> web_dm_nhomhoidap { get; set; }
        public virtual DbSet<web_hoidap> web_hoidap { get; set; }
        public virtual DbSet<web_thoigiandk> web_thoigiandk { get; set; }
        public virtual DbSet<web_tintuc> web_tintuc { get; set; }
        public virtual DbSet<xetdatn> xetdatns { get; set; }
        public virtual DbSet<xettotnghiep> xettotnghieps { get; set; }
        public virtual DbSet<web_users> web_users { get; set; }
        public virtual DbSet<dm_noisinh> dm_noisinh { get; set; }
        public virtual DbSet<web_dangky_khaosat> web_dangky_khaosat { get; set; }
    }
}
