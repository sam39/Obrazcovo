﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Obrazcovo.Models
{
    public class Thread
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ApplicationUser Owner { get; set; }
        public DateTime Date { get; set; }
    }
}