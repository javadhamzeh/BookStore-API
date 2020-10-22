﻿using BookStore_API.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore_API.DTOs
{
    public class AuthorDTO
    {
        public int Id { get; set; }
        public int Firstname { get; set; }
        public int Lastname { get; set; }
        public int Bio { get; set; }

        public virtual IList<BookDTO> Books { get; set; }
    }
}