using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowaccount.Models
{
    public class APIResponse<T>
    {
        public bool Status { get; set; }
        public string Message { get; set; }
        public int Code { get; set; }
        public T Data { get; set; }
        public APIResponse()
        {
            this.Status = true;
            this.Message = string.Empty;
        }
    }
}
