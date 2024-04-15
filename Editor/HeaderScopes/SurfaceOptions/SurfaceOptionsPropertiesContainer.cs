using UnityEditor;

namespace Hum.HumToonCore.Editor.HeaderScopes.SurfaceOptions
{
    public class SurfaceOptionsPropertiesContainer : IPropertiesContainer
    {
        public MaterialProperty SurfaceType;
        public MaterialProperty BlendMode;
        public MaterialProperty CullMode;
        public MaterialProperty AlphaClip;
        public MaterialProperty ReceiveShadows;
        public MaterialProperty Cutoff;
    }
}
