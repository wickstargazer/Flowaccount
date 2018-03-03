using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowaccount.Models
{
    public enum InvoiceStatus
    {
        Awaiting = 1,
        InvoiceDelivered = 3,
        Paid = 5,
        Void = 7,
    }

    public enum ReceiptStatus
    {
        Awaiting = 1,
        Paid = 5,
        Void = 7,
    }

    public enum InvoiceUnit
    {
        Centimeters = 1,
        Millimeters = 3,
        Meters = 5,
        Pieces = 7,
        Hours = 9,
        Days = 11
    }

    public enum QuotationStatus
    {
        Awaiting = 1,
        Approved = 3,
        ApprovedAndProcessed = 5,
        Void = 7,
        Rejected = 9,
        BillingNotePartials = 11,
        InvoicePartials = 13,
        BillingNotePartialsProcessed = 15,
        InvoicePartialsProcessed = 17,
    }

    public enum PurchaseOrderStatus
    {
        Awaiting = 1,
        Approved = 3,
        Paid = 5,
        Void = 7,
        ApprovedAndProcessed = 9
    }

    public enum VendorStatus
    {
        Awaiting = 1,
        Approved = 3,
        Paid = 5,
        Void = 7,
    }

    public enum BillingNoteStatus
    {
        Awaiting = 1,
        Approved = 3,
        ApprovedAndProcessed = 5,
        Void = 7,
        Delete = 9
    }

    public enum ExpenseStatus
    {
        Awaiting = 1,
        Approved = 3,
        ApprovedAndProcessed = 5,
        Void = 7
    }

    public enum PurchaseStatus
    {
        Awaiting = 1,
        Approved = 3,
        Paid = 5,
        Void = 7,
    }

    public enum WithholdingTaxStatus
    {
        Awaiting = 1,
        Approved = 3,
        Processed = 5,
        Void = 7,
    }

    public enum CreditNoteStatus
    {
        Awaiting = 1,
        Approved = 3,
        ApprovedAndProcessed = 5,
        Void = 7,
        Delete = 9,
    }

    public enum DebitNoteStatus
    {
        Awaiting = 1,
        Approved = 3,
        Paid = 5,
        Void = 7,
        Delete = 9,
    }

    public enum InventoryMethod
    {
        WeightedAverage = 3,
        MovingAverage = 5,
    }

    public enum Entity
    {
        PND3 = 1,
        PND53 = 3,
        PND1 = 15,
        PND1K = 5,
        PND1KSpecial = 7,
        PND2 = 9,
        PND2K = 11,
        PND3K = 13,
    }

    public enum MethodPayment
    {
        Cash = 1,
        Cheque = 3,
        Transfer = 5,
        CreditCard = 7,
        PushPay = 9
    }

}
