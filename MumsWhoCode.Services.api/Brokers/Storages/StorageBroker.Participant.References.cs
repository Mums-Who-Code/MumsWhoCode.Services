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
                .HasOne(Participant => Participant.CreatedByUser)
                .WithMany(user => user.CreatedParticipants)
                .HasForeignKey(category => category.CreatedBy)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Participant>()
                .HasOne(Participant => Participant.UpdatedByUser)
                .WithMany(user => user.UpdatedParticipants)
                .HasForeignKey(category => category.UpdatedBy)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}


