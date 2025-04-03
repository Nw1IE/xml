using NewPractice_27._03_;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace xml
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*XDocument doc = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XElement("Company",
                new XElement("Employee",
                        new XAttribute("Id", 1),
                        new XElement("Name", "John"),
                        new XElement("Age", 20)),


                    new XElement("Employee",
                        new XAttribute("Id", 2),
                        new XElement("Name", "Anny"),
                        new XElement("Age", 22))
                    )
                );*/


            /*doc.Save("company.xml");
            XDocument doc1 = XDocument.Load("Company.xml");

            var employees = doc1.Descendants("Employee")
                .FirstOrDefault(e => (int)e.Attribute("Id") == 1);

            if (employees != null)
            {
                employees.Element("Age").Value = "35";
            }
            doc1.Save("Company.xml");*/


            /*  foreach ( var item in employees )
              {
                  int id = (int)item.Attribute("Id");
                  string name = item.Element("Name")?.Value;
                  int age = (int)item.Element("Age");
                  Console.WriteLine($"{id}, {name}, {age}");
              }*/

            /*XmlDocument doc = new XmlDocument();
            XmlElement company = doc.CreateElement("Company");
            doc.AppendChild( company );
            XmlElement employee1 = doc.CreateElement("Employee");
            employee1.SetAttribute("Id", "1");
            employee1.AppendChild(doc.CreateElement("Name", "John"));
            employee1.AppendChild(doc.CreateElement("Age", "20"));
            company.AppendChild(employee1);

            XmlElement employee2 = doc.CreateElement("Employee");
            employee2.SetAttribute("Id", "2");
            employee2.AppendChild(doc.CreateElement("Name", "Anny"));
            employee2.AppendChild(doc.CreateElement("Age", "22"));
            company.AppendChild(employee2);
            doc.Save("Company.xml");*/

            /*XmlDocument doc = new XmlDocument();
            doc.Load("Company.xml");

            XmlNodeList employees = doc.SelectNodes("//Employee");

            foreach (XmlNode item in employees)
            {
                int id = Convert.ToInt32(item.Attributes["Id"].Value);
                string name = item["Name"]?.InnerText;
                int age = Convert.ToInt32(item["Age"]?.InnerText);
                Console.WriteLine($"{id}, {name}");
            }*/

            /*var acc = new PaymentAccount(100m, 3, 50m, 4);
            Console.WriteLine(acc.ToString());
            acc.ToXmlFile("accTrue.xml");

            PaymentAccount.SerializeComputedFields = false;
            acc.ToXmlFile("accFalse.xml");*/

            var acc = PaymentAccount.FromXml("accTrue.xml");
            Console.WriteLine(acc.ToString());

        }
    }
}