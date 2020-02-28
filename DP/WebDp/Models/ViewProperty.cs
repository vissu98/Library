﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebDp.Models
{
    public class ViewProperty
    {
        public List<Book> Books { get; set; }
        public SelectList Categories { get; set; }
        public string BookCategory { get; set; }
        public string searchstring { get; set; }
    }
}