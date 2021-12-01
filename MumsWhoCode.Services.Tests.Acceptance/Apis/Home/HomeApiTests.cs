// -----------------------------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// -----------------------------------------------------------------------

using MumsWhoCode.Services.Tests.Acceptance.Brokers;
using Xunit;

namespace MumsWhoCode.Services.Tests.Acceptance.Apis.Home
{
    [Collection(nameof(ApiTestCollection))]
    public partial class HomeApiTests
    {
        private readonly MumsWhoCodeApiBroker mumsWhoCodeApiBroker;

        public HomeApiTests(MumsWhoCodeApiBroker mumsWhoCodeApiBroker) =>
            this.mumsWhoCodeApiBroker = mumsWhoCodeApiBroker;
    }
}
