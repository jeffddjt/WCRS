using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DYApp.WeMessage
{
    public class ReqMsgVideo:ReqMsg
    {
        public string MediaId { get; set; }
        public string ThumbMediaId { get; set; }
    }
}
