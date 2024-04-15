using System;
using Hum.HumToonCore.Editor.Utils;

namespace Hum.HumToonCore.Editor.Language
{
    public static class LanguageSelector
    {
        public static string Select(string[] texts)
        {
            return SelectInternal(texts, HumToonLanguage.DefaultLang, HumToonLanguage.CurrentLang);
        }

        private static string SelectInternal(string[] texts, Language defaultLang, Language currentLang)
        {
            string result = string.Empty;

            if (texts.Length != Enum.GetNames(typeof(Language)).Length)
                throw new LanguageTextsOutOfRangeException();

            if (texts.TryGetValue((int)defaultLang, out string defaultLangText))
            {
                if (string.IsNullOrEmpty(defaultLangText) is false)
                    result = defaultLangText;
            }

            if (texts.TryGetValue((int)currentLang, out string currentLangText))
            {
                if (string.IsNullOrEmpty(currentLangText) is false)
                    result = currentLangText;
            }

            return result;
        }
    }

    public class LanguageTextsOutOfRangeException : Exception
    {
    }
}
