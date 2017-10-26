using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DyApp.Infrastructure.Utils
{
    public static class SignUtil
    {
        private static string token = "dongyuan";
        public static bool CheckSignature(string signature, string timestamp, string nonce)
        {
            try
            {
                IList<string> list = new List<string>() { token, timestamp, nonce };
                string content = string.Join("", list.OrderBy(p => p));
                if (EnCryption.EnCrypty(content) == signature.ToUpper())
                    return true;
                else
                    return false;
            }catch
            {
                return false;
            }
        }
    }
}
