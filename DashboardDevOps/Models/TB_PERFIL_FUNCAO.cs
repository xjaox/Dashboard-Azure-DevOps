using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DashboardDevOps.Models
{
    public class TB_PERFIL_FUNCAO
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public decimal ID_PERFIL_FUNCAO { get; set; }
        public decimal ID_PERFIL { get; set; }
        public decimal ID_FUNCAO { get; set; }
        public System.DateTime DTA_CADASTRO { get; set; }
        public decimal ID_LOCAL { get; set; }

        //public virtual TB_FUNCAO TB_FUNCAO { get; set; }
        //public virtual TB_PERFIL TB_PERFIL { get; set; }
    }
}