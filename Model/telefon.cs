//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class telefon
    {
        public int id { get; set; }
        public string telefon1 { get; set; }
        public string descripcio { get; set; }
        public int idcontacte { get; set; }
    
        public virtual contacte contacte { get; set; }
    }
}
