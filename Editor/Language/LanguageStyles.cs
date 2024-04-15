using UnityEditor;
using UnityEngine;

namespace Hum.HumToonCore.Editor.Language
{
    public static class LanguageStyles
    {
        public static GUIContent Language =>
            EditorGUIUtility.TrTextContent(
                text: $"{LanguageSelector.Select(new string[] { "Language", "言語", "语言" })}");
    }
}
