using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowaccount.Enum
{
    public enum CultureType
    {
        EN = 10,
        TH = 20
    }
    public enum BankAccountType
    {
        SavingAccount = 1,
        CurrentAccount = 3,
        CreditCardAccount = 5
    }

    public enum InventoryReportTypes
    {
        RemainingStock = 1,
        Movement = 3,

    }

    public enum CompanyTypeEnum
    {
        PrivateWithTax = 10,
        PrivateWithoutTax = 20,
        Personal = 30,
        //PublicWithTax = 40,
    }
    public enum OrderBy
    {
        Asc = 1,
        Desc = 3
    }
    //public enum FinancialTransactionType
    //{
    //    Debit = 1,
    //    Credit = 3
    //}

    public enum DocumentTypes
    {
        PurchaseOrder = 1,
        Quotation = 3,
        BillingNote = 5,
        TaxInvoice = 7,
        Receipt = 9,
        Expense = 13,
        Vendor = 15,
        WithHoldingTax = 17,
        BillingNotePartials = 19,
        TaxInvoicePartails = 21,
        Purchase = 23,
        AdjustInventory = 29,
        CreditNote = 31,
        DebitNote = 33
    }

    public enum BusinessType
    {
        SellingProducts = 1,
        SellingServices = 3,
        SellingBoth = 5,
        Custom = 7
    }

    public enum RunningNumberType
    {
        Default = 1,
        YearMonth = 3,
        Month = 5,
        Year = 7
    }

    public enum CouponType
    {
        Coupon = 1,
        Serial = 3
    }

    public enum DocumentReferenceTypes
    {
        ImportDocument = 1,
        PartialPayments = 3,
        Batch = 5
    }

    public enum InventoryType
    {
        In = 1,
        Out = 3,
        Transfer = 5,
        InternalUse = 7,
        BroughtForward = 9,
        AdjustIn = 11,
        AdjustOut = 13,
    }

    public enum ProductTypes
    {
        Service = 1,
        ProductWithNoStock = 3,
        ProductWithStock = 5,
    }

    public enum PartialPaymentMethod
    {
        None = 1,
        Quantity = 3,
        Price = 5,
        Percentage = 7,
    }

    public enum WithHoldingTaxType
    {
        PND3 = 1,
        PND53 = 3,
        PND1K = 5,
        PND1KSpecial = 7,
        PND2 = 9,
        PND2K = 11,
        PND3K = 13,
        PND1 = 15,
    }

    public enum WithHoldingTaxIncomeType
    {
        Salary = 1,
        Commission = 3,
        Licensing = 5,
        Interest = 7,
        NetProfit30 = 9,
        NetProfit25 = 11,
        NetProfit20 = 13,
        NetProfitOther = 15,
        TaxExemption = 17,
        DividenFromShareOfProfit = 19,
        PortionOfNetProfit = 21,
        RecognitionOfProfit = 23,
        TaxOther = 25,
        RevenueDepartmentTax = 27,
        Others = 29,
    }
    public enum TaxType
    {
        Percent = 1,
        Value = 3,
    }

    public enum DocumentTemplates
    {
        Default = 1, // form1
        Template1 = 3, // form2
        Template2 = 5, // form3
        Template3 = 7, // form4
        Template4 = 9, // form5 9x11
        Template5 = 11, // form6 deafault font
        TemplateA5 = 13, // half A4
        Template9x11withOriginal = 15, // 9x11 have orininal,
        Template8 = 17, // form 9
    }

    public enum ContactTypes
    {
        //OwnCompany = 0,
        Client = 3,
        Vendor = 5,
        VendorAndClient = 7,
    }

    public enum FinancialType
    {
        Sell = 1,
        Buy = 3,
    }

    public enum ReportTypes
    {
        Sales = 10,
        SalesTeamReport = 11,
        Purchase = 20,
        Clients = 30,
        Vendor = 40,
        PaymentCollection = 50,
        ProductReport = 60,
        Quotation = 70,
        BillingNote = 80,
        ReceiveInventory = 90,
        StocksReport = 91,
        GroupStockReport = 92,
        Expense = 100,
        WithHoldingTax = 110,
        ProfitAndLoss = 120,
        Receipt = 130,
        CreditNote = 140,
        DebitNote = 150,
    }

    public enum DateType
    {
        PublishDate = 1,
        PaymentDate = 3,
        ExpenseDate = 5,
        TransitionDate = 7
    }

    public enum DataRange
    {
        CurrentMonth = 1,
        PreviousMonth = 3,
        Manual = 5,
        CurrentYear = 7,
        PreviousYear = 9
    }

    public enum QueryOperator
    {
        //
        // Summary:
        //     The "Or"
        Or = 0,
        //
        // Summary:
        //     The "And"
        And = 1
    }

    public enum ExpenseGroupBy
    {
        None = 1,
        Client = 3,
        Product = 5,
    }
    public enum ProductDiscountTypes
    {
        Percent = 1,
        Value = 3,
    }

	public enum ExportFormat
	{
		PDF = 1,
		JPG = 3,
		HTML = 5,
		EXCEL = 7
	}
}
