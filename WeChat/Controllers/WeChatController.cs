﻿using DyApp.Infrastructure.Utils;
using DYApp.WechatService;
using DYApp.WeMessage;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace WeChat.Controllers
{
    public class WeChatController : Controller
    {

        // GET: WeChat
        public WeChatController()
        {
        }
 
        [HttpGet]
        public string Wechat(string signature,string timestamp,string nonce,string echostr)
        {

            if (SignUtil.CheckSignature(signature, timestamp, nonce))
                return echostr;
            else
                return "错误";
        }
        [HttpPost]        
        public string Wechat()
        {

            Stream sm = Request.InputStream;
            byte[] buf = new byte[sm.Length];
            sm.Read(buf, 0, buf.Length);
            
            string xmlStr = Encoding.UTF8.GetString(buf);

            string result = processWechat(xmlStr);
            return result;
        }

        private string processWechat(string xmlStr)
        {
            WeMsg msg = XMLHelper.Parse(xmlStr);
            string result = XMLHelper.ToString((new MessageService()).ProcessMessage(msg));
            return result;
        }
    }
}