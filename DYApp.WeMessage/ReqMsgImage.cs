using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DYApp.WeMessage
{
    public class ReqMsgImage: ReqMsg
    {
        public string PicUrl { get; set; }
        public string MediaId { get; set; }
    }
}
