using Flowaccount.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowaccount
{
    public interface IDocument
    {
        long Id { get; set; }
        string DocumentSerial { get; set; }
        string DocumentId { get; set; }
        string Remarks { get; set; }
        bool IsDelete { get; set; }
        System.DateTime PublishedOn { get; set; }
        System.DateTime DocumentDate { get; set; }
        System.DateTime CreatedOn { get; set; }
        System.DateTime ModifiedOn { get; set; }
        int VatRate { get; set; }
        Nullable<System.DateTime> DueDate { get; set; }
        long CompanyId { get; set; }
        long CreatedBy { get; set; }
        decimal Value { get; set; }
        string Name { get; set; }
        string InternalNotes { get; set; }
        //long? SalesId { get; set; }
        //string SalesName { get; set; }
        decimal RoundingAdjustment { get; set; }
        Gallery Gallery { get; set; }
		Company Company { get; set; }
		Contact Contact { get; set; }
	}
}
