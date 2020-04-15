using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DashboardDevOps.Models
{
    public class TB_FUNCAO
    {
        // public TB_FUNCAO()
        // {
        //     this.TB_PERFIL_FUNCAO = new HashSet<TB_PERFIL_FUNCAO>();
        // }
    
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public decimal ID_FUNCAO { get; set; }
        public string DSC_FUNCAO { get; set; }
        public string DSC_COD_FUNCAO { get; set; }
        public System.DateTime DTA_CADASTRO { get; set; }
        public string DSC_COD_GERAL_FUNCAO { get; set; }
    
        //public virtual ICollection<TB_PERFIL_FUNCAO> TB_PERFIL_FUNCAO { get; set; }
    }
}