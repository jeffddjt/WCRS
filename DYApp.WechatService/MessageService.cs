
using DyApp.Infrastructure.Utils;
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
        private static string welcome = "欢迎关注秦皇岛人才库，为您提供7日内最新招聘及求职信息\n<a href = 'https://jinshuju.net/f/tl21JZ\'>点我进行招聘登记</a>\n<a href = 'http://shop13308654.ddkwxd.com/tag/231285\'>点我进入简历超市选择优秀人才</a>，我们每天从数以千计的求职者中为您筛选最新、最优质的求职信息，投放到这里，供您选择。\n<a href = 'https://jinshuju.net/f/j3iabB\'>点我进行求职登记</a>\n<a href = 'http://shop13308654.ddkwxd.com/tag/231300\'>点我进入招聘信息选择优秀企业</a>，我们每天从众多招聘企业中为您筛选最新、最最优质的求职信息，投放到这里，供您选择。\n<a href = 'http://zplsyx.iok.la/weixin3/JSP/tuiguang.jsp\'>推广加盟</a>不仅可以帮助您有需要的朋友快速找到优秀人才、满意工作，您还可以赚取收入。回复？可重复查看此重要信息";
        public string ProcessMessage(WeMsg msg)
        {
            switch (msg.MsgType)
            {
                case MessageType.REQ_MESSAGE_TYPE_TEXT:
                    return processTextMsg((ReqMsgText)msg);
                case MessageType.REQ_MESSAGE_TYPE_IMAGE:
                case MessageType.REQ_MESSAGE_TYPE_VOICE:
                case MessageType.REQ_MESSAGE_TYPE_VIDEO:
                case MessageType.REQ_MESSAGE_TYPE_LOCATION:
                case MessageType.REQ_MESSAGE_TYPE_LINK:
                default:
                    return error(msg);
            }
        }

        private string error(WeMsg msg)
        {
            RepMsgText repMsg = new RepMsgText()
            {
                ToUserName = msg.FromUserName,
                FromUserName = msg.ToUserName,
                Content = "暂不支持该类型的指令!",
                CreateTime = CommonMethod.ConvertDateTimeInt(DateTime.Now),
                MsgType = MessageType.RESP_MESSAGE_TYPE_TEXT
            };
            return repMsg.ToXML();
        }

        public string ProcessEvent(ReqMsgEvent msg)
        {
            return "";
        }

        private string processTextMsg(ReqMsgText msg)
        {
            string content = msg.Content.Trim();
            string reply = content == "?" || content == "？" ? welcome : "暂时不支持该指令!";
            RepMsgText repMsg = new RepMsgText()
            {
                ToUserName = msg.FromUserName,
                FromUserName = msg.ToUserName,
                Content = reply,
                CreateTime = CommonMethod.ConvertDateTimeInt(DateTime.Now),
                MsgType=MessageType.RESP_MESSAGE_TYPE_TEXT
            };
            return repMsg.ToXML();
        }
    }
}
