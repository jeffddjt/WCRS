using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DYApp.WeMessage
{
    public class ReqMsgVoice:ReqMsg
    {
        public string MediaId { get; set;}
        public string Format { get; set; }
    }
}
