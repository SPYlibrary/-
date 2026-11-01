namespace AiDevWorkstation.Core;

/// <summary>
/// Describes the baseline capabilities expected from the development workstation.
/// </summary>
public static class WorkstationInfo
{
    public static IReadOnlyList<string> RequiredCapabilities { get; } =
    [
        "Visual Studio",
        "Git and GitHub",
        "Automated tests",
        "GitHub Actions",
        "AI collaboration guidance"
    ];

    public static bool IsReady(IEnumerable<string> availableCapabilities)
    {
        ArgumentNullException.ThrowIfNull(availableCapabilities);

        var available = availableCapabilities.ToHashSet(StringComparer.OrdinalIgnoreCase);
        return RequiredCapabilities.All(available.Contains);
    }
}
