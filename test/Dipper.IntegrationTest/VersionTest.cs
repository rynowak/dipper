using System;
using System.Threading.Tasks;
using Xunit;

namespace Dipper.IntegrationTest
{
    public class VersionTest
    {
        [Fact]
        public async Task CanExecuteVersionOption()
        {
            var result = await Program.Main(new[]{ "--version" });
            Assert.Equal(0, result);
        }
    }
}
