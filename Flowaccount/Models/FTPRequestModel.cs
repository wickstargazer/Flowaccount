using Flowaccount.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowaccount.Models
{
    public abstract class FTPRequestModel 
    {
        public string FileName { get; set; }
        public string Output { get; set; }
        public Credentials Credentials { get; set; }
    }
}
