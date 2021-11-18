// -----------------------------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// -----------------------------------------------------------------------

using System;

namespace MyPortfolio.Services.Api.Brokers.DateTimes
{
    public class DateTimeBroker : IDateTimeBroker
    {
        public DateTimeOffset GetCurrentDateTime() =>
            DateTimeOffset.UtcNow;
    }
}