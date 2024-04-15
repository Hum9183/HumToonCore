using Hum.HumToonCore.Editor.Utils;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using P = Hum.HumToonCore.Editor.HeaderScopes.Normal.NormalPropertiesContainer;

namespace Hum.HumToonCore.Editor.HeaderScopes.Normal
{
    public class NormalValidator : IHeaderScopeValidator
    {
        private static readonly int IDBumpMap = Shader.PropertyToID($"{nameof(P.BumpMap).Prefix()}");

        public void Validate(Material material)
        {
            SetKeywords(material);
        }

        private static void SetKeywords(Material material)
        {
            bool normalMapExists = material.GetTexture(IDBumpMap) is not null;
            CoreUtils.SetKeyword(material, ShaderKeywordStrings._NORMALMAP, normalMapExists);
        }
    }
}
