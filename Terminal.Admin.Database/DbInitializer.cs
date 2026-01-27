using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Terminal.Admin.Data.Enums;
using Terminal.Admin.Data.Models;

namespace Terminal.Admin.Database
{
    public static class DbInitializer
    {
        public static void Seed(TerminalDbContext context)
        {
            var services = new List<SupportService>
            {
                new SupportService { Service = SupportServiceType.MfrrDaPos, ServiceName = "MfrrDaPos" },
                new SupportService { Service = SupportServiceType.MfrrSaPos, ServiceName = "MfrrSaPos" },
                new SupportService { Service = SupportServiceType.MfrrDaNeg, ServiceName = "MfrrDaNeg" },
                new SupportService { Service = SupportServiceType.MfrrSaNeg, ServiceName = "MfrrSaNeg" },
                new SupportService { Service = SupportServiceType.MFRR5, ServiceName = "MFRR5" },
                new SupportService { Service = SupportServiceType.Afrr, ServiceName = "AFRR" }
            };

            foreach (var s in services)
            {
                // Check if the service exists by ID or by Name
                if (!context.SupportService.Any(x => x.Service == s.Service))
                {
                    context.SupportService.Add(s);
                }
            }

            context.SaveChanges();
        }
    }
}
