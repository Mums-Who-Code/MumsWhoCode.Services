// -----------------------------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// -----------------------------------------------------------------------

using System.Threading.Tasks;

namespace MumsWhoCode.Services.Tests.Acceptance.Brokers
{
    public partial class MumsWhoCodeApiBroker
    {
        private const string HomeRelativeUrl = "api/home";

        public async ValueTask<string> GetHomeMessageAsync() =>
            await this.apiFactoryClient.GetContentStringAsync(HomeRelativeUrl);
    }
}
