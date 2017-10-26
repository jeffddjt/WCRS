using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DYApp.WeMessage
{
    public class WeMsg
    {
        public string ToUserName { get; set; }
        public string FromUserName { get; set; }
        public long CreateTime { get; set; }
        public string MsgType { get; set; }

    }
}
