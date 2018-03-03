using System;
using System.Collections.Generic;
using Flowaccount.Enum;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowaccount.Models
{
    public class Document : BaseModel, IDocument
    {
        public Document()
        {

        }
        public String DocumentSerial { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public DateTime PublishedOn { get; set; }
        public DateTime DocumentDate { get; set; }
        public String Branch { get; set; }
        public decimal Discount { get; set; }
        public String Remarks { get; set; }
        public bool IsVat { get; set; }
        public bool IsVatInclusive { get; set; }
        public bool IsWithholding { get; set; }
        //[BsonDefaultValue(new decimal(0.00M))]
        public decimal WithHeld { get; set; }
        public String TotalInText { get; set; }
        public String Reference { get; set; }
        public String SalesName { get; set; }
        public int CreditDays { get; set; }
        public DateTime? DueDate { get; set; }
        //public DateTime? ReferenceDate { get; set; }
        public String CompanyName { get; set; }
        public String CompanyAddress { get; set; }
        public String CompanyAddressLine2 { get; set; }
        public String CompanyAddressLine3 { get; set; }
        public String CompanyNameEn { get; set; }
        public String CompanyAddressEn { get; set; }
        public String CompanyAddressLine2En { get; set; }
        public String CompanyAddressLine3En { get; set; }
        public String BranchEn { get; set; }
        public String Phone { get; set; } // Phone office
        public String Mobile { get; set; }
        public String Fax { get; set; }
        public String CompanyTaxId { get; set; }
        public long ContactId { get; set; }
        public String Name { get; set; }
        public bool IsDicountAsPercentage { get; set; }
        public string CompanyWebsite { get; set; }
        public String InternalNotes { get; set; }
        public decimal DiscountPercentage { get; set; }
        public long? SalesId { get; set; }
        public decimal RoundingAdjustment { get; set; }
        public long CreatedBy { get; set; }
        public long SortById { get; set; }
        public List<DocumentReference> ReferencedToMe { get; set; }
        public List<DocumentReference> ReferencedByMe { get; set; }
        public bool AllowDelete { get; set; }
        public int Status { get; set; }
        public long? DocumentSerialNoPrefixNullable { get; set; }
        public long CompanyId { get; set; }
		public string DocumentType { get; set; }
        public bool PushedRecord { get; set; }
        public int Page { get; set; }
        public decimal VATValue { get; set; }
        public DocumentTypes Type { get; set; }
        public string DocumentId { get { return Id.ToString(); } }
        public decimal Value { get; set; }
        public decimal SumValue { get; set; }
        public bool Reconciled { get; set; }
        public Contact Contact { get; set; }
        public User Sales { get; set; }
        public string PartialPaymentMethod { get; set; }
        public bool IsDelete { get; set; }
        //public TStatus GetStatus<TStatus>()
        //{
        //    return (TStatus)System.Enum.Parse(typeof(TStatus), StatusEnum.ToString());
        //}
        public decimal TaxAmount { get; set; }
        public decimal TaxRate { get; set; }
        public Nullable<long> GalleryId { get; set; }
        public long RecordId { get; set; }
        public int VatRate { get; set; }
        public Gallery Gallery { get; set; }
        public Company Company { get; set; }
        public new long Id { get; set; }
        string IDocument.DocumentId { get; set; }
    }
}
 