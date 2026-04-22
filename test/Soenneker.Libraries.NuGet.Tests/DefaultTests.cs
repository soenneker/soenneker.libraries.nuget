using Soenneker.Tests.HostedUnit;

namespace Soenneker.Libraries.NuGet.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class DefaultTests : HostedUnitTest
{
    public DefaultTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
