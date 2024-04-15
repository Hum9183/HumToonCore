using UnityEditor;

namespace Hum.HumToonCore.Editor.HeaderScopes
{
    public interface IHeaderScopeDrawer
    {
        void SetProperties(MaterialProperty[] materialProperties);
        void Draw(MaterialEditor materialEditor);
    }
}
