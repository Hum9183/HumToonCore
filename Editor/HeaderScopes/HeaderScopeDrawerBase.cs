using System;
using UnityEditor;
using UnityEditor.Rendering;
using UnityEngine;

namespace Hum.HumToonCore.Editor.HeaderScopes
{
    public abstract class HeaderScopeDrawerBase<T> : IHeaderScopeDrawer
        where T : IPropertiesContainer
    {
        protected readonly T PropContainer;
        private readonly Func<GUIContent> _headerStyleFunc;
        private readonly uint _expandable;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="propContainer"></param>
        /// <param name="headerStyleFunc">GUIContentを取得する関数</param>
        /// <param name="expandable"></param>
        protected HeaderScopeDrawerBase(T propContainer, Func<GUIContent> headerStyleFunc, uint expandable)
        {
            PropContainer = propContainer;
            _headerStyleFunc = headerStyleFunc;
            _expandable = expandable;
        }

        public void SetProperties(MaterialProperty[] materialProperties)
        {
            PropertySetter.Set(PropContainer, materialProperties);
        }

        public void Draw(MaterialEditor materialEditor)
        {
            using var materialHeaderScope = DrawHeader(materialEditor);
            if (materialHeaderScope.expanded is false)
                return;

            DrawMain(materialEditor);
        }

        protected abstract void DrawMain(MaterialEditor materialEditor);

        private MaterialHeaderScope DrawHeader(MaterialEditor materialEditor)
        {
            return new MaterialHeaderScope(_headerStyleFunc?.Invoke(), _expandable, materialEditor);
        }
    }
}
