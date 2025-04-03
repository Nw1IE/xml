using NewPractice_2._04_;
using NewPractice_27._03_;
using System.Linq;
using System.Xml.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace xml
{
    public class Program
    {
        static void Main(string[] args)
        {

            var acc = PaymentAccount.FromJson("accTrue.json");
            Console.WriteLine(acc);
           /* var acc = new PaymentAccount(100m, 3, 50m, 4);
            Console.WriteLine(acc.ToString());
            acc.ToJson("accTrue.json");
            PaymentAccount.SerializeComputedFields = false;
            acc.ToJson("accTrue.json");*/


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
            /*
                        var acc = PaymentAccount.FromXml("accTrue.xml");
                        Console.WriteLine(acc.ToString());*/

    /*        var pers = new Person
            {
                Name = "Test",
                *//*Adress = "Test st.",
                Age = 22,
                Id = 1*//*
            };
            *//*string json1 = @"{
             ""Name"": ""Test"",
             ""Id"": 1,
             ""Age"": 22,
             ""Adress"": ""Test st.""
            }";
            JsonConvert.PopulateObject(json1, pers);
            Console.WriteLine(pers.Age);*//*


            string json3 = @"{
""Employees"": [
{""Name"": ""Pete"", ""Age"": 20},
{""Name"": ""Anny"", ""Age"": 18},
{""Name"": ""John"", ""Age"": 24}
]
}";
            JObject obj = JObject.Parse(json3);
            var names = obj["Employees"]
                .Select(e => e["Name"].ToString())
                .ToList();
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
*/
            /*string json2 = JsonConvert.SerializeObject
                (pers, Formatting.Indented);
            Console.WriteLine (json);
            File.WriteAllText("person.json", json);*/
            /*
                        string json4 = JsonConvert.SerializeObject
                            (pers, Newtonsoft.Json.Formatting.Indented);
                        Console.WriteLine(json4);*/
            /*string json = @"{
  ""Name"": ""Test"",
  ""Id"": 1,
  ""Age"": 22,
  ""Adress"": ""Test st.""
}";*/

            /*  Person person = JsonConvert.DeserializeObject<Person>(json);
              Console.WriteLine(person.Age);*/
            /*
                        Person person1 = JsonConvert.DeserializeObject<Person>(json);
                        Console.WriteLine(person.Name);
                        Person person2 = JsonConvert.DeserializeObject<Person>(json);
                        Console.WriteLine(person.Id);*/






        }
    }
}