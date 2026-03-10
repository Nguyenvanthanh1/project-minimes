using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGenealogySystem.Enums
{
    enum StatusLot
    {
        Quarantine,
        Available,
        Reserved,
        Consumed,
        Expired,
        Blocked

    }
    enum QuantityStatus
    {
       PendingQC,Passed,Failed,Concessional
    }
}
