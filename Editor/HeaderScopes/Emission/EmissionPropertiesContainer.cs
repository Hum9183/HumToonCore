using UnityEditor;
// ReSharper disable UnassignedField.Global

namespace Hum.HumToonCore.Editor.HeaderScopes.Emission
{
    public class EmissionPropertiesContainer : IPropertiesContainer
    {
        public MaterialProperty UseEmission;
        public MaterialProperty EmissionMap;
        public MaterialProperty EmissionColor;
        public MaterialProperty EmissionIntensity;
        public MaterialProperty EmissionFactorR;
        public MaterialProperty EmissionFactorG;
        public MaterialProperty EmissionFactorB;
        public MaterialProperty OverrideEmissionColor;
    }
}
