using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGenealogySystem.Enums
{
    public enum ProductType : byte { RawMaterial = 0, Component = 1, SubAssembly = 2, FinishedGood = 3 }
    public enum TrackingMethod : byte { LotControl = 0, SerialControl = 1, NoTracking = 2 }

}
