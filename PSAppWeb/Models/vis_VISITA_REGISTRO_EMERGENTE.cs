//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PSAppWeb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class vis_VISITA_REGISTRO_EMERGENTE
    {
        public int reg_id { get; set; }
        public int visi_id { get; set; }
        public int inst_id { get; set; }
        public string inst_name { get; set; }
        public string reg_date { get; set; }
        public string reg_lat { get; set; }
        public string reg_lon { get; set; }
        public string reg_ini { get; set; }
        public string reg_end { get; set; }
        public Nullable<int> reg_status { get; set; }
    }
}
