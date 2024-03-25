using System.Reflection;
using System.Runtime.InteropServices;

namespace TesseractCSharp.Interop
{
    /// <summary>
    /// Description of Constants.
    /// </summary>
    public static class NativeConstants
    {
        private static string BaseLibraryPath = string.Empty;
        private static bool NativeImported = false;
        private static readonly char sep = Path.DirectorySeparatorChar;

        public static void InitBaseLibraryPath(string baseLibraryPath)
        {
            BaseLibraryPath = baseLibraryPath + sep;
        }

        public static void InitNativeLoader()
        {
            if (NativeImported == false)
            {
                NativeLibrary.SetDllImportResolver(
                    typeof(NativeConstants).Assembly,
                    DllImportResolver
                );
                NativeImported = true;
            }
        }

        public static IntPtr DllImportResolver(
            string libraryName,
            Assembly assembly,
            DllImportSearchPath? searchPath
        )
        {
            string currentTesseractLibraryName = string.Empty;
            string currentLeptonicaLibraryName = string.Empty;

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                //windows
                currentTesseractLibraryName =
                    BaseLibraryPath + NativeConstants.TesseractWinX64DllName;
                currentLeptonicaLibraryName =
                    BaseLibraryPath + NativeConstants.LeptonicaWinX64DllName;
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                //macos
                currentTesseractLibraryName =
                    BaseLibraryPath + NativeConstants.TesseractMacosAArch64DllName;
                currentLeptonicaLibraryName =
                    BaseLibraryPath + NativeConstants.LeptonicaMacosAArch64DllName;
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                //linux
                currentTesseractLibraryName =
                    BaseLibraryPath + NativeConstants.TesseractLinuxX64DllName;
                currentLeptonicaLibraryName =
                    BaseLibraryPath + NativeConstants.LeptonicaLinuxX64DllName;
            }
            if (libraryName == "NativeTessApi")
            {
                return NativeLibrary.Load(currentTesseractLibraryName, assembly, searchPath);
            }
            else if (libraryName == "NativeLeptonicaApi")
            {
                return NativeLibrary.Load(currentLeptonicaLibraryName, assembly, searchPath);
            }

            // Otherwise, fallback to default import resolver.
            return IntPtr.Zero;
        }

        private static readonly string TesseractWinX64DllName =
            "tesseractLib" + sep + "win_x64" + sep + "tesseract53.dll";
        private static readonly string LeptonicaWinX64DllName =
            "tesseractLib" + sep + "win_x64" + sep + "leptonica-1.84.1.dll";

        private static readonly string TesseractMacosAArch64DllName =
            "tesseractLib" + sep + "macos_aarch64" + sep + "libtesseract.5.3.4.dylib";
        private static readonly string LeptonicaMacosAArch64DllName =
            "tesseractLib" + sep + "macos_aarch64" + sep + "libleptonica.6.0.0.dylib";

        private static readonly string TesseractLinuxX64DllName =
            "tesseractLib" + sep + "linux_x64" + sep + "libtesseract.so.5.3.4";
        private static readonly string LeptonicaLinuxX64DllName =
            "tesseractLib" + sep + "linux_x64" + sep + "libleptonica.so.6.0.0";

        // tesseract uses an int to represent true false values.
        public const int TRUE = 1;
        public const int FALSE = 0;
    }
}
