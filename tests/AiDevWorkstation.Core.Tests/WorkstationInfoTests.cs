using AiDevWorkstation.Core;

namespace AiDevWorkstation.Core.Tests;

public class WorkstationInfoTests
{
    [Fact]
    public void IsReady_ReturnsTrue_WhenAllCapabilitiesAreAvailable()
    {
        var result = WorkstationInfo.IsReady(WorkstationInfo.RequiredCapabilities);

        Assert.True(result);
    }

    [Fact]
    public void IsReady_ReturnsFalse_WhenACapabilityIsMissing()
    {
        var available = WorkstationInfo.RequiredCapabilities.Skip(1);

        var result = WorkstationInfo.IsReady(available);

        Assert.False(result);
    }
}
