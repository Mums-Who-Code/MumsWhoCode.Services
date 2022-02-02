// -----------------------------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// -----------------------------------------------------------------------

using Microsoft.EntityFrameworkCore;
using MumsWhoCode.Services.Api.Models.Participants;

namespace MumsWhoCode.Services.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
        private static void SetParticipantReferences(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Participant>()
                .HasOne(participant => participant.CreatedByUser)
                .WithMany(user => user.CreatedParticipants)
                .HasForeignKey(participant => participant.CreatedBy)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Participant>()
                .HasOne(participant => participant.UpdatedByUser)
                .WithMany(user => user.UpdatedParticipants)
                .HasForeignKey(participant => participant.UpdatedBy)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}