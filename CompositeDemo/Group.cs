﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDemo
{
    public class Group
    {
        public string Name { get; set; }
        public List<Person> Members { get; set; }
        public Group()
        {
            Members = new List<Person>();
        }
    }
}
