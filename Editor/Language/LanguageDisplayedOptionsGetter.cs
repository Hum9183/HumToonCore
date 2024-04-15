using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Hum.HumToonCore.Editor.Utils;

namespace Hum.HumToonCore.Editor.Language
{
    public static class LanguageDisplayedOptionsGetter
    {
        public static string[] Get<T>(Language currentLang)
            where T: Enum
        {
            // Ref: https://web.archive.org/web/20181119155348/http://www.distribucon.com/blog/GettingMembersOfAnEnumViaReflection.aspx
            var enumFields = typeof(T).GetFields(BindingFlags.Public | BindingFlags.Static);

            var currentLangAttrs = new List<DisplayNameLanguageAttributeBase>();
            foreach (var field in enumFields)
            {
                var existingLangAttrs = Attribute.GetCustomAttributes(field).ToList().OfType<DisplayNameLanguageAttributeBase>();
                var missingLangAttrs = CreateMissingLanguageAttributes(field);
                var allLangAttrs = existingLangAttrs.Concat(missingLangAttrs);
                var currentLangAttr = GetCurrentLangAttribute(allLangAttrs, currentLang);
                currentLangAttrs.Add(currentLangAttr);
            }

            var displayedOptions = currentLangAttrs
                .Select(x => x.DisplayName)
                .ToArray();

            return displayedOptions;
        }

        /// <summary>
        /// 付与されていない言語アトリビュートを生成する
        /// </summary>
        private static IEnumerable<DisplayNameLanguageAttributeBase> CreateMissingLanguageAttributes(FieldInfo field)
        {
            // NOTE:
            // アトリビュートが付与されていない場合は、その分インスタンスを生成する。
            // インスタンス生成時の引数(ディスプレイ名)はフィールド名(Enumの項目名)
            return HumToonUtils.GetSubclasses<DisplayNameLanguageAttributeBase>()
                .Where(x => field.IsDefined(x) is false)
                .Select(x => Activator.CreateInstance(x, field.Name) as DisplayNameLanguageAttributeBase);
        }

        /// <summary>
        /// 現在の言語のアトリビュートを取得する
        /// </summary>
        private static DisplayNameLanguageAttributeBase GetCurrentLangAttribute(IEnumerable<DisplayNameLanguageAttributeBase> langAttrs, Language currentLang)
        {
            return langAttrs.FirstOrDefault(x => x.Enum == currentLang);
        }
    }
}
