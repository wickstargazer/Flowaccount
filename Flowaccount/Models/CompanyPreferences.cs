
namespace Flowaccount.Models
{
    using System;
    using Flowaccount.Enum;

    public partial class CompanyPreferences : BaseModel
    {
        public CompanyPreferences()
        {
            this.ShowWithHolding = true;
            this.InvoicePrefix = "INV";
            this.QuotationPrefix = "QT";
            this.BillingNotePrefix = "BL";
            this.ReceiptPrefix = "RE";
            this.PurchaseOrderPrefix = "PO";
            this.CashInvoicePrefix = "CA";
            this.CashInvoiceStartingNumber = 1;
            this.ReceiptStartingNumber = 1;
            this.QuotationStartingNumber = 1;
            this.BillingNoteStartingNumber = 1;
            this.PurchaseOrderStartingNumber = 1;
            this.PurchaseOrderTitleEN = "Purchase Order";
            this.QuotationTitleEN = "Price Quotation";
            this.BillingNoteTitleEN = "Billing Note/Invoice";
            this.InvoiceTitleEN = "Tax Invoice/Receipt";
            this.ReceiptTitleEN = "Receipt";
            this.PurchaseOrderTitleTH = "ใบสั่งซื้อ";
            this.QuotationTitleTH = "ใบเสนอราคา";
            this.BillingNoteTitleTH = "ใบวางบิล/ใบแจ้งหนี้";
            this.InvoiceTitleTH = "ใบกำกับภาษี/ใบเสร็จรับเงิน";
            this.ReceiptTitleTH = "ใบเสร็จรับเงิน";
            this.InvoiceStartingNumber = 1;
            this.CashInvoiceTitleEN = "RECEIPT";
            this.CashInvoiceTitleTH = "ใบเสร็จรับเงิน";
            this.WithHoldingTaxPrefix = "WT";
            this.WithHoldingTaxStartingNumber = 1;
            this.PrintColor = true;
            this.PurchasePrefix = "RI";
            this.PurchaseStartingNumber = 1;
            this.PurchaseTitleEN = "Receiving Inventory";
            this.PurchaseTitleTH = "ใบรับสินค้า";
            this.AdjustInventoryPrefix = "AI";
            this.ExpensePrefix = "EXP";
            this.CreditNotePrefix = "CN";
            this.CreditNoteStartingNumber = 1;
            this.CreditNoteTitleEN = "Credit Note/Tax Invoice";
            this.CreditNoteTitleTH = "ใบลดหนี้/ใบกำกับภาษี";
            this.DebitNotePrefix = "DN";
            this.DebitNoteStartingNumber = 1;
            this.DebitNoteTitleEN = "Debit Note/Tax Invoice";
            this.DebitNoteTitleTH = "ใบเพิ่มหนี้/ใบกำกับภาษี";
        }

