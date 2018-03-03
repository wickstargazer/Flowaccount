using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flowaccount.Enum;

namespace Flowaccount.Models
{
    public class Company : BaseModel
    {

        public virtual long Id { get; set; }
        public virtual string NameLocal { get; set; }
        public virtual string NameForeign { get; set; }
        public virtual string AddressLocal { get; set; }
        public virtual string AddressForeign { get; set; }
        public virtual string CompanyTaxId { get; set; }

        public virtual string LogoImage { get; set; }
        public virtual string Fax { get; set; }
        public virtual string Phone1 { get; set; }
        public virtual string Phone2 { get; set; }
        public virtual string Phone3 { get; set; }
        public virtual string Websites { get; set; }
        public virtual CompanyTypeEnum CompanyType { get; set; }

        public virtual DateTime Createdon { get; set; }

        public virtual DateTime Modifiedon { get; set; }

        public virtual long Modifiedby { get; set; }
        public virtual bool isDefault { get; set; }
        public virtual string AddressLocalLine2 { get; set; }
        public virtual string AddressForeignLine2 { get; set; }

        public virtual int VATRate { get; set; }
        public virtual string Email { get; set; }
        public virtual string Branch { get; set; }
        public virtual string AddressLocalLine3 { get; set; }
        public virtual string AddressForeignLine3 { get; set; }
        public virtual string ContactPerson { get; set; }

        public virtual bool isActive { get; set; }

		public virtual int DefaultCreditDays { get; set; }


		public virtual string Remarks { get; set; }
        public virtual long? GalleryId { get; set; }

        public virtual string BranchForeign { get; set; }

        public virtual string BranchCode { get; set; }

        public virtual CompanyPreferences CompanyPreferences { get; set; }
        public virtual IList<User> User { get; set; }
        public virtual Gallery Gallery { get; set; }

        public virtual IList<Media> Media { get; set; }

        public virtual IList<CompanySubscription> CompanySubscription { get; set; }

    }
}
