﻿using System;

namespace StaffApp.Data
{
    public class PriceHistory
    {
        public int Id { get; set;}
        public DateTime EffectiveFrom { get; set;}
        public double Price { get; set;}
    }
}