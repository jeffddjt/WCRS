
using DYApp.WeMessage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DYApp.WechatService
{
    public class MessageService
    {
        public WeMsg ProcessMessage<TWeMsg>(TWeMsg msg) where TWeMsg:WeMsg
        {
            string temp = msg.FromUserName;
            msg.FromUserName = msg.ToUserName;
            msg.ToUserName = temp;
            return msg;
        }
    }
}
