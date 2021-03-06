﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using AzureChallengeNetwork.Website.Entities;

namespace AzureChallengeNetwork.Website.Context
{
    public class AzureChallengeContext : DbContext
    {
        public AzureChallengeContext() : base("name=AzureChallengeSQLConnection")
        {
        }
        public DbSet<Userpost> Userposts { get; set; }
    }
}
