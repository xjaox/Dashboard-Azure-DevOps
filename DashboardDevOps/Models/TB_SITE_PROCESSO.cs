using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DashboardDevOps.Models
{
    public class TB_SITE_PROCESSO
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_SITE { get; set; }
        public int ID_PROCESSO { get; set; }
        public System.DateTime DTA_CRIACAO { get; set; }
    }
}