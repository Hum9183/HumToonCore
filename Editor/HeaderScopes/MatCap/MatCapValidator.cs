using Hum.HumToonCore.Editor.Utils;
using UnityEngine;
using UnityEngine.Rendering;
using P = Hum.HumToonCore.Editor.HeaderScopes.MatCap.MatCapPropertiesContainer;

namespace Hum.HumToonCore.Editor.HeaderScopes.MatCap
{
    public class MatCapValidator : IHeaderScopeValidator
    {
        private static readonly int IDUseMatCap = Shader.PropertyToID(nameof(P.UseMatCap).Prefix());
        private static readonly int IDMatCapMap = Shader.PropertyToID(nameof(P.MatCapMap).Prefix());
        private static readonly int IDMatCapMask = Shader.PropertyToID(nameof(P.MatCapMask).Prefix());

        public void Validate(Material material)
        {
            SetKeywords(material);
        }

        private void SetKeywords(Material material)
        {
            bool useMatCap = material.GetFloat(IDUseMatCap).ToBool();
            bool matCapMapExists = material.GetTexture(IDMatCapMap) is not null;
            CoreUtils.SetKeyword(material, MatCapKeywordNames._HT_USE_MAT_CAP, useMatCap && matCapMapExists);

            bool matCapMaskExists = material.GetTexture(IDMatCapMask) is not null;
            CoreUtils.SetKeyword(material, MatCapKeywordNames._HT_USE_MAT_CAP_MASK, useMatCap && matCapMapExists && matCapMaskExists);
        }
    }
}
