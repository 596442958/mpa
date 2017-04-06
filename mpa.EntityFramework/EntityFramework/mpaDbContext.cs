﻿using System.Data.Common;
using Abp.Zero.EntityFramework;
using mpa.Authorization.Roles;
using mpa.MultiTenancy;
using mpa.Users;

namespace mpa.EntityFramework
{
    public class mpaDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public mpaDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in mpaDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of mpaDbContext since ABP automatically handles it.
         */
        public mpaDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public mpaDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public mpaDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
