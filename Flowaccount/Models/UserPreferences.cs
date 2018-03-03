namespace Flowaccount.Models
{
    using System;
    using System.Collections.Generic;

    public partial class UserPreferences : BaseModel
    {
        public long UserId { get; set; }
        public string Language { get; set; }
        public string SignatureUrl { get; set; }
        public int Currency { get; set; }
        public string RubberStampUrl { get; set; }

        public virtual User User { get; set; }
    }
}
