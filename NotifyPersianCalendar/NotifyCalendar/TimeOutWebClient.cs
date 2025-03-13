using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NotifyPersianCalendar
{
    public class TimeOutWebClient : WebClient
    {
        public static int TimeOut { get; set; } = 15000;

        protected override WebRequest GetWebRequest(Uri address)
        {
            var request = base.GetWebRequest(address);
            if (request != null)
            {
                request.Timeout = TimeOut;
                ((HttpWebRequest)request).ReadWriteTimeout = TimeOut;
            }
            return request;
        }
    }
}
