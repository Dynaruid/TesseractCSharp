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
        public const string LeptonicaLinuxX64DllName = "tesseract/linux_x64/libleptonica.so.6.0.0";
        public const string TesseractLinuxX64DllName = "tesseract/linux_x64/libtesseract.so.5.3.4";


        // tesseract uses an int to represent true false values.
        public const int TRUE = 1;
        public const int FALSE = 0;
    }
}
