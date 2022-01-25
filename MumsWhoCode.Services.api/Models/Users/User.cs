// -----------------------------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using MumsWhoCode.Services.Api.Models.Participants;
using Newtonsoft.Json;

namespace MumsWhoCode.Services.Api.Models.Users
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        [JsonIgnore]
        public IEnumerable<Participant> CreatedParticipants { get; set; }

        [JsonIgnore]
        public IEnumerable<Participant> UpdatedParticipants { get; set; }
    }
}
