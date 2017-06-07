﻿using Microsoft.Extensions.Logging;

namespace Ombi.Helpers
{
    public class LoggingEvents
    {
        public static EventId ApiException => new EventId(1000);
        public static EventId RadarrApiException => new EventId(1001);
        public static EventId CacherException => new EventId(2000);
        public static EventId RadarrCacherException => new EventId(2001);
        public static EventId MovieSender => new EventId(3000);
    }
}