//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Table_foto_files
    {
        public decimal id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public decimal id_folder { get; set; }
    
        public virtual Table_folders Table_folders { get; set; }
    }
}