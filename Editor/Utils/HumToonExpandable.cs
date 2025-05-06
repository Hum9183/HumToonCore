using System;

namespace Hum.HumToonCore.Editor.Utils
{
    /// <summary>
    /// Flags for the foldouts used in the Hum Toon GUI.
    /// </summary>
    [Flags]
    public enum Expandable
    {
        SurfaceOptions = 1 << 0,
        Base = 1 << 1,
        PbrParameters = 1 << 2,
        Normal = 1 << 3,
        Shade = 1 << 4,
        RimLight = 1 << 5,
        Emission = 1 << 6,
        MatCap = 1 << 7,
        DirectLighting = 1 << 8,
        IndirectLighting = 1 << 9,
    }
}
