using Hum.HumToonCore.Editor.Utils;
using UnityEngine;

namespace Hum.HumToonCore.Editor.Archives.LitBased
{
    public static class FloatSetter
    {
        public static void Set(Material material, bool isOpaque, bool alphaClip)
        {
            material.SetFloat(HumToonPropertyNames.AlphaToMask, alphaClip.ToFloat());

            material.SetFloat(HumToonPropertyNames.ZWrite, isOpaque.ToFloat());
        }
    }
}
