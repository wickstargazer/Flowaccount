using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowaccount.Models
{
        public partial class User : BaseModel
        {
            public User()
            {
                this.CurrencyLocal = 2;
                this.CurrencyForeign = 1;
                this.ForceResetPassword = false;
            }

            public long Id { get; set; }
            public string Firstname { get; set; }
            public string Lastname { get; set; }
            public string UserName { get; set; }
            public System.DateTime Createdon { get; set; }
            public System.DateTime Modifiedon { get; set; }
            public int Modifiedby { get; set; }
            public byte IsActive { get; set; }
            public string SecurityStamp { get; set; }
            public string Discriminator { get; set; }
            public bool IsConfirmed { get; set; }
            public string Email { get; set; }
            public bool EmailConfirmed { get; set; }
            public bool LockoutEnabled { get; set; }
            public Nullable<System.DateTime> LockoutEndDateUtc { get; set; }
            public string PhoneNumber { get; set; }
            public bool PhoneNumberConfirmed { get; set; }
            public bool TwoFactorEnabled { get; set; }
            public int AccessFailedCount { get; set; }
            public string SecurityQuestion { get; set; }
            public string SecurityAnswer { get; set; }
            public string ProfilePicture { get; set; }
            public string Mobile { get; set; }
            public long CurrencyLocal { get; set; }
            public long CurrencyForeign { get; set; }
            public int VATRate { get; set; }
            public bool ForceResetPassword { get; set; }
            public string OneTimePassword { get; set; }
            public Nullable<System.DateTime> OneTimePasswordCreatedOn { get; set; }
            public string ReferralCode { get; set; }

            public virtual IList<Role> Role { get; set; }
            //public virtual IList<Invoice> Invoice { get; set; }
           // public virtual Culture CultureForeign { get; set; }
           // public virtual Culture Culture { get; set; }
            //public virtual IList<Quotation> UserQuotation { get; set; }
            //public virtual IList<BillingNote> BillingNote { get; set; }
            //public virtual IList<PurchaseOrder> PurchaseOrder { get; set; }
            public virtual UserPreferences UserPreferences { get; set; }
            public virtual IList<Company> CompanyUser { get; set; }
            //public virtual IList<QuotationBillingNotePartialPayment> QuotationBillingNotePartialPayment { get; set; }
            //public virtual IList<QuotationInvoicePartialPayment> QuotationInvoicePartialPayment { get; set; }
            public virtual IList<Media> Media { get; set; }
            //public virtual IList<Purchase> Purchase { get; set; }
            //public virtual IList<DocumentShare> DocumentShare { get; set; }
            //public virtual IList<ReferralConversion> ReferralConversion { get; set; }
            public virtual IList<CompanySubscription> CompanySubscription { get; set; }
            //public virtual IList<CreditNote> CreditNote { get; set; }
            //public virtual IList<DebitNote> DebitNote { get; set; }
            //public virtual IList<Receipt> Receipt { get; set; }
        }
}
