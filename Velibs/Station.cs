using System;
using System.Xml;

namespace Velibs
{
    public class Station
    {
        public int Number { get; }
        public Coordonnes Coordonnes { get; }
        public string Name { get; }
        public string Address { get; }

        public Station(XmlNode node)
        {
            Number = Convert.ToInt32(node.Attributes["number"].Value);
            Coordonnes = new Coordonnes(
                Convert.ToDouble(node.Attributes["lat"].Value),
                Convert.ToDouble(node.Attributes["lng"].Value)
            );
            Name = node.Attributes["name"].Value;
            Address = node.Attributes["fullAddress"].Value;
        }
    }
}