// -----------------------------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// -----------------------------------------------------------------------

using System;
using MumsWhoCode.Services.Api.Models.Users;

namespace MumsWhoCode.Services.Api.Models.Participants
{
    public class Participant
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public enum Gender
        { 
            Female,
            Male,
            Other 
        }
        public string mobile { get; set; }
        public string email { get; set; }
        public enum TimeZone
        {
            CST,
            EST,
            IST,
            PST,
            Other
        }
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset UpdatedDate { get; set; }

        public Guid CreatedBy { get; set; }
        public User CreatedByUser { get; set; }

        public Guid UpdatedBy { get; set; }
        public User UpdatedByUser { get; set; }

    }
}