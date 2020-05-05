using System.Reflection;
using Xam.Zero.ViewModels;
using Xamarin.Forms;

namespace Xam.Zero.Ioc
{
    internal static class ZeroIoc
    {
        public static IContainer Container { get; private set; }

        /// <summary>
        /// Register all content page
        /// </summary>
        public static void RegisterPages(Assembly entryAssembly)
        {
            ZeroApp.RegisterMany(entryAssembly,type => type.IsClass && !type.IsAbstract && type.IsSubclassOf(typeof(ContentPage)));
        }

        /// <summary>
        /// Register all viewmodel that extend ZeroBaseModel
        /// </summary>
        public static void RegisterViewModels(Assembly entryAssembly)
        {
            ZeroApp.RegisterMany(entryAssembly,type => type.IsClass && !type.IsAbstract && type.IsSubclassOf(typeof(ZeroBaseModel)));
        }
        
        

        internal static void UseContainer(IContainer container)
        {
            Container = container;
        }
    }
}