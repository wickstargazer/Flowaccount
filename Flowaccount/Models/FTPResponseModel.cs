using Flowaccount.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowaccount.Models
{
    public class FTPResponsetModel : BaseModel
    {
        public bool Success { get; set; }
        public string Output { get; set; }
    }
}
