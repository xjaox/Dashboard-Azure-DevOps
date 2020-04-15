using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DashboardDevOps.Models
{
    public class TB_PROCESSO
    {
        // public TB_PROCESSO()
        // {
        //     this.TB_SITE_PROCESSO = new HashSet<TB_SITE_PROCESSO>();
        // }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_PROCESSO { get; set; }
        public string DSC_PROCESSO { get; set; }
        public string COD_PROCESSO { get; set; }
        public DateTime DTA_CRIACAO { get; set; }

        //public virtual ICollection<TB_SITE_PROCESSO> TB_SITE_PROCESSO { get; set; }
    }
}