using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PROCIPHERS_18
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPService" in both code and config file together.
    [ServiceContract]
    public interface IPService
    {
        [OperationContract]
        int RegisterBuyer(BuyerClass obj);

        [OperationContract]
        bool LogIn(int usertype, String username, String password);
    }
}
