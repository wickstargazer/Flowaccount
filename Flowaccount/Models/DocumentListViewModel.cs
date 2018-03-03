using Flowaccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flowaccount.Models
{
    public class DocumentListViewModel
    {
        public DocumentListViewModel()
        {
            CurrentPage = 1;
        }

        public IEnumerable<Document> List { get; set; }
        public int Total { get; set; }
        public int CurrentPage { get; set; }
        public decimal TotalValue { get; set; }
        public IQueryable Query { get; set; }
        
    }
}
