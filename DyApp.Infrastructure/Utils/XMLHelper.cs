using DYApp.WeMessage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace DyApp.Infrastructure.Utils
{
    public static class XMLHelper
    {
        private static readonly string WeMsgAssembly = "DYApp.WeMessage";
        public static WeMsg Parse(string xmlStr)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmlStr);
            string str = doc.SelectSingleNode("xml/MsgType").InnerText;
            str = str.Substring(0, 1).ToUpper()+str.Substring(1);

            Assembly weMessage = Assembly.Load("DYApp.WeMessage");
            var msg = (WeMsg)weMessage.CreateInstance(string.Format("{0}.WeMsg{1}", WeMsgAssembly, str));
            string typeName = msg.GetType().Name;

            foreach(PropertyInfo property in msg.GetType().GetProperties())
            {
                object value = doc.SelectSingleNode(string.Format("xml/{0}", property.Name)).InnerText;
                property.SetValue(msg, Convert.ChangeType(value,property.PropertyType));
            }

            return msg;
        }

        public static string ToString(WeMsg msg)
        {
            XElement xml = new XElement("xml", toXmls(msg));
            return xml.ToString();
        }

        private static IEnumerable<XElement> toXmls(WeMsg msg)
        {
            return msg.GetType().GetProperties().Select(p => new XElement(p.Name, p.GetValue(msg)));
        }
    }
}
