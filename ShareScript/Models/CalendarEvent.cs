using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShareScript.Models
{



    public class CalendarEvent
    {
        public CalendarEvent(string _title, DateTime _dateTime, string _type)
        {
            Title = _title;
            Date = _dateTime;
            Type = _type;
        }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; }
    }
}
