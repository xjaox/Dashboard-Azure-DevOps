using DashboardDevOps.Models;
using System;
using System.Linq;

namespace DashboardDevOps.Data
{
    public static class DbInitializer
    {
        public static void Initialize(DataContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Processo.Any())
            {
                return;   // DB has been seeded
            }

            var Process = new TB_PROCESSO[]
            {
                new TB_PROCESSO{COD_PROCESSO="123",DSC_PROCESSO="Alexander",DTA_CRIACAO=DateTime.Parse("2005-09-01")},
            };

            foreach (TB_PROCESSO s in Process)
            {
                context.Processo.Add(s);
            }

            context.SaveChanges();
        }
    }
}