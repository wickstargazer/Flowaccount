using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowaccount.Models
{
    public enum PackageStatus
    {
        Pending = 10,
        Approve = 30,
        Suspend = 50,
        Terminated = 70,
        Delete = 90
    }
}
