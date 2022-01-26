using System;
using System.Collections.Generic;

#nullable disable

namespace SampleWebApi.Models
{
    public partial class Notification
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string Message { get; set; }

        public virtual User User { get; set; }
    }
}
