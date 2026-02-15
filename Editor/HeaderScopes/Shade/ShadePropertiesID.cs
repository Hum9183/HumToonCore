using Hum.HumToonCore.Editor.Utils;
using UnityEngine;
using P = Hum.HumToonCore.Editor.HeaderScopes.Shade.ShadePropertiesContainer;

namespace Hum.HumToonCore.Editor.HeaderScopes.Shade
{
    public static class ShadePropertiesID
    {
        private static int ToID(string propNameWithoutPrefix)
        {
            return Shader.PropertyToID(propNameWithoutPrefix.Prefix());
        }
    }

}
