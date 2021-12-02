// -----------------------------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// -----------------------------------------------------------------------

using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace MumsWhoCode.Services.Tests.Acceptance.Apis.Home
{
    public partial class HomeApiTests
    {
        [Fact]
        public async Task ShouldReturnHomeMessageAsync()
        {
            // given
            string expectedHomeMessage =
                "Check whether System or API End points are responding properly or not";

            // when
            string actualHomeMessage =
               await this.mumsWhoCodeApiBroker.GetHomeMessageAsync();

            // then
            actualHomeMessage.Should().BeEquivalentTo(expectedHomeMessage);
        }
    }
}
