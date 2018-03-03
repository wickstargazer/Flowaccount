using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flowaccount.Enum;

namespace Flowaccount.Models
{
    public partial class Contact : BaseModel
    {
        public Contact()
        {

        }

        public new long Id { get; set; }
        public string NameLocal { get; set; }
        public string NameForeign { get; set; }
        public string AddressLocal { get; set; }
        public string AddressForeign { get; set; }
        public string CompanyTaxId { get; set; }
        public string LogoImage { get; set; }
        public string Fax { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Phone3 { get; set; }
        public string Websites { get; set; }
        public CompanyTypeEnum CompanyType { get; set; }
        public System.DateTime Createdon { get; set; }
        public System.DateTime Modifiedon { get; set; }
        public long Modifiedby { get; set; }
        public bool isDefault { get; set; }
        public string AddressLocalLine2 { get; set; }
        public string AddressForeignLine2 { get; set; }
        public Nullable<int> DefaultCreditDays { get; set; }
        public int VATRate { get; set; }
        public string Email { get; set; }
        public string Branch { get; set; }
        public string AddressLocalLine3 { get; set; }
        public string AddressForeignLine3 { get; set; }
        public string ContactPerson { get; set; }
        public bool isActive { get; set; }
        public ContactTypes ContactType { get; set; }
        public string Remarks { get; set; }
        public Nullable<long> GalleryId { get; set; }
        public string BranchForeign { get; set; }


        public virtual ICollection<ContactBankAccount> ContactBankAccount { get; set; }
    }
}
