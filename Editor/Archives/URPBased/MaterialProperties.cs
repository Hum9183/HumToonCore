using System;
using System.Reflection;
using UnityEditor;

// using Unity.Rendering.Universal;

namespace Hum.HumToonCore.Editor.Archives.URPBased
{
    internal sealed class MaterialProperties
    {
        internal MaterialProperty SurfaceType;
        internal MaterialProperty BlendMode;
        // internal MaterialProperty PreserveSpec;
        internal MaterialProperty CullMode;
        internal MaterialProperty ZTest;
        internal MaterialProperty ZWrite;
        internal MaterialProperty AlphaClip;
        internal MaterialProperty AlphaCutoff;
        internal MaterialProperty CastShadows;
        internal MaterialProperty ReceiveShadows;
        internal MaterialProperty BaseMap;
        internal MaterialProperty BaseColor;
        internal MaterialProperty EmissionMap;
        internal MaterialProperty EmissionColor;
        internal MaterialProperty QueueOffset;
        internal MaterialProperty QueueControl;

        public void Set(MaterialProperty[] properties)
        {
            var fieldInfos = typeof(MaterialProperties).GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (var fieldInfo in fieldInfos)
            {
                string propName = $"_{fieldInfo.Name}";
                var prop = FindProperty(propName, properties, false);
                fieldInfo.SetValue(this, prop);
            }
        }

        private MaterialProperty FindProperty(string propertyName, MaterialProperty[] properties, bool propertyIsMandatory)
        {
            foreach (var prop in properties)
            {
                if (prop != null && prop.name.Equals(propertyName))
                    return prop;
            }

            if (propertyIsMandatory)
                throw new ArgumentException($"Could not find MaterialProperty: '{propertyName}', Num properties: {properties.Length.ToString()}");

            return null;
        }
    }
}
