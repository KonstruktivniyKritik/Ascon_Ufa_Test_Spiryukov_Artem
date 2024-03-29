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

        public Object(int Id, string Type, string Product)
        {
            this.Type = Type;
            this.Product = Product;
            this.Id = Id;
            this.Attributes = new List<Attribute>();
            this.Childs = new List<Object>();
        }

        public Object() {}

        public void AddAttribute(string name, string value)
        {
            Attributes.Add(new Attribute(name, value));
        }

        public void SetParent(Object Parent)
        {
            this.Parent = Parent;
            Parent.Childs.Add(this);
            this.ParentId = Parent.Id;
        }
    }

    public class Attribute
    {
        public string Name { get; set; }
        public string Value { get; set; }

        public Attribute(string Name, string Value)
        {
            this.Name = Name;
            this.Value = Value;
        }
        public Attribute() { }
    }
}
