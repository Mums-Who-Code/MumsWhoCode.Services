// -----------------------------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// -----------------------------------------------------------------------

using Microsoft.EntityFrameworkCore;
using MumsWhoCode.Services.Api.Models.Participants;

namespace MumsWhoCode.Services.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
        DbSet<Participant> Participants { get; set; }
    }
}