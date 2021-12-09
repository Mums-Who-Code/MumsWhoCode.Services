// -----------------------------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// -----------------------------------------------------------------------

using System;
using Microsoft.EntityFrameworkCore;
using MumsWhoCode.Services.Api.Models.Users;

namespace MumsWhoCode.Services.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
        private static void SeedUsers(ModelBuilder modelBuilder)
        {
            var serviceAdminUser = new User
            {
                Id = Guid.Parse("ddfbc0ff-2de7-44bc-b4a9-39fe281836f9"),
                Name = "Admin"
            };

            modelBuilder.Entity<User>().HasData(serviceAdminUser);
        }
    }
}
