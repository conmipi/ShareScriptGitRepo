using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ShareScript.Models;
using ShareScript.TagHelpers;

namespace ShareScript.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public List<CalendarEvent> Events { get; set; }

        public List<CalendarEvent> LocalEvents = new List<CalendarEvent>();

        private int month;

        private int year;

        private readonly CalendarEventContext _context;


        public HomeController(ILogger<HomeController> logger, CalendarEventContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            DateTime currentTime = DateTime.Today;
            ViewBag.Month = currentTime.Month;
            ViewBag.Year = currentTime.Year;
            ViewBag.CalendarEvents = LocalEvents;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult SetDate(int month, int year)
        {
            return Json(GetHtml(year, month));
        }

        [HttpGet]
        public IActionResult GetDates()
        {
            LocalEvents.Add(new CalendarEvent("Test Event", DateTime.Today, "info"));
            Events = LocalEvents;
            return Json(GetHtml(2019,12));
        }

        [HttpGet]
        public IActionResult GetEvents()
        {
            LocalEvents.Add(new CalendarEvent("Test Event", DateTime.Today, "info"));
            return Json(LocalEvents);
        }

        // GET: api/CalendarEvents
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CalendarEvent>>> GetCalendarEvents()
        {
            return await _context.CalendarEvents.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CalendarEvent>> GetCalendarEvent(int id)
        {
            var calendarEvent = await _context.CalendarEvents.FindAsync(id);

            if (calendarEvent == null)
            {
                return NotFound();
            }

            return calendarEvent;
        }

        // POST: api/CalendarEvents
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<CalendarEvent>> PostCalendarEvent(CalendarEvent calendarEvent)
        {
            _context.CalendarEvents.Add(calendarEvent);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCalendarEvent", new { id = calendarEvent.Id }, calendarEvent);
        }

        // DELETE: api/CalendarEvents/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CalendarEvent>> DeleteCalendarEvent(int id)
        {
            var calendarEvent = await _context.CalendarEvents.FindAsync(id);
            if (calendarEvent == null)
            {
                return NotFound();
            }

            _context.CalendarEvents.Remove(calendarEvent);
            await _context.SaveChangesAsync();

            return calendarEvent;
        }

        private bool CalendarEventExists(int id)
        {
            return _context.CalendarEvents.Any(e => e.Id == id);
        }

        private string GetHtml(int Year, int Month )
        {
            var monthStart = new DateTime(Year, Month, 1);
            var events = Events?.GroupBy(e => e.Date);



            var html = new XDocument(
                new XElement("div",
                new XAttribute("id", "calContainer"),
                new XElement("div",
                    new XAttribute("class", "container-fluid"),
                    new XElement("header",
                        new XElement("h4",
                            new XAttribute("class", "display-4 mb-2 text-center"),
                            new XAttribute("id", "title"),
                            monthStart.ToString("MMMM yyyy")
                        ),
                        new XElement("div",
                            new XAttribute("class", "row d-none d-lg-flex p-1 bg-dark text-white"),
                            Enum.GetValues(typeof(DayOfWeek)).Cast<DayOfWeek>().Select(d =>
                                new XElement("h5",
                                    new XAttribute("class", "col-lg p-1 text-center"),
                                    d.ToString()
                                )
                            )
                        )
                    ),
                    new XElement("div",
                        new XAttribute("class", "row border border-right-0 border-bottom-0"),
                        GetDatesHtml()
                    )
                )
            ));


            return html.ToString();

            IEnumerable<XElement> GetDatesHtml()
            {
                var startDate = monthStart.AddDays(-(int)monthStart.DayOfWeek);
                var dates = Enumerable.Range(0, 42).Select(i => startDate.AddDays(i));

                foreach (var d in dates)
                {
                    if (d.DayOfWeek == DayOfWeek.Sunday && d != startDate)
                    {
                        yield return new XElement("div",
                            new XAttribute("class", "w-100"),
                            String.Empty
                        );
                    }

                    var mutedClasses = "d-none d-lg-inline-block bg-light text-muted";
                    yield return new XElement("div",
                        new XAttribute("class", $"day col-lg p-2 border border-left-0 border-top-0 text-truncate {(d.Month != monthStart.Month ? mutedClasses : null)}"),
                        new XElement("h5",
                            new XAttribute("class", "row align-items-center"),
                            new XElement("span",
                                new XAttribute("class", "date col-1"),
                                d.Day
                            ),
                            new XElement("small",
                                new XAttribute("class", "col d-lg-none text-center text-muted"),
                                d.DayOfWeek.ToString()
                            ),
                            new XElement("span",
                                new XAttribute("class", "col-1"),
                                String.Empty
                            )
                        ),
                        new XAttribute("onclick", $"DisplayModal({(d.Day.ToString())})"),
                        GetEventHtml(d)
                    );
                }
            }

            IEnumerable<XElement> GetEventHtml(DateTime d)
            {
                return events?.SingleOrDefault(e => e.Key == d)?.Select(e =>
                    new XElement("a",
                        new XAttribute("class", $"event d-block p-1 pl-2 pr-2 mb-1 rounded text-truncate small bg-{e.Type} text-white"),
                        new XAttribute("title", e.Title),
                        e.Title
                    )
                ) ?? new[] {
                new XElement("p",
                    new XAttribute("class", "d-lg-none"),
                    "No events"
                )
                };
            }
        }
    }
}
