//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EEOE_Satis.Eeoe.Satis.DataAccess.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Urun
    {
        public int UrunId { get; set; }
        public string Barkod { get; set; }
        public string UrunAd { get; set; }
        public string Aciklama { get; set; }
        public string UrunGrup { get; set; }
        public Nullable<double> AlisFiyat { get; set; }
        public Nullable<double> SatisFiyat { get; set; }
        public Nullable<int> KdvOrani { get; set; }
        public string Birim { get; set; }
        public Nullable<double> Miktar { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
        public string Kullanici { get; set; }
        public Nullable<int> KdvTutari { get; set; }
    }
}
