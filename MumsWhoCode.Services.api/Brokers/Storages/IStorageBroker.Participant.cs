// -----------------------------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// -----------------------------------------------------------------------

using System.Threading.Tasks;
using MumsWhoCode.Services.Api.Models.Participants;

namespace MumsWhoCode.Services.Api.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<Participant> InsertCategoryAsync(Participant participant);
    }
}
