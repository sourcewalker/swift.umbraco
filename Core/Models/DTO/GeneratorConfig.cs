﻿using System;

namespace Models.DTO
{
    public class GeneratorConfig
    {
        public DateTimeOffset StartDate { get; set; }

        public DateTimeOffset EndDate { get; set; }

        // DateTime just for storing the time, date information is not relevant
        public DateTimeOffset OpenTime { get; set; }

        // DateTime just for storing the time, date information is not relevant
        public DateTimeOffset CloseTime { get; set; }

        public GeneratorLimitOptions LimitOption { get; set; }

        public int LimitNumber { get; set; }
    }
}
