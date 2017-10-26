using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DYApp.WeMessage
{
    public class RepMsg:WeMsg
    {
        public string ToXML()
        {
            XElement xml = new XElement("xml", ToXmls());
            return xml.ToString();
        }

        private IEnumerable<XElement> ToXmls()
        {
            return this.GetType().GetProperties().Select(p => new XElement(p.Name, p.GetValue(this)));
        }
    }
}
