using System;
using System.Xml;

namespace XMLRefExtract
{
    class XMLRefExtract
    {
        private static string xmlFilePath = "..\\..\\..\\InputDocument.xml";

        public XMLRefExtract(){}

        public void Launch()
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(xmlFilePath);
                XmlNode root = doc.FirstChild;

                XmlNode decNode = root.FirstChild;

                if (decNode.HasChildNodes)
                {
                    for (int i = 0; i < decNode.ChildNodes.Count; i++)
                    {
                        XmlNode headerNode = decNode.ChildNodes[i].ChildNodes[0];
                        if (headerNode.HasChildNodes)
                        {
                            for (int j = 0; j < headerNode.ChildNodes.Count; j++)
                            {
                                XmlNode node = headerNode.ChildNodes[j];
                                if (node.Attributes.Count > 0)
                                {
                                    foreach (XmlAttribute att in node.Attributes)
                                    {
                                        if (att.Name == "RefCode")
                                        {
                                            if ((att.InnerText == "MWB") || (att.InnerText == "TRV") || (att.InnerText == "CAR"))
                                            {
                                                Console.Write(att.InnerText + ": ");
                                                Console.WriteLine(node.FirstChild.InnerText);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (XmlException xex)
            {
                Console.WriteLine(xex);   
            }
        }
    }
}
