using System;
using Hum.HumToonCore.Editor.Utils;
using UnityEditor;
using UnityEngine;

namespace Hum.HumToonCore.Editor.HeaderScopes.GI
{
    public class GIDrawer : HeaderScopeDrawerBase<GIPropertiesContainer>
    {
        public GIDrawer(GIPropertiesContainer propContainer, Func<GUIContent> headerStyleFunc, uint expandable)
            : base(propContainer, headerStyleFunc, expandable)
        {
        }

        protected override void DrawMain(MaterialEditor materialEditor)
        {
            var useMarCap = HumToonGUIUtils.DrawFloatToggleProperty(PropContainer.ReceiveGI, GIStyles.ReceiveGI);
            if (useMarCap)
            {
                using (new EditorGUI.IndentLevelScope())
                {
                    materialEditor.ShaderProperty(PropContainer.GIColorWeight, GIStyles.GIColorWeight);
                }
            }
        }
    }
}
