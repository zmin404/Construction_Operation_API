using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ISOService_API
{
    [DataContract]
    public class ServerSvcFault
    {
        [DataMember]
        public string FaultMessage;

        public ServerSvcFault(string msg)
        {
            FaultMessage = msg;
        }
    }
}
