//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TZ_1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Addresses
    {
        public long Id { get; set; }
        public Nullable<long> Coutry { get; set; }
        public Nullable<long> City { get; set; }
        public Nullable<long> Street { get; set; }
        public Nullable<int> House { get; set; }
        public Nullable<long> Indeks { get; set; }
        public Nullable<System.DateTime> Data { get; set; }
    
        public virtual City City1 { get; set; }
        public virtual Country Country { get; set; }
        public virtual Street Street1 { get; set; }
    }
}
