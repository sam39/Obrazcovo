using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Obrazcovo.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Text { get; set;}
        public ApplicationUser Owner { get; set; }
        public DateTime Date { get; set; }
        public Thread Thread { get; set; }
    }
}