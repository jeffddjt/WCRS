﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DYApp.WeMessage
{
    public class ReqMsgLocation : ReqMsg
    {
        public double Location_X { get; set; }
        public double Location_Y { get; set; }
        public int Scale { get; set; }
        public string Label { get; set; }
    }
}
