﻿using System;
using System.Diagnostics;

namespace Taiwan_Import_Export
{
    [DebuggerDisplay("{Model}, {Price}")]
    class Car
    {
        public String Model { get; set; }
        public String Price { get; set; }
        public String Link { get; set; }
        public String ImageUrl { get; set; }
    }
}
