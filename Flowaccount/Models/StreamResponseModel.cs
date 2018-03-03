using Flowaccount.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowaccount.Models
{
    public class StreamResponseModel : BaseModel
    {
        public bool Success { get; set; }
        public Stream Output { get; set; }
    }
}
