namespace LabApi.Loader.Features.Plugins.Enums;

/// <summary>
/// Represents load priorities for <see cref="Plugin"/>s.
/// </summary>
public enum LoadPriority : byte
{
    /// <summary>
    /// These plugins are loaded first.
    /// <para>We recommend using it in plugins which may be used as dependencies.</para>
    /// </summary>
    Highest = 64,

    /// <summary>
    /// These are high priority plugins, a middle ground between <see cref="Highest"/> and <see cref="Medium"/>.
    /// <para>We recommend using it in plugins which may be used as dependencies, or <see cref="Highest"/> as an alternative.</para>
    /// </summary>
    High = 96,

    /// <summary>
    /// The default value for plugins.
    /// </summary>
    Medium = 128,

    /// <summary>
    /// These are low priority plugins, a middle ground between <see cref="Medium"/> and <see cref="Lowest"/>.
    /// <para>We recommend using it in plugins which require plugins as dependencies, or <see cref="Lowest"/> as an alternative.</para>
    /// </summary>
    Low = 160,

    /// <summary>
    /// These plugins are loaded last.
    /// <para>We recommend using it in plugins which require plugins as dependencies.</para>
    /// </summary>
    Lowest = 192
}