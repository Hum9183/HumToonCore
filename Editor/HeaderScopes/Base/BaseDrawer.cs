using System;
using UnityEditor;
using UnityEngine;

namespace Hum.HumToonCore.Editor.HeaderScopes.Base
{
    public class BaseDrawer : HeaderScopeDrawerBase<BasePropertiesContainer>
    {
        public BaseDrawer(BasePropertiesContainer propContainer, Func<GUIContent> headerStyleFunc, uint expandable)
            : base(propContainer, headerStyleFunc, expandable)
        {
        }

        protected override void DrawMain(MaterialEditor materialEditor)
        {
            materialEditor.TexturePropertySingleLine(BaseStyles.BaseMap, PropContainer.BaseMap, PropContainer.BaseColor);
            materialEditor.TextureScaleOffsetProperty(PropContainer.BaseMap);
        }
    }
}
