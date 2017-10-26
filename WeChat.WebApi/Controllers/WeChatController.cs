using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WeChat.WebApi.Controllers
{
    public class WeChatController : ApiController
    {
        [HttpGet]
        public string Authintication(string authStr)
        {
            return authStr;
        }
    }
}
