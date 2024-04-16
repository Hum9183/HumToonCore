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
            bool expanded = DrawHeader(materialEditor);
            if (expanded is false)
                return;

            DrawMain(materialEditor);
        }

        protected abstract void DrawMain(MaterialEditor materialEditor);

        /// <returns>ヘッダーが広がっているかどうか</returns>
        private bool DrawHeader(MaterialEditor materialEditor)
        {
            using var header = new MaterialHeaderScope(_headerStyleFunc?.Invoke(), _expandable, materialEditor);
            return header.expanded;
        }
    }
}
