using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DashboardDevOps.Models
{
    public class TB_PERFIL
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public decimal ID_PERFIL { get; set; }
        public string DSC_PERFIL { get; set; }
        public short NRO_META { get; set; }
        public decimal ID_LOCAL { get; set; }
        public short FLG_STATUS { get; set; }
        public System.DateTime DTA_CADASTRO { get; set; }
    }
}