﻿using DeskBooker.Core.Tests.Domain;

namespace DeskBooker.Core.Domain
{
    public class DeskBookingResult : DeskBookingBase
    {
        public DeskBookingResultCode Code { get; set; }
    }
}