﻿using DomainLayer.Common;

namespace DomainLayer.Models
{
    public class Book : BaseEntity
    {
        public string? Name { get; set; }
        public string? Author { get; set; }
        public Library? Library { get; set; }


    }
}
