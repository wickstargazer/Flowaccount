namespace Flowaccount.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class RefreshToken : BaseModel
    {
        public string Id { get; set; }
        public string Subject { get; set; }
        public string ClientId { get; set; }
        public System.DateTime IssueUtc { get; set; }
        public System.DateTime ExpiresUtc { get; set; }
        public string ProtectedTicket { get; set; }
        public string Scope { get; set; }
    }
}
