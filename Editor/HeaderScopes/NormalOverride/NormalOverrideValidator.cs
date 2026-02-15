using Hum.HumToonCore.Editor.Utils;
using UnityEngine;
using UnityEngine.Rendering;
using P = Hum.HumToonCore.Editor.HeaderScopes.NormalOverride.NormalOverridePropertiesContainer;

namespace Hum.HumToonCore.Editor.HeaderScopes.NormalOverride
{
    public class NormalOverrideValidator : IHeaderScopeValidator
    {
        private static readonly int IDUseNormalOverride = Shader.PropertyToID(nameof(P.UseNormalOverride).Prefix());
        private static readonly int IDNormalOverrideMask = Shader.PropertyToID(nameof(P.NormalOverrideMask).Prefix());

        public void Validate(Material material)
        {
            SetKeywords(material);
        }

        private void SetKeywords(Material material)
        {
            bool useNormalOverride = material.GetFloat(IDUseNormalOverride).ToBool();
            bool normalOverrideMaskExists = material.GetTexture(IDNormalOverrideMask) is not null;
            CoreUtils.SetKeyword(material, NormalOverrideKeywordNames._HT_USE_NORMAL_OVERRIDE, useNormalOverride && normalOverrideMaskExists);
        }
    }
}
