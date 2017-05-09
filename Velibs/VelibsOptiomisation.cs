using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Velibs
{
    public class VelibsOptimisation : IVelibsOptimisation
    {
        public string GetDirections(string origin, string destination)
        {
            return string.Format("OK");
        }
    }
}
