﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Resources {
    using System;
    
    
    /// <summary>
    ///   Класс ресурса со строгой типизацией для поиска локализованных строк и т.д.
    /// </summary>
    // Этот класс создан автоматически классом StronglyTypedResourceBuilder
    // с помощью такого средства, как ResGen или Visual Studio.
    // Чтобы добавить или удалить член, измените файл .ResX и снова запустите ResGen
    // с параметром /str или перестройте свой проект VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Pager {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Pager() {
        }
        
        /// <summary>
        ///   Возвращает кэшированный экземпляр ResourceManager, использованный этим классом.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ARoomInterior.Resources.EJ.Pager.Pager", typeof(Pager).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Перезаписывает свойство CurrentUICulture текущего потока для всех
        ///   обращений к ресурсу с помощью этого класса ресурса со строгой типизацией.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на All.
        /// </summary>
        public static string All {
            get {
                return ResourceManager.GetString("All", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на {0} of {1} pages.
        /// </summary>
        public static string currentPageInfo {
            get {
                return ResourceManager.GetString("currentPageInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на To the first page.
        /// </summary>
        public static string firstPageTooltip {
            get {
                return ResourceManager.GetString("firstPageTooltip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на To the last page.
        /// </summary>
        public static string lastPageTooltip {
            get {
                return ResourceManager.GetString("lastPageTooltip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на To the next pager.
        /// </summary>
        public static string nextPagerTooltip {
            get {
                return ResourceManager.GetString("nextPagerTooltip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на To the next page.
        /// </summary>
        public static string nextPageTooltip {
            get {
                return ResourceManager.GetString("nextPageTooltip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Items.
        /// </summary>
        public static string pagerAllDropDown {
            get {
                return ResourceManager.GetString("pagerAllDropDown", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Items per page.
        /// </summary>
        public static string pagerDropDown {
            get {
                return ResourceManager.GetString("pagerDropDown", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на To the previous pager.
        /// </summary>
        public static string previousPagerTooltip {
            get {
                return ResourceManager.GetString("previousPagerTooltip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Back to the last page.
        /// </summary>
        public static string previousPageTooltip {
            get {
                return ResourceManager.GetString("previousPageTooltip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на ({0} elements).
        /// </summary>
        public static string totalItemsInfo {
            get {
                return ResourceManager.GetString("totalItemsInfo", resourceCulture);
            }
        }
    }
}
