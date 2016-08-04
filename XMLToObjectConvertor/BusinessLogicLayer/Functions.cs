using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using XmlToObjectConvertor;

namespace XMLToObjectConvertor.BusinessLogicLayer
{
    public class Functions
    {
        public T Deserialize<T>(string input) where T : class
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T), new XmlRootAttribute("PersonList"));

                using (StringReader stringReader = new StringReader(input))
                    return (T) serializer.Deserialize(stringReader);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return null;
            }
        }

        public string Serialize(List<Person> personList)
        {
            XmlSerializer ser = new XmlSerializer(personList.GetType(), new XmlRootAttribute("PersonList"));
            string result = string.Empty;

            using (MemoryStream memoryStream = new MemoryStream())
            {
                ser.Serialize(memoryStream, personList);

                memoryStream.Position = 0;
                result = new StreamReader(memoryStream).ReadToEnd();
            }

            return result;
        }

        public void XMLTestFunction(string xmlSource)
        {
            System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
            doc.LoadXml(xmlSource);
            System.Xml.XmlNode rootNode = doc.DocumentElement;

            if(rootNode.HasChildNodes)
            {
                foreach(var node in rootNode)
                {
                    var cNode = node;
                }
            }

            string test = "";
        }
    }
}
