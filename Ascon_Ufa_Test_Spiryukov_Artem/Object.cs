using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Ascon_Ufa_Test_Spiryukov_Artem
{
    public class Object
    {
        public int Id;
        public string Type;
        public string Product;
        public int ParentId;
        public List<Attribute> Attributes;
        [XmlIgnore] public Object Parent;
        [XmlIgnore] public List<Object> Childs;

        public Object(int id, string type, string product)
        {
            Type = type;
            Product = product;
            Id = id;
            Attributes = new List<Attribute>();
            Childs = new List<Object>();
        }

        public Object() {}

        public void AddAttribute(string name, string value)
        {
            Attributes.Add(new Attribute(name, value));
        }

        public void SetParent(Object parent)
        {
            Parent = parent;
            parent.Childs.Add(this);
            ParentId = parent.Id;
        }
    }

    public class Attribute
    {
        public string Name { get; set; }
        public string Value { get; set; }

        public Attribute(string name, string value)
        {
            Name = name;
            Value = value;
        }
        public Attribute() { }
    }
}
