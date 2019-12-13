using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShareScript.Models
{
    public class CalendarEventContext:DbContext
    {

        public CalendarEventContext(DbContextOptions<CalendarEventContext> options) : base(options)
        {

        }

        public DbSet<CalendarEvent> CalendarEvents { get; set; }

    }
}
