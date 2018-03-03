using Flowaccount.Models;
using Flowaccount.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowaccount
{
    public static class DocumentExtensions
    {
        public static DocumentTypes GetDocumentType<T>(this T Document)
        {
            Type _entityType = Document.GetType();
            if (_entityType.BaseType != null && _entityType.Namespace == "System.Data.Entity.DynamicProxies")
            {
                _entityType = _entityType.BaseType;
            }
			return _entityType.GetDocumentType();
		}

		public static DocumentTypes GetDocumentType(this Type entityType)
		{
			if (entityType == typeof(PurchaseOrder))
			{
				return DocumentTypes.PurchaseOrder;
			}
			else if (entityType == typeof(Purchase))
			{
				return DocumentTypes.Purchase;
			}
			else if (entityType == typeof(Quotation))
			{
				return DocumentTypes.Quotation;
			}
			else if (entityType == typeof(BillingNote))
			{
				return DocumentTypes.BillingNote;
			}
			else if (entityType == typeof(Invoice))
			{
				return DocumentTypes.TaxInvoice;
			}
			else if (entityType == typeof(Receipt))
			{
				return DocumentTypes.Receipt;
			}
			else if (entityType == typeof(WithholdingTax))
			{
				return DocumentTypes.WithHoldingTax;
			}
			else if (entityType == typeof(ExpenseList))
			{
				return DocumentTypes.Expense;
			}
			else if (entityType == typeof(CreditNote))
			{
				return DocumentTypes.CreditNote;
			}
			else if (entityType == typeof(DebitNote))
			{
				return DocumentTypes.DebitNote;
			}
			throw new Exception("MisUsageOfData Wrong Type Passed In");
			//throw new FlowDataException(DataExceptionCode.MisUsageOfData, "Wrong Type Passed In");

		}


	}


}
