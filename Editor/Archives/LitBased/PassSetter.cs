using UnityEngine;

namespace Hum.HumToonCore.Editor.Archives.LitBased
{
    public static class PassSetter
    {
        public static void Set(Material material, bool isOpaque)
        {
            // Transparent
            material.SetShaderPassEnabled("ShadowCaster", isOpaque);

            // Depth
            material.SetShaderPassEnabled("DepthOnly", isOpaque);
        }
    }
}
