﻿using FinalProjectNurlan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectNurlan.ViewModels
{
    public class BlogVM
    {
        public List<Blog> Blogs { get; set; }
        public Blog Blog { get; set; }
        public List<Tag> Tags { get; set; }
      
    }
}