using UnityEditor;
// ReSharper disable UnassignedField.Global

namespace Hum.HumToonCore.Editor.HeaderScopes.IndirectLighting
{
    public class IndirectLightingPropertiesContainer : IPropertiesContainer
    {
        public MaterialProperty IndirectLightIntensity;
        public MaterialProperty ReceiveIndirectDiffuse;
        public MaterialProperty IndirectDiffuseIntensity;
        public MaterialProperty ReceiveIndirectSpecular;
        public MaterialProperty IndirectSpecularIntensity;
        public MaterialProperty ReceiveSsao;
        public MaterialProperty SsaoIntensity;
        public MaterialProperty UseSsaoMask;
        public MaterialProperty SsaoMask;
        public MaterialProperty SsaoMaskIntensity;
    }
}
