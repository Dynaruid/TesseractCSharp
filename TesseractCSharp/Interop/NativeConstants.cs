using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace TesseractCSharp.Interop
{
    /// <summary>
    /// Description of Constants.
    /// </summary>
    public static class NativeConstants
    {
        public static bool NativeImported = false;

        public static void InitNativeLoader()
        {
            if (NativeImported == false)
            {
                NativeLibrary.SetDllImportResolver(typeof(NativeConstants).Assembly, DllImportResolver);
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
                currentTesseractLibraryName = NativeConstants.TesseractWinX64DllName;
                currentLeptonicaLibraryName = NativeConstants.LeptonicaWinX64DllName;

            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                //macos
                currentTesseractLibraryName = NativeConstants.TesseractMacosAArch64DllName;
                currentLeptonicaLibraryName = NativeConstants.LeptonicaMacosAArch64DllName;
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                //linux
                currentTesseractLibraryName = NativeConstants.TesseractLinuxX64DllName;
                currentLeptonicaLibraryName = NativeConstants.LeptonicaLinuxX64DllName;
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

        public const string TesseractWinX64DllName = "tesseract/win_x64/tesseract53.dll";
        public const string LeptonicaWinX64DllName = "tesseract/win_x64/leptonica-1.84.1.dll";

        public const string TesseractMacosAArch64DllName =
                    "tesseract/macos_aarch64/libtesseract.5.3.4.dylib";
        public const string LeptonicaMacosAArch64DllName =
            "tesseract/macos_aarch64/libleptonica.6.0.0.dylib";

        public const string TesseractLinuxX64DllName = "tesseract/linux_x64/libtesseract.so.5.3.4";
        public const string LeptonicaLinuxX64DllName = "tesseract/linux_x64/libleptonica.so.6.0.0";



        // tesseract uses an int to represent true false values.
        public const int TRUE = 1;
        public const int FALSE = 0;
    }
}
