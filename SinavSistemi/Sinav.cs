//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SinavSistemi
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sinav
    {
        public int sinavID { get; set; }
        public int sinavSonuc { get; set; }
        public System.DateTime sinavTarih { get; set; }
        public int ogrenciID { get; set; }
        public int dersID { get; set; }
        public Nullable<int> dogruSayisi { get; set; }
        public Nullable<int> yanlisSayisi { get; set; }
    
        public virtual Ders Ders { get; set; }
        public virtual Ogrenci Ogrenci { get; set; }
    }
}
