//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MangosData.Context
{
    using System;
    using System.Collections.Generic;
    
    public partial class spell_proc_event
    {
        public int entry { get; set; }
        public byte SchoolMask { get; set; }
        public int SpellFamilyName { get; set; }
        public long SpellFamilyMaskA0 { get; set; }
        public long SpellFamilyMaskA1 { get; set; }
        public long SpellFamilyMaskA2 { get; set; }
        public long SpellFamilyMaskB0 { get; set; }
        public long SpellFamilyMaskB1 { get; set; }
        public long SpellFamilyMaskB2 { get; set; }
        public long SpellFamilyMaskC0 { get; set; }
        public long SpellFamilyMaskC1 { get; set; }
        public long SpellFamilyMaskC2 { get; set; }
        public long procFlags { get; set; }
        public long procEx { get; set; }
        public float ppmRate { get; set; }
        public float CustomChance { get; set; }
        public long Cooldown { get; set; }
    }
}
