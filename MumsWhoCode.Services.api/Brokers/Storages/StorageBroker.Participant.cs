// -----------------------------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// -----------------------------------------------------------------------

using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using MumsWhoCode.Services.Api.Models.Participants;

namespace MumsWhoCode.Services.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
        DbSet<Participant> Participants { get; set; }

        public async ValueTask<Participant> InsertParticipantAsync(Participant participant)
        {
            using var broker = new StorageBroker(this.configuration);

            EntityEntry<Participant> entityEntry =
                await broker.Participants.AddAsync(participant);

            await broker.SaveChangesAsync();

            return entityEntry.Entity;
        }
    }
}
