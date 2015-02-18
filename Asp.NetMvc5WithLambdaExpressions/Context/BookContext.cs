using Asp.NetMvc5WithLambdaExpressions.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Asp.NetMvc5WithLambdaExpressions.Context
{
    public class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
    }
}