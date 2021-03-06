﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace Apiparcial.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base ("Default Connection")
    { }

        protected DataContext(DbCompiledModel model) : base(model)
        {
        }

        public System.Data.Entity.DbSet<APIparcial.Models.Product> Products { get; set; }
    }
}