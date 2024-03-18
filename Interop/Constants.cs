using System;

namespace TesseractDotnetWrapper.Interop
{
    /// <summary>
    /// Description of Constants.
    /// </summary>
    internal static class Constants
    {
#if WINDOWS
        public const string LeptonicaDllName = "tesseract/win_x64/leptonica-1.84.1.dll";
        public const string TesseractDllName = "tesseract/win_x64/tesseract53.dll";
#elif MACOS
        public const string LeptonicaDllName = "tesseract/macos_aarch64/libleptonica.6.0.0.dylib";
        public const string TesseractDllName = "tesseract/macos_aarch64/libtesseract.5.3.4.dylib";
# else
        public const string LeptonicaDllName = "tesseract/linux_x64/libleptonica.6.0.0.dylib";
        public const string TesseractDllName = "tesseract/linux_x64/libtesseract.5.3.4.dylib";
#endif

        // tesseract uses an int to represent true false values.
        public const int TRUE = 1;
        public const int FALSE = 0;
    }
}
