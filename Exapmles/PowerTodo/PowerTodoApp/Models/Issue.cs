﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PowerTodoApp.Models
{
    public class Issue
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Owner { get; set; }
        public string Content { get; set; }
        public int Priority { get; set; }
        public bool Completed { get; set; }
    }
}