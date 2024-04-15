using Hum.HumToonCore.Editor.HeaderScopes;
using UnityEditor;

namespace Hum.HumToonCore.Editor.Archives.LitBased
{
    public class LitDetailPropertiesContainer : IPropertiesContainer
    {
        public MaterialProperty DetailMask;
        public MaterialProperty DetailAlbedoMapScale;
        public MaterialProperty DetailAlbedoMap;
        public MaterialProperty DetailNormalMapScale;
        public MaterialProperty DetailNormalMap;

        public void Set(MaterialProperty[] materialProperties)
        {
            PropertySetter.Set(this, materialProperties);
        }
    }
}
