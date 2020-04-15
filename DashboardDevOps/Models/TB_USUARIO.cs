using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DashboardDevOps.Models
{
    public class TB_USUARIO
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_USUARIO { get; set; }
        public int ID_PERFIL { get; set; }
        public string DSC_NOME { get; set; }
        public string DSC_LOGIN { get; set; }
        public string DSC_SENHA { get; set; }
        public System.DateTime DTA_CADASTRO { get; set; }
        public System.DateTime DTA_ATUALIZADO { get; set; }
        public int FLG_STATUS { get; set; }
    }
}
