using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace xml
{
    [Serializable]
    [XmlRoot("Employee")] // переменования элемента
    public class Person
    {
        [XmlElement("FullName")]
        public string Name { get; set; }
        [XmlAttribute("Id")]
        public int Id { get; set; }
        public int Age { get; set; }
        [XmlIgnore]
        public string Adress { get; set; }
        //[XmlArray("Названия массива")]
        //[XmlArrayItem("Названия элемент массива")]
    }
}

