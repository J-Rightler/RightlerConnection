using ServiceStack;

namespace RightlerConnection.ServiceModel
{
    public class CalendarResponse: IHasResponseStatus
    {
        public ResponseStatus ResponseStatus { get; set; }
    }
}
