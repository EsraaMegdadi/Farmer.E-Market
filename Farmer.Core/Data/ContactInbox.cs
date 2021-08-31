using System;
using System.Collections.Generic;
using System.Text;

namespace Farmer.Core.Data
{
    public class ContactInbox
    {
        public int InboxId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
    }
}
