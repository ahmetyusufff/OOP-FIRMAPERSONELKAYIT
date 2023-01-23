using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_FIRMAPERSONELKAYIT
{
    public partial class form_hesaplama : Form
    {
        const string CalendarId = "tr.turkish#holiday@group.v.calendar.google.com";
        const string ApiKey = "AIzaSyCsZ66wGekS_8DmncWzdm3cPwLlUfgZrtc";
        static List<Event> events = new List<Event>();
        public form_hesaplama()
        {
            InitializeComponent();
            var service = new CalendarService(new BaseClientService.Initializer() { ApiKey = ApiKey, ApplicationName = "api-test" });
            var request = service.Events.List(CalendarId);
            DateTime bugun = DateTime.Now;
            DateTime buay = new DateTime(bugun.Year, bugun.Month, 1);
            request.TimeMin = buay;
            request.TimeMax = buay.AddMonths(1);
            var response = request.Execute();
            events.AddRange(response.Items);
        }
        
    }
}
