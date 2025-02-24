using UnityEditor;
// ReSharper disable UnassignedField.Global

namespace Hum.HumToonCore.Editor.HeaderScopes.DirectLighting
{
    public class DirectLightingPropertiesContainer : IPropertiesContainer
    {
        public MaterialProperty DirectLightIntensity;
        public MaterialProperty MainLightIntensity;
        public MaterialProperty ReceiveMainLightDiffuse;
        public MaterialProperty MainLightDiffuseIntensity;
        public MaterialProperty ReceiveMainLightSpecular;
        public MaterialProperty MainLightSpecularIntensity;
        public MaterialProperty AdditionalLightsIntensity;
        public MaterialProperty ReceiveAdditionalLightsDiffuse;
        public MaterialProperty AdditionalLightsDiffuseIntensity;
        public MaterialProperty ReceiveAdditionalLightsSpecular;
        public MaterialProperty AdditionalLightsSpecularIntensity;
    }
}
