﻿// -----------------------------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// -----------------------------------------------------------------------

using MyPortfolio.Services.Tests.Acceptance.Brokers;
using Xunit;

namespace MyPortfolio.Services.Tests.Acceptance.Apis.Home
{
    [Collection(nameof(ApiTestCollection))]
    public partial class HomeApiTests
    {
        private readonly MyPortfolioApiBroker myportfolioApiBroker;

        public HomeApiTests(MyPortfolioApiBroker myportfolioApiBroker) =>
            this.myportfolioApiBroker = myportfolioApiBroker;
    }
}
