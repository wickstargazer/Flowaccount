using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flowaccount.Enum;

namespace Flowaccount.Models
{
    public class DocumentQuery
    {
        public DocumentQuery()
        {
            DocumentType = new List<DocumentTypes>();
            Filter = new List<FilterOptions>();

            HashTags = new string[] { };
            DateType = DateType.PublishDate;
        }

        public static DocumentQuery GetDefault()
        {
            //List<ListItem> revenueList = new List<ListItem>();
            //revenueList.Add(new ListItem { Text = "Billed (Accrual)", Value = "0" });
            //revenueList.Add(new ListItem { Text = "Collected (Cash based)", Value = "1" });
            return new DocumentQuery() { Month = DateTime.Now.Month, Range = DataRange.CurrentMonth };
        }

        public int? PageSize { get; set; }
        public int? CurrentPage { get; set; }
        public decimal TotalValue { get; set; }
        public decimal TotalVAT { get; set; }
        public int TotalRecords { get; set; }
        public Boolean isReceived { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public DataRange Range { get; set; }
        public DateType DateType { get; set; }
        public int IsFirstCurrent { get; set; }
        public List<DocumentTypes> DocumentType { get; set; }
        public string[] HashTags { get; set; }
        public ReportTypes ReportType { get; set; }
        //public List<ListItem> revenue { get; set; }
        //public List<ListItem> expenses
        //{
        //    get
        //    {
        //        List<ListItem> expenseList = new List<ListItem>();
        //        expenseList.Add(new ListItem { Text = "Exclude Sales Tax", Value = "0" });
        //        expenseList.Add(new ListItem { Text = "Include Sales Tax", Value = "1" });

        //        return expenseList;
        //    }
        //}
        //public IEnumerable<ListItem> PreviousMonths
        //{
        //    get
        //    {
        //        return DateTimeFormatInfo
        //               .InvariantInfo
        //               .MonthNames.Take
        //               (DateTime.Today.Month - 1).Select((monthName, index) => new ListItem
        //               {
        //                   Value = (index + 1).ToString(),
        //                   Text = LblCommon.ResourceManager.GetString(monthName)
        //               }).Reverse();

        //    }
        //}
        //public List<ListItem> PreviousYears
        //{
        //    get
        //    {
        //        int maxYear = DateTime.Now.Year;
        //        List<ListItem> PreviousYearList = new List<ListItem>();
        //        for (int i = 2014; i <= maxYear; i++)
        //        {
        //            PreviousYearList.Add(new ListItem { Text = i.ToString(), Value = i.ToString() });
        //        }

        //        return PreviousYearList;
        //    }
        //}

        private List<FilterOptions> _filter;
        public List<FilterOptions> Filter
        {
            get
            {
                return _filter;
            }
            set
            {
                _filter = value;
            }
        }
        private List<SortOptions> _sortBy;
        public List<SortOptions> SortBy
        {
            get
            {
                return _sortBy;
            }
            set
            {
                _sortBy = value;
            }
        }


    }
    public class FilterOptions
    {
        public string ColumnName { get; set; }
        public string ColumnValue { get; set; }
        public QueryOperator ColumnPredicateOperator { get; set; }
    }

    public class SortOptions
    {
        public string name { get; set; }
        public OrderBy sortOrder { get; set; }
    }
}
