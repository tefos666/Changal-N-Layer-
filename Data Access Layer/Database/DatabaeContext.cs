﻿using Changal.Domain.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Changal.Persistence.Context
{
    public class DatabaeContext : DbContext
    {


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=ChangalDB;User ID=sa;Password=mlkbnzr;Integrated Security=True;TrustServerCertificate=True");
        }

        DbSet<Customer> Customers { get; set; }
        DbSet<Food> Foods { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<Role> Roles { get; set; }

        

        
    }
}
