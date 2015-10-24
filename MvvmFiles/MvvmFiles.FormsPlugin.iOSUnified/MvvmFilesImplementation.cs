using MvvmFiles.FormsPlugin.Abstractions;
using System;
using Xamarin.Forms;
using MvvmFiles.FormsPlugin.iOSUnified;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(MvvmFiles.FormsPlugin.Abstractions.MvvmFilesControl), typeof(MvvmFilesRenderer))]
namespace MvvmFiles.FormsPlugin.iOSUnified
{
    /// <summary>
    /// MvvmFiles Renderer
    /// </summary>
    public class MvvmFilesRenderer //: TRender (replace with renderer type
    {
        /// <summary>
        /// Used for registration with dependency service
        /// </summary>
        public static void Init()
        {
        }
    }
}
