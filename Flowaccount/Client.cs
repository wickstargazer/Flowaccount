using Flowaccount.Models;
using Flowaccount.Resources;
using System;

namespace Flowaccount
{
    public class Client
    {
        readonly OAuthRequest _requester;

        public readonly CompanyResource Company;
        public readonly CompanySubscriptionResource CompanySubscription;
        public readonly UserResource User;
        public readonly ContactResource Contact;
        public readonly ProductResource Product;
        public readonly DashboardResource Dashboard;
        public readonly ReceiptResource Receipt;
        public readonly InventoryResource Inventory;
        public readonly BillingNoteResource BillingNote;
        public readonly InvoiceResource Invoice;
        public readonly PurchaseOrderResource PurchaseOrder;
        public readonly PurchaseResource Purchase;
        public readonly QuotationResource Quotation;
        public readonly ExpenseResource Expense;
        public readonly CreditNoteResource CreditNote;
        public readonly DebitNoteResource DebitNote;
        public readonly WithHoldingTaxResource WithHoldingTax;
        public readonly ProductCategoryResource ProductCategory;
        public readonly ProductUnitResource ProductUnit;
        public Client(string pkey = null, string skey = null)
            : this(new Credentials(pkey, skey))
        {

        }

		public static Client NewInstance(ClientSettings settings)
		{
			return new Client(settings.ClientId, settings.Token);
		}

		public Client(Credentials credentials)
        {
            if (credentials == null) throw new ArgumentNullException("credentials");
            _requester = new OAuthRequest(credentials);

            Company = new CompanyResource(_requester);
            CompanySubscription = new CompanySubscriptionResource(_requester);
            User = new UserResource(_requester);
            Contact = new ContactResource(_requester);
            Product = new ProductResource(_requester);
            ProductCategory = new ProductCategoryResource(_requester);
            ProductUnit = new ProductUnitResource(_requester);
            //Dashboard = new DashboardResource(_requester);
            //Receipt = new ReceiptResource(_requester);
            Inventory = new InventoryResource(_requester);
            BillingNote = new BillingNoteResource(_requester);
            Invoice = new InvoiceResource(_requester);
            //PurchaseOrder = new PurchaseOrderResource(_requester);
            //Quotation = new QuotationResource(_requester);
            //Expense = new ExpenseResource(_requester);
            CreditNote = new CreditNoteResource(_requester);
            DebitNote = new DebitNoteResource(_requester);
            WithHoldingTax = new WithHoldingTaxResource(_requester);
           
        }

        public DocumentResource<T> GetDocumentResource<T, TResource>()
            where T : Document
            where TResource : DocumentResource<T>
        {

            foreach (var property in this.GetType().GetFields())
            {
                if (property.FieldType == typeof(TResource))
                    return (DocumentResource<T>)this.GetType().GetField(property.Name).GetValue(this);
            }

            throw new Exception("Property of this type: " + typeof(T).ToString() + " does not exists.");
        }
    }
}
