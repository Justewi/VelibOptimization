using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Velibs
{
    [ServiceContract]
    public interface IVelibsOptimisation
    {
        [OperationContract]
        List<string> GetDirections(string origin, string destination);
        
    }
}