        public long CompanyId { get; set; }
        public bool ShowWithHolding { get; set; }
        public string InvoicePrefix { get; set; }
        public string QuotationPrefix { get; set; }
        public string BillingNotePrefix { get; set; }
        public string ReceiptPrefix { get; set; }
        public string PurchaseOrderPrefix { get; set; }
        public string CashInvoicePrefix { get; set; }
        public long CashInvoiceStartingNumber { get; set; }
        public long ReceiptStartingNumber { get; set; }
        public long QuotationStartingNumber { get; set; }
        public long BillingNoteStartingNumber { get; set; }
        public long PurchaseOrderStartingNumber { get; set; }
        public string PurchaseOrderTitleEN { get; set; }
        public string QuotationTitleEN { get; set; }
        public string BillingNoteTitleEN { get; set; }
        public string InvoiceTitleEN { get; set; }
        public string ReceiptTitleEN { get; set; }
        public string PurchaseOrderTitleTH { get; set; }
        public string QuotationTitleTH { get; set; }
        public string BillingNoteTitleTH { get; set; }
        public string InvoiceTitleTH { get; set; }
        public string ReceiptTitleTH { get; set; }
        public BusinessType BusinessType { get; set; }
        public string TermsAgreement { get; set; }
        public string DefaultRemarks { get; set; }
        public long InvoiceStartingNumber { get; set; }
        public string CashInvoiceTitleEN { get; set; }
        public string CashInvoiceTitleTH { get; set; }
        public RunningNumberType RunningNumberType { get; set; }
        public Nullable<int> PurchaseOrderStartingYear { get; set; }
        public Nullable<int> QuotationStartingYear { get; set; }
        public Nullable<int> BillingNoteStartingYear { get; set; }
        public Nullable<int> InvoiceStartingYear { get; set; }
        public Nullable<int> CashInvoiceStartingYear { get; set; }
        public Nullable<int> ReceiptStartingYear { get; set; }
        public Nullable<int> PurchaseOrderStartingMonth { get; set; }
        public Nullable<int> QuotationStartingMonth { get; set; }
        public Nullable<int> BillingNoteStartingMonth { get; set; }
        public Nullable<int> InvoiceStartingMonth { get; set; }
        public Nullable<int> CashInvoiceStartingMonth { get; set; }
        public Nullable<int> ReceiptStartingMonth { get; set; }
        public bool SettingsInitiated { get; set; }
        public Nullable<System.DateTime> RunningNumberSettingsModifiedOn { get; set; }
        public string WithHoldingTaxPrefix { get; set; }
        public int WithHoldingTaxStartingNumber { get; set; }
        public Nullable<int> WithHoldingTaxStartingMonth { get; set; }
        public Nullable<int> WithHoldingTaxStartingYear { get; set; }
        public DocumentTemplates DocumentTemplates { get; set; }
        public bool PrintColor { get; set; }
        public bool PrintOneInvoice { get; set; }
        public string Remarks { get; set; }
        public string EmailMessageTemplate { get; set; }
        public string PurchasePrefix { get; set; }
        public long PurchaseStartingNumber { get; set; }
        public string PurchaseTitleEN { get; set; }
        public string PurchaseTitleTH { get; set; }
        public Nullable<int> PurchaseStartingYear { get; set; }
        public Nullable<int> PurchaseStartingMonth { get; set; }
        public string AdjustInventoryPrefix { get; set; }
        public int AdjustInventoryStartingNumber { get; set; }
        public Nullable<int> AdjustInventoryStartingMonth { get; set; }
        public Nullable<int> AdjustInventoryStartingYear { get; set; }
        public string ExpensePrefix { get; set; }
        public int ExpenseStartingNumber { get; set; }
        public Nullable<int> ExpenseStartingMonth { get; set; }
        public Nullable<int> ExpenseStartingYear { get; set; }
        public Nullable<System.DateTime> PurchaseOrderRunningNumberModifiedOn { get; set; }
        public Nullable<System.DateTime> QuotationRunningNumberModifiedOn { get; set; }
        public Nullable<System.DateTime> BillingNoteRunningNumberModifiedOn { get; set; }
        public Nullable<System.DateTime> InvoiceRunningNumberModifiedOn { get; set; }
        public Nullable<System.DateTime> PurchaseRunningNumberModifiedOn { get; set; }
        public string RubberStampUrl { get; set; }
        public string CreditNotePrefix { get; set; }
        public int CreditNoteStartingNumber { get; set; }
        public Nullable<int> CreditNoteStartingMonth { get; set; }
        public Nullable<int> CreditNoteStartingYear { get; set; }
        public Nullable<System.DateTime> CreditNoteRunningNumberModifiedOn { get; set; }
        public string CreditNoteTitleEN { get; set; }
        public string CreditNoteTitleTH { get; set; }
        public string DebitNotePrefix { get; set; }
        public int DebitNoteStartingNumber { get; set; }
        public Nullable<int> DebitNoteStartingMonth { get; set; }
        public Nullable<int> DebitNoteStartingYear { get; set; }
        public Nullable<System.DateTime> DebitNoteRunningNumberModifiedOn { get; set; }
        public string DebitNoteTitleEN { get; set; }
        public string DebitNoteTitleTH { get; set; }
        public Nullable<System.DateTime> ReceiptRunningNumberModifiedOn { get; set; }
        public bool UsePartialReceipt { get; set; }
        public virtual Company Company { get; set; }
    }
}
