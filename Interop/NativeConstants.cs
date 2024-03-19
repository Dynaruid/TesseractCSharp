using System.Runtime.InteropServices;

namespace TesseractDotnetWrapper.Interop
{
    /// <summary>
    /// Description of Constants.
    /// </summary>
    public static class NativeConstants
    {
        public const string LeptonicaWinX64DllName = "tesseract/win_x64/leptonica-1.84.1.dll";
        public const string TesseractWinX64DllName = "tesseract/win_x64/tesseract53.dll";

        public const string LeptonicaMacosAArch64DllName =
            "tesseract/macos_aarch64/libleptonica.6.0.0";
        public const string TesseractMacosAArch64DllName =
            "tesseract/macos_aarch64/libtesseract.5.3.4";
        public const string LeptonicaLinuxX64DllName = "tesseract/win_x64/leptonica-1.84.1.dll";
        public const string TesseractLinuxX64DllName = "tesseract/win_x64/tesseract53.dll";

        /*
        public const string LeptonicaDllName = "tesseract/macos_aarch64/libleptonica.6.0.0.dylib";
        public const string TesseractDllName = "tesseract/macos_aarch64/libtesseract.5.3.4.dylib";
        */
        /*
        public const string LeptonicaDllName = "tesseract/win_x64/leptonica-1.84.1.dll";
        public const string TesseractDllName = "tesseract/win_x64/tesseract53.dll";
        */


        /*
        static Constants()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                LeptonicaDllName = "tesseract/macos_aarch64/libleptonica.6.0.0.dylib";
                TesseractDllName = "tesseract/macos_aarch64/libtesseract.5.3.4.dylib";
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                LeptonicaDllName = "tesseract/macos_aarch64/libleptonica.6.0.0.dylib";
                TesseractDllName = "tesseract/macos_aarch64/libtesseract.5.3.4.dylib";
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                LeptonicaDllName = "tesseract/macos_aarch64/libleptonica.6.0.0.dylib";
                TesseractDllName = "tesseract/macos_aarch64/libtesseract.5.3.4.dylib";
            }
        }
        */



        // tesseract uses an int to represent true false values.
        public const int TRUE = 1;
        public const int FALSE = 0;
    }
}
