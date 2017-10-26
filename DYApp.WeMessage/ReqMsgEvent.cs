using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DYApp.WeMessage
{
    public class ReqMsgEvent:WeMsg
    {
        public string Event { get; set; }
        public string EventKey { get; set; }
        public string MenuId { get; set; }
    }
}
