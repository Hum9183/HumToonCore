using UnityEditor;

namespace Hum.HumToonCore.Editor.Language
{
    public static class LanguageDrawer
    {
        public static void Draw()
        {
            HumToonLanguage.CurrentLang = (Language)DrawInternal(HumToonLanguage.CurrentLang);
        }

        private static int DrawInternal(Language currentLang)
        {
            var displayedOptions = new string[] { "English", "日本語", "简体中文" };
            int newValue = EditorGUILayout.Popup(LanguageStyles.Language, (int)currentLang, displayedOptions);
            return newValue;
        }
    }
}
