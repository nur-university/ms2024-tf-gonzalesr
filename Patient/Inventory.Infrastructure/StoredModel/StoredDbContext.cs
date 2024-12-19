﻿using PatientManagement.Infrastructure.StoredModel.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagement.Infrastructure.StoredModel
{
    internal class StoredDbContext : DbContext
    {
        public DbSet<PatientStoredModel> Patient { get; set; }
        public DbSet<PatientPhoneStoredModel> PatientPhone { get; set; }
        public DbSet<UserStoredModel> User { get; set; }

        public StoredDbContext(DbContextOptions<StoredDbContext> options) : base(options)
        {

        }

    }
}
