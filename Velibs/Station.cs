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
            string test = node.Attributes["lat"].Value;
            Coordonnes = new Coordonnes(
                Convert.ToDouble(double.Parse(node.Attributes["lat"].Value,System.Globalization.CultureInfo.InvariantCulture)),
                Convert.ToDouble(double.Parse(node.Attributes["lng"].Value, System.Globalization.CultureInfo.InvariantCulture))
            );
            Name = node.Attributes["name"].Value;
            Address = node.Attributes["fullAddress"].Value;
        }
    }
}