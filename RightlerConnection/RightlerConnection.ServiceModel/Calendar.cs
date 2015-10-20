using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack;

namespace RightlerConnection.ServiceModel
{
    [Route("/Calendar/")]
    public class Calendar: IReturn<CalendarResponse>
    {
    }
}
