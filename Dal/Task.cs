//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dal
{
    using System;
    using System.Collections.Generic;
    
    public partial class Task
    {
        public int idTask { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int idPosition { get; set; }
        public Nullable<int> cheked { get; set; }
    
        public virtual Position Position { get; set; }
    }
}
