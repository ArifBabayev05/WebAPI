﻿using System;
using Entity.Base;

namespace Entity.Entities
{
    public class Image : IEntity
    {
        public int Id { get; set; }
        public string? Name  { get; set; }

        public List<CompanyImage>? CompanyImage { get; set; }

    }
}

