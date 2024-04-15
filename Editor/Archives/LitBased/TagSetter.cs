using UnityEngine;

namespace Hum.HumToonCore.Editor.Archives.LitBased
{
    public static class TagSetter
    {
        private const string RenderType = "RenderType";

        public static void Set(Material material, bool isOpaque, bool alphaClip)
        {
            // Clear override tag
            material.SetOverrideTag(RenderType, string.Empty); // TODO: 必要ないかも

            if (isOpaque)
            {
                material.SetOverrideTag(RenderType, alphaClip ? "TransparentCutout" : "Opaque");
            }
            else
            {
                material.SetOverrideTag(RenderType, "Transparent");
            }
        }
    }
}
