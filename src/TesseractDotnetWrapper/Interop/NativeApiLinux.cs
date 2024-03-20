using System;
using System.Runtime.InteropServices;

namespace TesseractDotnetWrapper.Interop
{
    /// <summary>
    /// The exported tesseract api signatures.
    /// </summary>
    /// <remarks>
    /// Please note this is only public for technical reasons (you can't proxy a internal interface).
    /// It should be considered an internal interface and is NOT part of the public api and may have
    /// breaking changes between releases.
    /// </remarks>
    ///

    public class NativeTessApiLinux : INativeTessApi
    {
        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessBaseAPIGetComponentImages"
        )]
        public static extern IntPtr NativeBaseAPIGetComponentImages(
            HandleRef handle,
            PageIteratorLevel level,
            int text_only,
            IntPtr pixa,
            IntPtr blockids
        );

        public IntPtr BaseAPIGetComponentImages(
            HandleRef handle,
            PageIteratorLevel level,
            int text_only,
            IntPtr pixa,
            IntPtr blockids
        )
        {
            return NativeBaseAPIGetComponentImages(handle, level, text_only, pixa, blockids);
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessBaseAPIAnalyseLayout"
        )]
        public static extern IntPtr NativeBaseAPIAnalyseLayout(HandleRef handle);

        public IntPtr BaseAPIAnalyseLayout(HandleRef handle)
        {
            return NativeBaseAPIAnalyseLayout(handle);
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessBaseAPIClear"
        )]
        public static extern void NativeBaseAPIClear(HandleRef handle);

        public void BaseAPIClear(HandleRef handle)
        {
            NativeBaseAPIClear(handle);
        }

        /// <summary>/// Creates a new BaseAPI instance/// </summary>/// <returns></returns>
        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessBaseAPICreate"
        )]
        public static extern IntPtr NativeBaseApiCreate();

        public IntPtr BaseApiCreate()
        {
            return NativeBaseApiCreate();
        }

        // Base API/// <summary>/// Deletes a base api instance./// </summary>/// <returns></returns>
        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessBaseAPIDelete"
        )]
        public static extern void NativeBaseApiDelete(HandleRef ptr);

        public void BaseApiDelete(HandleRef ptr)
        {
            NativeBaseApiDelete(ptr);
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessBaseAPIDetectOrientationScript"
        )]
        public static extern int NativeTessBaseAPIDetectOrientationScript(
            HandleRef handle,
            out int orient_deg,
            out float orient_conf,
            out IntPtr script_name,
            out float script_conf
        );

        public int TessBaseAPIDetectOrientationScript(
            HandleRef handle,
            out int orient_deg,
            out float orient_conf,
            out IntPtr script_name,
            out float script_conf
        )
        {
            return NativeTessBaseAPIDetectOrientationScript(
                handle,
                out orient_deg,
                out orient_conf,
                out script_name,
                out script_conf
            );
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessBaseAPIGetBoolVariable"
        )]
        public static extern int NativeBaseApiGetBoolVariable(
            HandleRef handle,
            string name,
            out int value
        );

        public int BaseApiGetBoolVariable(HandleRef handle, string name, out int value)
        {
            return NativeBaseApiGetBoolVariable(handle, name, out value);
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessBaseAPIGetDoubleVariable"
        )]
        public static extern int NativeBaseApiGetDoubleVariable(
            HandleRef handle,
            string name,
            out double value
        );

        public int BaseApiGetDoubleVariable(HandleRef handle, string name, out double value)
        {
            return NativeBaseApiGetDoubleVariable(handle, name, out value);
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessBaseAPIGetHOCRText"
        )]
        public static extern IntPtr NativeBaseApiGetHOCRTextInternal(HandleRef handle, int pageNum);

        public IntPtr BaseApiGetHOCRTextInternal(HandleRef handle, int pageNum)
        {
            return NativeBaseApiGetHOCRTextInternal(handle, pageNum);
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessBaseAPIGetAltoText"
        )]
        public static extern IntPtr NativeBaseApiGetAltoTextInternal(HandleRef handle, int pageNum);

        public IntPtr BaseApiGetAltoTextInternal(HandleRef handle, int pageNum)
        {
            return NativeBaseApiGetAltoTextInternal(handle, pageNum);
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessBaseAPIGetTsvText"
        )]
        public static extern IntPtr NativeBaseApiGetTsvTextInternal(HandleRef handle, int pageNum);

        public IntPtr BaseApiGetTsvTextInternal(HandleRef handle, int pageNum)
        {
            return NativeBaseApiGetTsvTextInternal(handle, pageNum);
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessBaseAPIGetBoxText"
        )]
        public static extern IntPtr NativeBaseApiGetBoxTextInternal(HandleRef handle, int pageNum);

        public IntPtr BaseApiGetBoxTextInternal(HandleRef handle, int pageNum)
        {
            return NativeBaseApiGetBoxTextInternal(handle, pageNum);
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessBaseAPIGetLSTMBoxText"
        )]
        public static extern IntPtr NativeBaseApiGetLSTMBoxTextInternal(
            HandleRef handle,
            int pageNum
        );

        public IntPtr BaseApiGetLSTMBoxTextInternal(HandleRef handle, int pageNum)
        {
            return NativeBaseApiGetLSTMBoxTextInternal(handle, pageNum);
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessBaseAPIGetWordStrBoxText"
        )]
        public static extern IntPtr NativeBaseApiGetWordStrBoxTextInternal(
            HandleRef handle,
            int pageNum
        );

        public IntPtr BaseApiGetWordStrBoxTextInternal(HandleRef handle, int pageNum)
        {
            return NativeBaseApiGetWordStrBoxTextInternal(handle, pageNum);
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessBaseAPIGetUNLVText"
        )]
        public static extern IntPtr NativeBaseApiGetUNLVTextInternal(HandleRef handle);

        public IntPtr BaseApiGetUNLVTextInternal(HandleRef handle)
        {
            return NativeBaseApiGetUNLVTextInternal(handle);
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessBaseAPIGetIntVariable"
        )]
        public static extern int NativeBaseApiGetIntVariable(
            HandleRef handle,
            string name,
            out int value
        );

        public int BaseApiGetIntVariable(HandleRef handle, string name, out int value)
        {
            return NativeBaseApiGetIntVariable(handle, name, out value);
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessBaseAPIGetIterator"
        )]
        public static extern IntPtr NativeBaseApiGetIterator(HandleRef handle);

        public IntPtr BaseApiGetIterator(HandleRef handle)
        {
            return NativeBaseApiGetIterator(handle);
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessBaseAPIGetPageSegMode"
        )]
        public static extern PageSegMode NativeBaseAPIGetPageSegMode(HandleRef handle);

        public PageSegMode BaseAPIGetPageSegMode(HandleRef handle)
        {
            return NativeBaseAPIGetPageSegMode(handle);
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessBaseAPIGetStringVariable"
        )]
        public static extern IntPtr NativeBaseApiGetStringVariableInternal(
            HandleRef handle,
            string name
        );

        public IntPtr BaseApiGetStringVariableInternal(HandleRef handle, string name)
        {
            return NativeBaseApiGetStringVariableInternal(handle, name);
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessBaseAPIGetThresholdedImage"
        )]
        public static extern IntPtr NativeBaseAPIGetThresholdedImage(HandleRef handle);

        public IntPtr BaseAPIGetThresholdedImage(HandleRef handle)
        {
            return NativeBaseAPIGetThresholdedImage(handle);
        }

        // The following were causing issues on Linux/MacOsX when used in .net core//[DllImport(NativeConstants.TesseractLinuxX64DllName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TessBaseAPIProcessPages")]//int BaseAPIProcessPages(HandleRef handle, string filename, string retry_config, int timeout_millisec, HandleRef renderer);
        //[DllImport(NativeConstants.TesseractLinuxX64DllName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TessBaseAPIProcessPage")]//int BaseAPIProcessPage(HandleRef handle, Pix pix, int page_index, string filename, string retry_config, int timeout_millisec, HandleRef renderer);
        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessBaseAPISetInputName"
        )]
        public static extern void NativeBaseAPISetInputName(HandleRef handle, string name);

        public void BaseAPISetInputName(HandleRef handle, string name)
        {
            NativeBaseAPISetInputName(handle, name);
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessBaseAPIGetDatapath"
        )]
        public static extern string NativeBaseAPIGetDatapath(HandleRef handle);

        public string BaseAPIGetDatapath(HandleRef handle)
        {
            return NativeBaseAPIGetDatapath(handle);
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessBaseAPISetOutputName"
        )]
        public static extern void NativeBaseAPISetOutputName(HandleRef handle, string name);

        public void BaseAPISetOutputName(HandleRef handle, string name)
        {
            NativeBaseAPISetOutputName(handle, name);
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessBaseAPIGetUTF8Text"
        )]
        public static extern IntPtr NativeBaseAPIGetUTF8TextInternal(HandleRef handle);

        public IntPtr BaseAPIGetUTF8TextInternal(HandleRef handle)
        {
            return NativeBaseAPIGetUTF8TextInternal(handle);
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessBaseAPIInit4"
        )]
        public static extern int NativeBaseApiInit(
            HandleRef handle,
            string datapath,
            string language,
            int mode,
            string[] configs,
            int configs_size,
            string[] vars_vec,
            string[] vars_values,
            UIntPtr vars_vec_size,
            bool set_only_non_debug_params
        );

        public int BaseApiInit(
            HandleRef handle,
            string datapath,
            string language,
            int mode,
            string[] configs,
            int configs_size,
            string[] vars_vec,
            string[] vars_values,
            UIntPtr vars_vec_size,
            bool set_only_non_debug_params
        )
        {
            return NativeBaseApiInit(
                handle,
                datapath,
                language,
                mode,
                configs,
                configs_size,
                vars_vec,
                vars_values,
                vars_vec_size,
                set_only_non_debug_params
            );
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessBaseAPIMeanTextConf"
        )]
        public static extern int NativeBaseAPIMeanTextConf(HandleRef handle);

        public int BaseAPIMeanTextConf(HandleRef handle)
        {
            return NativeBaseAPIMeanTextConf(handle);
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessBaseAPIRecognize"
        )]
        public static extern int NativeBaseApiRecognize(HandleRef handle, HandleRef monitor);

        public int BaseApiRecognize(HandleRef handle, HandleRef monitor)
        {
            return NativeBaseApiRecognize(handle, monitor);
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessBaseAPISetDebugVariable"
        )]
        public static extern int NativeBaseApiSetDebugVariable(
            HandleRef handle,
            string name,
            IntPtr valPtr
        );

        public int BaseApiSetDebugVariable(HandleRef handle, string name, IntPtr valPtr)
        {
            return NativeBaseApiSetDebugVariable(handle, name, valPtr);
        }

        // image analysis
        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessBaseAPISetImage2"
        )]
        public static extern void NativeBaseApiSetImage(HandleRef handle, HandleRef pixHandle);

        public void BaseApiSetImage(HandleRef handle, HandleRef pixHandle)
        {
            NativeBaseApiSetImage(handle, pixHandle);
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessBaseAPISetInputName"
        )]
        public static extern void NativeBaseApiSetInputName(HandleRef handle, string value);

        public void BaseApiSetInputName(HandleRef handle, string value)
        {
            NativeBaseApiSetInputName(handle, value);
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessBaseAPISetPageSegMode"
        )]
        public static extern void NativeBaseAPISetPageSegMode(HandleRef handle, PageSegMode mode);

        public void BaseAPISetPageSegMode(HandleRef handle, PageSegMode mode)
        {
            NativeBaseAPISetPageSegMode(handle, mode);
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessBaseAPISetRectangle"
        )]
        public static extern void NativeBaseApiSetRectangle(
            HandleRef handle,
            int left,
            int top,
            int width,
            int height
        );

        public void BaseApiSetRectangle(HandleRef handle, int left, int top, int width, int height)
        {
            NativeBaseApiSetRectangle(handle, left, top, width, height);
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessBaseAPISetVariable"
        )]
        public static extern int NativeBaseApiSetVariable(
            HandleRef handle,
            string name,
            IntPtr valPtr
        );

        public int BaseApiSetVariable(HandleRef handle, string name, IntPtr valPtr)
        {
            return NativeBaseApiSetVariable(handle, name, valPtr);
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessDeleteIntArray"
        )]
        public static extern void NativeDeleteIntArray(IntPtr arr);

        public void DeleteIntArray(IntPtr arr)
        {
            NativeDeleteIntArray(arr);
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessDeleteText"
        )]
        public static extern void NativeDeleteText(IntPtr textPtr);

        public void DeleteText(IntPtr textPtr)
        {
            NativeDeleteText(textPtr);
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessDeleteTextArray"
        )]
        public static extern void NativeDeleteTextArray(IntPtr arr);

        public void DeleteTextArray(IntPtr arr)
        {
            NativeDeleteTextArray(arr);
        }

        // Helper functions
        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessVersion"
        )]
        public static extern IntPtr NativeGetVersion();

        public IntPtr GetVersion()
        {
            return NativeGetVersion();
        }

        // result iterator
        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessPageIteratorBaseline"
        )]
        public static extern int NativePageIteratorBaseline(
            HandleRef handle,
            PageIteratorLevel level,
            out int x1,
            out int y1,
            out int x2,
            out int y2
        );

        public int PageIteratorBaseline(
            HandleRef handle,
            PageIteratorLevel level,
            out int x1,
            out int y1,
            out int x2,
            out int y2
        )
        {
            return NativePageIteratorBaseline(handle, level, out x1, out y1, out x2, out y2);
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessPageIteratorBegin"
        )]
        public static extern void NativePageIteratorBegin(HandleRef handle);

        public void PageIteratorBegin(HandleRef handle)
        {
            NativePageIteratorBegin(handle);
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessPageIteratorBlockType"
        )]
        public static extern PolyBlockType NativePageIteratorBlockType(HandleRef handle);

        public PolyBlockType PageIteratorBlockType(HandleRef handle)
        {
            return NativePageIteratorBlockType(handle);
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessPageIteratorBoundingBox"
        )]
        public static extern int NativePageIteratorBoundingBox(
            HandleRef handle,
            PageIteratorLevel level,
            out int left,
            out int top,
            out int right,
            out int bottom
        );

        public int PageIteratorBoundingBox(
            HandleRef handle,
            PageIteratorLevel level,
            out int left,
            out int top,
            out int right,
            out int bottom
        )
        {
            return NativePageIteratorBoundingBox(
                handle,
                level,
                out left,
                out top,
                out right,
                out bottom
            );
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessPageIteratorCopy"
        )]
        public static extern IntPtr NativePageIteratorCopy(HandleRef handle);

        public IntPtr PageIteratorCopy(HandleRef handle)
        {
            return NativePageIteratorCopy(handle);
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessPageIteratorDelete"
        )]
        public static extern void NativePageIteratorDelete(HandleRef handle);

        public void PageIteratorDelete(HandleRef handle)
        {
            NativePageIteratorDelete(handle);
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessPageIteratorGetBinaryImage"
        )]
        public static extern IntPtr NativePageIteratorGetBinaryImage(
            HandleRef handle,
            PageIteratorLevel level
        );

        public IntPtr PageIteratorGetBinaryImage(HandleRef handle, PageIteratorLevel level)
        {
            return NativePageIteratorGetBinaryImage(handle, level);
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessPageIteratorGetImage"
        )]
        public static extern IntPtr NativePageIteratorGetImage(
            HandleRef handle,
            PageIteratorLevel level,
            int padding,
            HandleRef originalImage,
            out int left,
            out int top
        );

        public IntPtr PageIteratorGetImage(
            HandleRef handle,
            PageIteratorLevel level,
            int padding,
            HandleRef originalImage,
            out int left,
            out int top
        )
        {
            return NativePageIteratorGetImage(
                handle,
                level,
                padding,
                originalImage,
                out left,
                out top
            );
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessPageIteratorIsAtBeginningOf"
        )]
        public static extern int NativePageIteratorIsAtBeginningOf(
            HandleRef handle,
            PageIteratorLevel level
        );

        public int PageIteratorIsAtBeginningOf(HandleRef handle, PageIteratorLevel level)
        {
            return NativePageIteratorIsAtBeginningOf(handle, level);
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessPageIteratorIsAtFinalElement"
        )]
        public static extern int NativePageIteratorIsAtFinalElement(
            HandleRef handle,
            PageIteratorLevel level,
            PageIteratorLevel element
        );

        public int PageIteratorIsAtFinalElement(
            HandleRef handle,
            PageIteratorLevel level,
            PageIteratorLevel element
        )
        {
            return NativePageIteratorIsAtFinalElement(handle, level, element);
        }

        // page iterator
        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessPageIteratorNext"
        )]
        public static extern int NativePageIteratorNext(HandleRef handle, PageIteratorLevel level);

        public int PageIteratorNext(HandleRef handle, PageIteratorLevel level)
        {
            return NativePageIteratorNext(handle, level);
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessPageIteratorOrientation"
        )]
        public static extern void NativePageIteratorOrientation(
            HandleRef handle,
            out Orientation orientation,
            out WritingDirection writing_direction,
            out TextLineOrder textLineOrder,
            out float deskew_angle
        );

        public void PageIteratorOrientation(
            HandleRef handle,
            out Orientation orientation,
            out WritingDirection writing_direction,
            out TextLineOrder textLineOrder,
            out float deskew_angle
        )
        {
            NativePageIteratorOrientation(
                handle,
                out orientation,
                out writing_direction,
                out textLineOrder,
                out deskew_angle
            );
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessResultIteratorCopy"
        )]
        public static extern IntPtr NativeResultIteratorCopy(HandleRef handle);

        public IntPtr ResultIteratorCopy(HandleRef handle)
        {
            return NativeResultIteratorCopy(handle);
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessResultIteratorDelete"
        )]
        public static extern void NativeResultIteratorDelete(HandleRef handle);

        public void ResultIteratorDelete(HandleRef handle)
        {
            NativeResultIteratorDelete(handle);
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessResultIteratorConfidence"
        )]
        public static extern float NativeResultIteratorGetConfidence(
            HandleRef handle,
            PageIteratorLevel level
        );

        public float ResultIteratorGetConfidence(HandleRef handle, PageIteratorLevel level)
        {
            return NativeResultIteratorGetConfidence(handle, level);
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessResultIteratorWordFontAttributes"
        )]
        public static extern IntPtr NativeResultIteratorWordFontAttributes(
            HandleRef handle,
            out bool isBold,
            out bool isItalic,
            out bool isUnderlined,
            out bool isMonospace,
            out bool isSerif,
            out bool isSmallCaps,
            out int pointSize,
            out int fontId
        );

        public IntPtr ResultIteratorWordFontAttributes(
            HandleRef handle,
            out bool isBold,
            out bool isItalic,
            out bool isUnderlined,
            out bool isMonospace,
            out bool isSerif,
            out bool isSmallCaps,
            out int pointSize,
            out int fontId
        )
        {
            return NativeResultIteratorWordFontAttributes(
                handle,
                out isBold,
                out isItalic,
                out isUnderlined,
                out isMonospace,
                out isSerif,
                out isSmallCaps,
                out pointSize,
                out fontId
            );
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessResultIteratorWordIsFromDictionary"
        )]
        public static extern bool NativeResultIteratorWordIsFromDictionary(HandleRef handle);

        public bool ResultIteratorWordIsFromDictionary(HandleRef handle)
        {
            return NativeResultIteratorWordIsFromDictionary(handle);
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessResultIteratorWordIsNumeric"
        )]
        public static extern bool NativeResultIteratorWordIsNumeric(HandleRef handle);

        public bool ResultIteratorWordIsNumeric(HandleRef handle)
        {
            return NativeResultIteratorWordIsNumeric(handle);
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessResultIteratorWordRecognitionLanguage"
        )]
        public static extern IntPtr NativeResultIteratorWordRecognitionLanguageInternal(
            HandleRef handle
        );

        public IntPtr ResultIteratorWordRecognitionLanguageInternal(HandleRef handle)
        {
            return NativeResultIteratorWordRecognitionLanguageInternal(handle);
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessResultIteratorSymbolIsSuperscript"
        )]
        public static extern bool NativeResultIteratorSymbolIsSuperscript(HandleRef handle);

        public bool ResultIteratorSymbolIsSuperscript(HandleRef handle)
        {
            return NativeResultIteratorSymbolIsSuperscript(handle);
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessResultIteratorSymbolIsSubscript"
        )]
        public static extern bool NativeResultIteratorSymbolIsSubscript(HandleRef handle);

        public bool ResultIteratorSymbolIsSubscript(HandleRef handle)
        {
            return NativeResultIteratorSymbolIsSubscript(handle);
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessResultIteratorSymbolIsDropcap"
        )]
        public static extern bool NativeResultIteratorSymbolIsDropcap(HandleRef handle);

        public bool ResultIteratorSymbolIsDropcap(HandleRef handle)
        {
            return NativeResultIteratorSymbolIsDropcap(handle);
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessResultIteratorGetPageIterator"
        )]
        public static extern IntPtr NativeResultIteratorGetPageIterator(HandleRef handle);

        public IntPtr ResultIteratorGetPageIterator(HandleRef handle)
        {
            return NativeResultIteratorGetPageIterator(handle);
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessResultIteratorGetUTF8Text"
        )]
        public static extern IntPtr NativeResultIteratorGetUTF8TextInternal(
            HandleRef handle,
            PageIteratorLevel level
        );

        public IntPtr ResultIteratorGetUTF8TextInternal(HandleRef handle, PageIteratorLevel level)
        {
            return NativeResultIteratorGetUTF8TextInternal(handle, level);
        }

        #region Choice Iterator
        /// <summary>/// Native API call to TessResultIteratorGetChoiceIterator/// </summary>/// <param name="handle"></param>/// <returns></returns>
        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessResultIteratorGetChoiceIterator"
        )]
        public static extern IntPtr NativeResultIteratorGetChoiceIterator(HandleRef handle);

        public IntPtr ResultIteratorGetChoiceIterator(HandleRef handle)
        {
            return NativeResultIteratorGetChoiceIterator(handle);
        }

        /// <summary>/// Native API call to TessChoiceIteratorDelete/// </summary>/// <param name="handle"></param>
        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessChoiceIteratorDelete"
        )]
        public static extern void NativeChoiceIteratorDelete(HandleRef handle);

        public void ChoiceIteratorDelete(HandleRef handle)
        {
            NativeChoiceIteratorDelete(handle);
        }

        /// <summary>/// Native API call to TessChoiceIteratorNext/// </summary>/// <param name="handle"></param>/// <returns></returns>
        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessChoiceIteratorNext"
        )]
        public static extern int NativeChoiceIteratorNext(HandleRef handle);

        public int ChoiceIteratorNext(HandleRef handle)
        {
            return NativeChoiceIteratorNext(handle);
        }

        /// <summary>/// Native API call to TessChoiceIteratorGetUTF8Text/// </summary>/// <param name="handle"></param>/// <returns></returns>
        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessChoiceIteratorGetUTF8Text"
        )]
        public static extern IntPtr NativeChoiceIteratorGetUTF8TextInternal(HandleRef handle);

        public IntPtr ChoiceIteratorGetUTF8TextInternal(HandleRef handle)
        {
            return NativeChoiceIteratorGetUTF8TextInternal(handle);
        }

        /// <summary>/// Native API call to TessChoiceIteratorConfidence/// </summary>/// <param name="handle"></param>/// <returns></returns>
        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessChoiceIteratorConfidence"
        )]
        public static extern float NativeChoiceIteratorGetConfidence(HandleRef handle);

        public float ChoiceIteratorGetConfidence(HandleRef handle)
        {
            return NativeChoiceIteratorGetConfidence(handle);
        }

        #endregion Choice Iterator
        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessBaseAPIPrintVariablesToFile"
        )]
        public static extern int NativeBaseApiPrintVariablesToFile(
            HandleRef handle,
            string filename
        );

        public int BaseApiPrintVariablesToFile(HandleRef handle, string filename)
        {
            return NativeBaseApiPrintVariablesToFile(handle, filename);
        }

        #region Renderer API
        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessTextRendererCreate"
        )]
        public static extern IntPtr NativeTextRendererCreate(string outputbase);

        public IntPtr TextRendererCreate(string outputbase)
        {
            return NativeTextRendererCreate(outputbase);
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessAltoRendererCreate"
        )]
        public static extern IntPtr NativeAltoRendererCreate(string outputbase);

        public IntPtr AltoRendererCreate(string outputbase)
        {
            return NativeAltoRendererCreate(outputbase);
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessTsvRendererCreate"
        )]
        public static extern IntPtr NativeTsvRendererCreate(string outputbase);

        public IntPtr TsvRendererCreate(string outputbase)
        {
            return NativeTsvRendererCreate(outputbase);
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessHOcrRendererCreate"
        )]
        public static extern IntPtr NativeHOcrRendererCreate(string outputbase);

        public IntPtr HOcrRendererCreate(string outputbase)
        {
            return NativeHOcrRendererCreate(outputbase);
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessHOcrRendererCreate2"
        )]
        public static extern IntPtr NativeHOcrRendererCreate2(string outputbase, int font_info);

        public IntPtr HOcrRendererCreate2(string outputbase, int font_info)
        {
            return NativeHOcrRendererCreate2(outputbase, font_info);
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessPDFRendererCreate"
        )]
        public static extern IntPtr NativePDFRendererCreate(
            string outputbase,
            IntPtr datadir,
            int textonly
        );

        public IntPtr PDFRendererCreate(string outputbase, IntPtr datadir, int textonly)
        {
            return NativePDFRendererCreate(outputbase, datadir, textonly);
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessUnlvRendererCreate"
        )]
        public static extern IntPtr NativeUnlvRendererCreate(string outputbase);

        public IntPtr UnlvRendererCreate(string outputbase)
        {
            return NativeUnlvRendererCreate(outputbase);
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessBoxTextRendererCreate"
        )]
        public static extern IntPtr NativeBoxTextRendererCreate(string outputbase);

        public IntPtr BoxTextRendererCreate(string outputbase)
        {
            return NativeBoxTextRendererCreate(outputbase);
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessLSTMBoxRendererCreate"
        )]
        public static extern IntPtr NativeLSTMBoxRendererCreate(string outputbase);

        public IntPtr LSTMBoxRendererCreate(string outputbase)
        {
            return NativeLSTMBoxRendererCreate(outputbase);
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessWordStrBoxRendererCreate"
        )]
        public static extern IntPtr NativeWordStrBoxRendererCreate(string outputbase);

        public IntPtr WordStrBoxRendererCreate(string outputbase)
        {
            return NativeWordStrBoxRendererCreate(outputbase);
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessDeleteResultRenderer"
        )]
        public static extern void NativeDeleteResultRenderer(HandleRef renderer);

        public void DeleteResultRenderer(HandleRef renderer)
        {
            NativeDeleteResultRenderer(renderer);
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessResultRendererInsert"
        )]
        public static extern void NativeResultRendererInsert(HandleRef renderer, HandleRef next);

        public void ResultRendererInsert(HandleRef renderer, HandleRef next)
        {
            NativeResultRendererInsert(renderer, next);
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessResultRendererNext"
        )]
        public static extern IntPtr NativeResultRendererNext(HandleRef renderer);

        public IntPtr ResultRendererNext(HandleRef renderer)
        {
            return NativeResultRendererNext(renderer);
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessResultRendererBeginDocument"
        )]
        public static extern int NativeResultRendererBeginDocument(
            HandleRef renderer,
            IntPtr titlePtr
        );

        public int ResultRendererBeginDocument(HandleRef renderer, IntPtr titlePtr)
        {
            return NativeResultRendererBeginDocument(renderer, titlePtr);
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessResultRendererAddImage"
        )]
        public static extern int NativeResultRendererAddImage(HandleRef renderer, HandleRef api);

        public int ResultRendererAddImage(HandleRef renderer, HandleRef api)
        {
            return NativeResultRendererAddImage(renderer, api);
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessResultRendererEndDocument"
        )]
        public static extern int NativeResultRendererEndDocument(HandleRef renderer);

        public int ResultRendererEndDocument(HandleRef renderer)
        {
            return NativeResultRendererEndDocument(renderer);
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessResultRendererExtention"
        )]
        public static extern IntPtr NativeResultRendererExtention(HandleRef renderer);

        public IntPtr ResultRendererExtention(HandleRef renderer)
        {
            return NativeResultRendererExtention(renderer);
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessResultRendererTitle"
        )]
        public static extern IntPtr NativeResultRendererTitle(HandleRef renderer);

        public IntPtr ResultRendererTitle(HandleRef renderer)
        {
            return NativeResultRendererTitle(renderer);
        }

        [DllImport(
            NativeConstants.TesseractLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessResultRendererImageNum"
        )]
        public static extern int NativeResultRendererImageNum(HandleRef renderer);

        public int ResultRendererImageNum(HandleRef renderer)
        {
            return NativeResultRendererImageNum(renderer);
        }

        #endregion Renderer API
    }

    public class NativeLeptonicaApiLinux : INativeLeptonicaApi
    {
        #region PixA
        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixaReadMultipageTiff"
        )]
        public static extern IntPtr NativepixaReadMultipageTiff(string filename);

        public IntPtr pixaReadMultipageTiff(string filename)
        {
            return NativepixaReadMultipageTiff(filename);
        }

        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixaCreate"
        )]
        public static extern IntPtr NativepixaCreate(int n);

        public IntPtr pixaCreate(int n)
        {
            return NativepixaCreate(n);
        }

        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixaAddPix"
        )]
        public static extern int NativepixaAddPix(
            HandleRef pixa,
            HandleRef pix,
            PixArrayAccessType copyflag
        );

        public int pixaAddPix(HandleRef pixa, HandleRef pix, PixArrayAccessType copyflag)
        {
            return NativepixaAddPix(pixa, pix, copyflag);
        }

        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixaGetPix"
        )]
        public static extern IntPtr NativepixaGetPix(
            HandleRef pixa,
            int index,
            PixArrayAccessType accesstype
        );

        public IntPtr pixaGetPix(HandleRef pixa, int index, PixArrayAccessType accesstype)
        {
            return NativepixaGetPix(pixa, index, accesstype);
        }

        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixaRemovePix"
        )]
        public static extern int NativepixaRemovePix(HandleRef pixa, int index);

        public int pixaRemovePix(HandleRef pixa, int index)
        {
            return NativepixaRemovePix(pixa, index);
        }

        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixaClear"
        )]
        public static extern int NativepixaClear(HandleRef pixa);

        public int pixaClear(HandleRef pixa)
        {
            return NativepixaClear(pixa);
        }

        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixaGetCount"
        )]
        public static extern int NativepixaGetCount(HandleRef pixa);

        public int pixaGetCount(HandleRef pixa)
        {
            return NativepixaGetCount(pixa);
        }

        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixaDestroy"
        )]
        public static extern void NativepixaDestroy(ref IntPtr pix);

        public void pixaDestroy(ref IntPtr pix)
        {
            NativepixaDestroy(ref pix);
        }

        #endregion
        #region Pix
        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixCreate"
        )]
        public static extern IntPtr NativepixCreate(int width, int height, int depth);

        public IntPtr pixCreate(int width, int height, int depth)
        {
            return NativepixCreate(width, height, depth);
        }

        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixClone"
        )]
        public static extern IntPtr NativepixClone(HandleRef pix);

        public IntPtr pixClone(HandleRef pix)
        {
            return NativepixClone(pix);
        }

        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixDestroy"
        )]
        public static extern void NativepixDestroy(ref IntPtr pix);

        public void pixDestroy(ref IntPtr pix)
        {
            NativepixDestroy(ref pix);
        }

        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixEqual"
        )]
        public static extern int NativepixEqual(HandleRef pix1, HandleRef pix2, out int same);

        public int pixEqual(HandleRef pix1, HandleRef pix2, out int same)
        {
            return NativepixEqual(pix1, pix2, out same);
        }

        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixGetWidth"
        )]
        public static extern int NativepixGetWidth(HandleRef pix);

        public int pixGetWidth(HandleRef pix)
        {
            return NativepixGetWidth(pix);
        }

        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixGetHeight"
        )]
        public static extern int NativepixGetHeight(HandleRef pix);

        public int pixGetHeight(HandleRef pix)
        {
            return NativepixGetHeight(pix);
        }

        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixGetDepth"
        )]
        public static extern int NativepixGetDepth(HandleRef pix);

        public int pixGetDepth(HandleRef pix)
        {
            return NativepixGetDepth(pix);
        }

        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixGetXRes"
        )]
        public static extern int NativepixGetXRes(HandleRef pix);

        public int pixGetXRes(HandleRef pix)
        {
            return NativepixGetXRes(pix);
        }

        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixGetYRes"
        )]
        public static extern int NativepixGetYRes(HandleRef pix);

        public int pixGetYRes(HandleRef pix)
        {
            return NativepixGetYRes(pix);
        }

        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixGetResolution"
        )]
        public static extern int NativepixGetResolution(HandleRef pix, out int xres, out int yres);

        public int pixGetResolution(HandleRef pix, out int xres, out int yres)
        {
            return NativepixGetResolution(pix, out xres, out yres);
        }

        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixGetWpl"
        )]
        public static extern int NativepixGetWpl(HandleRef pix);

        public int pixGetWpl(HandleRef pix)
        {
            return NativepixGetWpl(pix);
        }

        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixSetXRes"
        )]
        public static extern int NativepixSetXRes(HandleRef pix, int xres);

        public int pixSetXRes(HandleRef pix, int xres)
        {
            return NativepixSetXRes(pix, xres);
        }

        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixSetYRes"
        )]
        public static extern int NativepixSetYRes(HandleRef pix, int yres);

        public int pixSetYRes(HandleRef pix, int yres)
        {
            return NativepixSetYRes(pix, yres);
        }

        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixSetResolution"
        )]
        public static extern int NativepixSetResolution(HandleRef pix, int xres, int yres);

        public int pixSetResolution(HandleRef pix, int xres, int yres)
        {
            return NativepixSetResolution(pix, xres, yres);
        }

        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixScaleResolution"
        )]
        public static extern int NativepixScaleResolution(
            HandleRef pix,
            float xscale,
            float yscale
        );

        public int pixScaleResolution(HandleRef pix, float xscale, float yscale)
        {
            return NativepixScaleResolution(pix, xscale, yscale);
        }

        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixGetData"
        )]
        public static extern IntPtr NativepixGetData(HandleRef pix);

        public IntPtr pixGetData(HandleRef pix)
        {
            return NativepixGetData(pix);
        }

        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixGetInputFormat"
        )]
        public static extern ImageFormat NativepixGetInputFormat(HandleRef pix);

        public ImageFormat pixGetInputFormat(HandleRef pix)
        {
            return NativepixGetInputFormat(pix);
        }

        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixSetInputFormat"
        )]
        public static extern int NativepixSetInputFormat(HandleRef pix, ImageFormat inputFormat);

        public int pixSetInputFormat(HandleRef pix, ImageFormat inputFormat)
        {
            return NativepixSetInputFormat(pix, inputFormat);
        }

        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixEndianByteSwap"
        )]
        public static extern int NativepixEndianByteSwap(HandleRef pix);

        public int pixEndianByteSwap(HandleRef pix)
        {
            return NativepixEndianByteSwap(pix);
        }

        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixRead"
        )]
        public static extern IntPtr NativepixRead(string filename);

        public IntPtr pixRead(string filename)
        {
            return NativepixRead(filename);
        }

        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixReadMem"
        )]
        public static extern unsafe IntPtr NativepixReadMem(byte* data, int length);

        public unsafe IntPtr pixReadMem(byte* data, int length)
        {
            return NativepixReadMem(data, length);
        }

        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixReadMemTiff"
        )]
        public static extern unsafe IntPtr NativepixReadMemTiff(byte* data, int length, int page);

        public unsafe IntPtr pixReadMemTiff(byte* data, int length, int page)
        {
            return NativepixReadMemTiff(data, length, page);
        }

        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixReadFromMultipageTiff"
        )]
        public static extern IntPtr NativepixReadFromMultipageTiff(string filename, ref int offset);

        public IntPtr pixReadFromMultipageTiff(string filename, ref int offset)
        {
            return NativepixReadFromMultipageTiff(filename, ref offset);
        }

        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixWrite"
        )]
        public static extern int NativepixWrite(
            string filename,
            HandleRef handle,
            ImageFormat format
        );

        public int pixWrite(string filename, HandleRef handle, ImageFormat format)
        {
            return NativepixWrite(filename, handle, format);
        }

        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixDisplayWrite"
        )]
        public static extern int NativepixDisplayWrite(HandleRef pixs, int reduction);

        public int pixDisplayWrite(HandleRef pixs, int reduction)
        {
            return NativepixDisplayWrite(pixs, reduction);
        }

        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixGetColormap"
        )]
        public static extern IntPtr NativepixGetColormap(HandleRef pix);

        public IntPtr pixGetColormap(HandleRef pix)
        {
            return NativepixGetColormap(pix);
        }

        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixSetColormap"
        )]
        public static extern int NativepixSetColormap(HandleRef pix, HandleRef pixCmap);

        public int pixSetColormap(HandleRef pix, HandleRef pixCmap)
        {
            return NativepixSetColormap(pix, pixCmap);
        }

        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixDestroyColormap"
        )]
        public static extern int NativepixDestroyColormap(HandleRef pix);

        public int pixDestroyColormap(HandleRef pix)
        {
            return NativepixDestroyColormap(pix);
        }

        // pixconv.h functions
        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixConvertRGBToGray"
        )]
        public static extern IntPtr NativepixConvertRGBToGray(
            HandleRef pix,
            float rwt,
            float gwt,
            float bwt
        );

        public IntPtr pixConvertRGBToGray(HandleRef pix, float rwt, float gwt, float bwt)
        {
            return NativepixConvertRGBToGray(pix, rwt, gwt, bwt);
        }

        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixConvertTo8"
        )]
        public static extern IntPtr NativepixConvertTo8(HandleRef pix, int cmapflag);

        public IntPtr pixConvertTo8(HandleRef pix, int cmapflag)
        {
            return NativepixConvertTo8(pix, cmapflag);
        }

        // image analysis and manipulation functions
        // skew
        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixDeskewGeneral"
        )]
        public static extern IntPtr NativepixDeskewGeneral(
            HandleRef pix,
            int redSweep,
            float sweepRange,
            float sweepDelta,
            int redSearch,
            int thresh,
            out float pAngle,
            out float pConf
        );

        public IntPtr pixDeskewGeneral(
            HandleRef pix,
            int redSweep,
            float sweepRange,
            float sweepDelta,
            int redSearch,
            int thresh,
            out float pAngle,
            out float pConf
        )
        {
            return NativepixDeskewGeneral(
                pix,
                redSweep,
                sweepRange,
                sweepDelta,
                redSearch,
                thresh,
                out pAngle,
                out pConf
            );
        }

        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixFindSkew"
        )]
        public static extern int NativepixFindSkew(
            HandleRef pixs,
            out float pangle,
            out float pconf
        );

        public int pixFindSkew(HandleRef pixs, out float pangle, out float pconf)
        {
            return NativepixFindSkew(pixs, out pangle, out pconf);
        }

        // rotation
        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixRotate"
        )]
        public static extern IntPtr NativepixRotate(
            HandleRef pixs,
            float angle,
            RotationMethod type,
            RotationFill fillColor,
            int width,
            int heigh
        );

        public IntPtr pixRotate(
            HandleRef pixs,
            float angle,
            RotationMethod type,
            RotationFill fillColor,
            int width,
            int heigh
        )
        {
            return NativepixRotate(pixs, angle, type, fillColor, width, heigh);
        }

        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixRotateOrth"
        )]
        public static extern IntPtr NativepixRotateOrth(HandleRef pixs, int quads);

        public IntPtr pixRotateOrth(HandleRef pixs, int quads)
        {
            return NativepixRotateOrth(pixs, quads);
        }

        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixRotateAMGray"
        )]
        public static extern IntPtr NativepixRotateAMGray(
            HandleRef pixs,
            float angle,
            byte grayval
        );

        public IntPtr pixRotateAMGray(HandleRef pixs, float angle, byte grayval)
        {
            return NativepixRotateAMGray(pixs, angle, grayval);
        }

        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixRotate90"
        )]
        public static extern IntPtr NativepixRotate90(HandleRef pixs, int direction);

        public IntPtr pixRotate90(HandleRef pixs, int direction)
        {
            return NativepixRotate90(pixs, direction);
        }

        // Grayscale
        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixCloseGray"
        )]
        public static extern IntPtr NativepixCloseGray(HandleRef pixs, int hsize, int vsize);

        public IntPtr pixCloseGray(HandleRef pixs, int hsize, int vsize)
        {
            return NativepixCloseGray(pixs, hsize, vsize);
        }

        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixErodeGray"
        )]
        public static extern IntPtr NativepixErodeGray(HandleRef pixs, int hsize, int vsize);

        public IntPtr pixErodeGray(HandleRef pixs, int hsize, int vsize)
        {
            return NativepixErodeGray(pixs, hsize, vsize);
        }

        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixAddGray"
        )]
        public static extern IntPtr NativepixAddGray(
            HandleRef pixd,
            HandleRef pixs1,
            HandleRef pixs2
        );

        public IntPtr pixAddGray(HandleRef pixd, HandleRef pixs1, HandleRef pixs2)
        {
            return NativepixAddGray(pixd, pixs1, pixs2);
        }

        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixOpenGray"
        )]
        public static extern IntPtr NativepixOpenGray(HandleRef pixs, int hsize, int vsize);

        public IntPtr pixOpenGray(HandleRef pixs, int hsize, int vsize)
        {
            return NativepixOpenGray(pixs, hsize, vsize);
        }

        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixCombineMasked"
        )]
        public static extern int NativepixCombineMasked(
            HandleRef pixd,
            HandleRef pixs,
            HandleRef pixm
        );

        public int pixCombineMasked(HandleRef pixd, HandleRef pixs, HandleRef pixm)
        {
            return NativepixCombineMasked(pixd, pixs, pixm);
        }

        // Threshold
        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixThresholdToValue"
        )]
        public static extern IntPtr NativepixThresholdToValue(
            HandleRef pixd,
            HandleRef pixs,
            int threshval,
            int setval
        );

        public IntPtr pixThresholdToValue(HandleRef pixd, HandleRef pixs, int threshval, int setval)
        {
            return NativepixThresholdToValue(pixd, pixs, threshval, setval);
        }

        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixThresholdToBinary"
        )]
        public static extern IntPtr NativepixThresholdToBinary(HandleRef pixs, int thresh);

        public IntPtr pixThresholdToBinary(HandleRef pixs, int thresh)
        {
            return NativepixThresholdToBinary(pixs, thresh);
        }

        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixInvert"
        )]
        public static extern IntPtr NativepixInvert(HandleRef pixd, HandleRef pixs);

        public IntPtr pixInvert(HandleRef pixd, HandleRef pixs)
        {
            return NativepixInvert(pixd, pixs);
        }

        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixBackgroundNormFlex"
        )]
        public static extern IntPtr NativepixBackgroundNormFlex(
            HandleRef pixs,
            int sx,
            int sy,
            int smoothx,
            int smoothy,
            int delta
        );

        public IntPtr pixBackgroundNormFlex(
            HandleRef pixs,
            int sx,
            int sy,
            int smoothx,
            int smoothy,
            int delta
        )
        {
            return NativepixBackgroundNormFlex(pixs, sx, sy, smoothx, smoothy, delta);
        }

        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixGammaTRCMasked"
        )]
        public static extern IntPtr NativepixGammaTRCMasked(
            HandleRef pixd,
            HandleRef pixs,
            HandleRef pixm,
            float gamma,
            int minval,
            int maxval
        );

        public IntPtr pixGammaTRCMasked(
            HandleRef pixd,
            HandleRef pixs,
            HandleRef pixm,
            float gamma,
            int minval,
            int maxval
        )
        {
            return NativepixGammaTRCMasked(pixd, pixs, pixm, gamma, minval, maxval);
        }

        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixHMT"
        )]
        public static extern IntPtr NativepixHMT(HandleRef pixd, HandleRef pixs, HandleRef sel);

        public IntPtr pixHMT(HandleRef pixd, HandleRef pixs, HandleRef sel)
        {
            return NativepixHMT(pixd, pixs, sel);
        }

        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixDilate"
        )]
        public static extern IntPtr NativepixDilate(HandleRef pixd, HandleRef pixs, HandleRef sel);

        public IntPtr pixDilate(HandleRef pixd, HandleRef pixs, HandleRef sel)
        {
            return NativepixDilate(pixd, pixs, sel);
        }

        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixSubtract"
        )]
        public static extern IntPtr NativepixSubtract(
            HandleRef pixd,
            HandleRef pixs1,
            HandleRef pixs2
        );

        public IntPtr pixSubtract(HandleRef pixd, HandleRef pixs1, HandleRef pixs2)
        {
            return NativepixSubtract(pixd, pixs1, pixs2);
        }

        // Sel
        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "selCreateFromString"
        )]
        public static extern IntPtr NativeselCreateFromString(
            string text,
            int h,
            int w,
            string name
        );

        public IntPtr selCreateFromString(string text, int h, int w, string name)
        {
            return NativeselCreateFromString(text, h, w, name);
        }

        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "selCreateBrick"
        )]
        public static extern IntPtr NativeselCreateBrick(
            int h,
            int w,
            int cy,
            int cx,
            SelType type
        );

        public IntPtr selCreateBrick(int h, int w, int cy, int cx, SelType type)
        {
            return NativeselCreateBrick(h, w, cy, cx, type);
        }

        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "selDestroy"
        )]
        public static extern void NativeselDestroy(ref IntPtr psel);

        public void selDestroy(ref IntPtr psel)
        {
            NativeselDestroy(ref psel);
        }

        // Binarization - src/binarize.c
        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixOtsuAdaptiveThreshold"
        )]
        public static extern int NativepixOtsuAdaptiveThreshold(
            HandleRef pix,
            int sx,
            int sy,
            int smoothx,
            int smoothy,
            float scorefract,
            out IntPtr ppixth,
            out IntPtr ppixd
        );

        public int pixOtsuAdaptiveThreshold(
            HandleRef pix,
            int sx,
            int sy,
            int smoothx,
            int smoothy,
            float scorefract,
            out IntPtr ppixth,
            out IntPtr ppixd
        )
        {
            return NativepixOtsuAdaptiveThreshold(
                pix,
                sx,
                sy,
                smoothx,
                smoothy,
                scorefract,
                out ppixth,
                out ppixd
            );
        }

        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixSauvolaBinarize"
        )]
        public static extern int NativepixSauvolaBinarize(
            HandleRef pix,
            int whsize,
            float factor,
            int addborder,
            out IntPtr ppixm,
            out IntPtr ppixsd,
            out IntPtr ppixth,
            out IntPtr ppixd
        );

        public int pixSauvolaBinarize(
            HandleRef pix,
            int whsize,
            float factor,
            int addborder,
            out IntPtr ppixm,
            out IntPtr ppixsd,
            out IntPtr ppixth,
            out IntPtr ppixd
        )
        {
            return NativepixSauvolaBinarize(
                pix,
                whsize,
                factor,
                addborder,
                out ppixm,
                out ppixsd,
                out ppixth,
                out ppixd
            );
        }

        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixSauvolaBinarizeTiled"
        )]
        public static extern int NativepixSauvolaBinarizeTiled(
            HandleRef pix,
            int whsize,
            float factor,
            int nx,
            int ny,
            out IntPtr ppixth,
            out IntPtr ppixd
        );

        public int pixSauvolaBinarizeTiled(
            HandleRef pix,
            int whsize,
            float factor,
            int nx,
            int ny,
            out IntPtr ppixth,
            out IntPtr ppixd
        )
        {
            return NativepixSauvolaBinarizeTiled(
                pix,
                whsize,
                factor,
                nx,
                ny,
                out ppixth,
                out ppixd
            );
        }

        // Scaling - src/scale.c
        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixScale"
        )]
        public static extern IntPtr NativepixScale(HandleRef pixs, float scalex, float scaley);

        public IntPtr pixScale(HandleRef pixs, float scalex, float scaley)
        {
            return NativepixScale(pixs, scalex, scaley);
        }

        #endregion
        #region Color map
        // Color map creation and deletion
        /// <summary>/// Creates a new colormap with the specified <paramref name="depth"/>./// </summary>/// <param name="depth">The depth of the pix in bpp, can be 2, 4, or 8</param>/// <returns>The pointer to the color map, or null on error.</returns>
        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixcmapCreate"
        )]
        public static extern IntPtr NativepixcmapCreate(int depth);

        public IntPtr pixcmapCreate(int depth)
        {
            return NativepixcmapCreate(depth);
        }

        /// <summary>/// Creates a new colormap of the specified <paramref name="depth"/> with random colors where the first color can optionally be set to black, and the last optionally set to white./// </summary>/// <param name="depth">The depth of the pix in bpp, can be 2, 4, or 8</param>/// <param name="hasBlack">If set to 1 the first color will be black.</param>/// <param name="hasWhite">If set to 1 the last color will be white.</param>/// <returns>The pointer to the color map, or null on error.</returns>
        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixcmapCreateRandom"
        )]
        public static extern IntPtr NativepixcmapCreateRandom(
            int depth,
            int hasBlack,
            int hasWhite
        );

        public IntPtr pixcmapCreateRandom(int depth, int hasBlack, int hasWhite)
        {
            return NativepixcmapCreateRandom(depth, hasBlack, hasWhite);
        }

        /// <summary>/// Creates a new colormap of the specified <paramref name="depth"/> with equally spaced gray color values./// </summary>/// <param name="depth">The depth of the pix in bpp, can be 2, 4, or 8</param>/// <param name="levels">The number of levels (must be between 2 and 2^<paramref name="depth"/></param>/// <returns>The pointer to the colormap, or null on error.</returns>
        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixcmapCreateLinear"
        )]
        public static extern IntPtr NativepixcmapCreateLinear(int depth, int levels);

        public IntPtr pixcmapCreateLinear(int depth, int levels)
        {
            return NativepixcmapCreateLinear(depth, levels);
        }

        /// <summary>/// Performs a deep copy of the color map./// </summary>/// <param name="cmaps">The pointer to the colormap instance.</param>/// <returns>The pointer to the colormap, or null on error.</returns>
        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixcmapCopy"
        )]
        public static extern IntPtr NativepixcmapCopy(HandleRef cmaps);

        public IntPtr pixcmapCopy(HandleRef cmaps)
        {
            return NativepixcmapCopy(cmaps);
        }

        /// <summary>/// Destorys and cleans up any memory used by the color map./// </summary>/// <param name="cmap">The pointer to the colormap instance, set to null on success.</param>
        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixcmapDestroy"
        )]
        public static extern void NativepixcmapDestroy(ref IntPtr cmap);

        public void pixcmapDestroy(ref IntPtr cmap)
        {
            NativepixcmapDestroy(ref cmap);
        }

        // colormap metadata (depth, count, etc)
        /// <summary>/// Gets the number of color entries in the color map./// </summary>/// <param name="cmap">The pointer to the colormap instance.</param>/// <returns>Returns the number of color entries in the color map, or 0 on error.</returns>
        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixcmapGetCount"
        )]
        public static extern int NativepixcmapGetCount(HandleRef cmap);

        public int pixcmapGetCount(HandleRef cmap)
        {
            return NativepixcmapGetCount(cmap);
        }

        /// <summary>/// Gets the number of free color entries in the color map./// </summary>/// <param name="cmap">The pointer to the colormap instance.</param>/// <returns>Returns the number of free color entries in the color map, or 0 on error.</returns>
        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixcmapGetFreeCount"
        )]
        public static extern int NativepixcmapGetFreeCount(HandleRef cmap);

        public int pixcmapGetFreeCount(HandleRef cmap)
        {
            return NativepixcmapGetFreeCount(cmap);
        }

        /// <returns>Returns color maps depth, or 0 on error.</returns>
        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixcmapGetDepth"
        )]
        public static extern int NativepixcmapGetDepth(HandleRef cmap);

        public int pixcmapGetDepth(HandleRef cmap)
        {
            return NativepixcmapGetDepth(cmap);
        }

        /// <summary>/// Gets the minimum pix depth required to support the color map./// </summary>/// <param name="cmap">The pointer to the colormap instance.</param>/// <param name="minDepth">Returns the minimum depth to support the colormap</param>/// <returns>Returns 0 if OK, 1 on error.</returns>
        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixcmapGetMinDepth"
        )]
        public static extern int NativepixcmapGetMinDepth(HandleRef cmap, out int minDepth);

        public int pixcmapGetMinDepth(HandleRef cmap, out int minDepth)
        {
            return NativepixcmapGetMinDepth(cmap, out minDepth);
        }

        // colormap - color addition\clearing
        /// <summary>/// Removes all colors from the color map by setting the count to zero./// </summary>/// <param name="cmap">The pointer to the colormap instance.</param>/// <returns>Returns 0 if OK, 1 on error.</returns>
        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixcmapClear"
        )]
        public static extern int NativepixcmapClear(HandleRef cmap);

        public int pixcmapClear(HandleRef cmap)
        {
            return NativepixcmapClear(cmap);
        }

        /// <summary>/// Adds the color to the pix color map if their is room./// </summary>/// <returns>Returns 0 if OK, 1 on error.</returns>
        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixcmapAddColor"
        )]
        public static extern int NativepixcmapAddColor(
            HandleRef cmap,
            int redValue,
            int greenValue,
            int blueValue
        );

        public int pixcmapAddColor(HandleRef cmap, int redValue, int greenValue, int blueValue)
        {
            return NativepixcmapAddColor(cmap, redValue, greenValue, blueValue);
        }

        /// <summary>/// Adds the specified color if it doesn't already exist, returning the colors index in the data array./// </summary>/// <param name="cmap">The pointer to the colormap instance.</param>/// <param name="redValue">The red value</param>/// <param name="greenValue">The green value</param>/// <param name="blueValue">The blue value</param>/// <param name="colorIndex">The index of the new color if it was added, or the existing color if it already existed.</param>/// <returns>Returns 0 for success, 1 for error, 2 for not enough space.</returns>
        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixcmapAddNewColor"
        )]
        public static extern int NativepixcmapAddNewColor(
            HandleRef cmap,
            int redValue,
            int greenValue,
            int blueValue,
            out int colorIndex
        );

        public int pixcmapAddNewColor(
            HandleRef cmap,
            int redValue,
            int greenValue,
            int blueValue,
            out int colorIndex
        )
        {
            return NativepixcmapAddNewColor(cmap, redValue, greenValue, blueValue, out colorIndex);
        }

        /// <summary>/// Adds the specified color if it doesn't already exist, returning the color's index in the data array./// </summary>/// <remarks>/// If the color doesn't exist and there is not enough room to add a new color return the nearest color./// </remarks>/// <param name="cmap">The pointer to the colormap instance.</param>/// <param name="redValue">The red value</param>/// <param name="greenValue">The green value</param>/// <param name="blueValue">The blue value</param>/// <param name="colorIndex">The index of the new color if it was added, or the existing color if it already existed.</param>/// <returns>Returns 0 for success, 1 for error, 2 for not enough space.</returns>
        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixcmapAddNearestColor"
        )]
        public static extern int NativepixcmapAddNearestColor(
            HandleRef cmap,
            int redValue,
            int greenValue,
            int blueValue,
            out int colorIndex
        );

        public int pixcmapAddNearestColor(
            HandleRef cmap,
            int redValue,
            int greenValue,
            int blueValue,
            out int colorIndex
        )
        {
            return NativepixcmapAddNearestColor(
                cmap,
                redValue,
                greenValue,
                blueValue,
                out colorIndex
            );
        }

        /// <summary>/// Checks if the color already exists or if their is enough room to add it./// </summary>/// <param name="cmap">The pointer to the colormap instance.</param>/// <param name="redValue">The red value</param>/// <param name="greenValue">The green value</param>/// <param name="blueValue">The blue value</param>/// <param name="usable">Returns 1 if usable; 0 if not.</param>/// <returns>Returns 0 if OK, 1 on error.</returns>
        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixcmapUsableColor"
        )]
        public static extern int NativepixcmapUsableColor(
            HandleRef cmap,
            int redValue,
            int greenValue,
            int blueValue,
            out int usable
        );

        public int pixcmapUsableColor(
            HandleRef cmap,
            int redValue,
            int greenValue,
            int blueValue,
            out int usable
        )
        {
            return NativepixcmapUsableColor(cmap, redValue, greenValue, blueValue, out usable);
        }

        /// <summary>/// Adds a color (black\white) if not already there returning it's index through <paramref name="index"/>./// </summary>/// <param name="cmap">The pointer to the colormap instance.</param>/// <param name="color">The color to add (0 for black; 1 for white)</param>/// <param name="index">The index of the color.</param>/// <returns>Returns 0 if OK; 1 on error.</returns>
        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixcmapAddBlackOrWhite"
        )]
        public static extern int NativepixcmapAddBlackOrWhite(
            HandleRef cmap,
            int color,
            out int index
        );

        public int pixcmapAddBlackOrWhite(HandleRef cmap, int color, out int index)
        {
            return NativepixcmapAddBlackOrWhite(cmap, color, out index);
        }

        /// <summary>/// Sets the darkest color in the colormap to black, if <paramref name="setBlack"/> is 1./// Sets the lightest color in the colormap to white if <paramref name="setWhite"/> is 1./// </summary>/// <param name="cmap">The pointer to the colormap instance.</param>/// <param name="setBlack">0 for no operation; 1 to set darket color to black</param>/// <param name="setWhite">0 for no operation; 1 to set lightest color to white</param>/// <returns>Returns 0 if OK; 1 on error.</returns>
        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixcmapSetBlackAndWhite"
        )]
        public static extern int NativepixcmapSetBlackAndWhite(
            HandleRef cmap,
            int setBlack,
            int setWhite
        );

        public int pixcmapSetBlackAndWhite(HandleRef cmap, int setBlack, int setWhite)
        {
            return NativepixcmapSetBlackAndWhite(cmap, setBlack, setWhite);
        }

        // color access - color entry access
        /// <summary>/// Gets the color at the specified index./// </summary>/// <param name="cmap">The pointer to the colormap instance.</param>/// <param name="index">The index of the color entry.</param>/// <param name="redValue">The color entry's red value.</param>/// <param name="blueValue">The color entry's blue value.</param>/// <param name="greenValue">The color entry's green value.</param>/// <returns>Returns 0 if OK; 1 if not accessable (caller should check).</returns>
        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixcmapGetColor"
        )]
        public static extern int NativepixcmapGetColor(
            HandleRef cmap,
            int index,
            out int redValue,
            out int blueValue,
            out int greenValue
        );

        public int pixcmapGetColor(
            HandleRef cmap,
            int index,
            out int redValue,
            out int blueValue,
            out int greenValue
        )
        {
            return NativepixcmapGetColor(cmap, index, out redValue, out blueValue, out greenValue);
        }

        /// <summary>/// Gets the color at the specified index./// </summary>/// <remarks>/// The alpha channel will always be zero as it is not used in Leptonica color maps./// </remarks>/// <param name="cmap">The pointer to the colormap instance.</param>/// <param name="index">The index of the color entry.</param>/// <param name="color">The color entry as 32 bit value</param>/// <returns>Returns 0 if OK; 1 if not accessable (caller should check).</returns>
        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixcmapGetColor32"
        )]
        public static extern int NativepixcmapGetColor32(HandleRef cmap, int index, out int color);

        public int pixcmapGetColor32(HandleRef cmap, int index, out int color)
        {
            return NativepixcmapGetColor32(cmap, index, out color);
        }

        /// <summary>/// Sets a previously allocated color entry./// </summary>/// <param name="cmap">The pointer to the colormap instance.</param>/// <param name="index">The index of the colormap entry</param>/// <param name="redValue"></param>/// <param name="blueValue"></param>/// <param name="greenValue"></param>/// <returns>Returns 0 if OK; 1 if not accessable (caller should check).</returns>
        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixcmapResetColor"
        )]
        public static extern int NativepixcmapResetColor(
            HandleRef cmap,
            int index,
            int redValue,
            int blueValue,
            int greenValue
        );

        public int pixcmapResetColor(
            HandleRef cmap,
            int index,
            int redValue,
            int blueValue,
            int greenValue
        )
        {
            return NativepixcmapResetColor(cmap, index, redValue, blueValue, greenValue);
        }

        /// <summary>/// Gets the index of the color entry with the specified color, return 0 if found; 1 if not./// </summary>
        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixcmapGetIndex"
        )]
        public static extern int NativepixcmapGetIndex(
            HandleRef cmap,
            int redValue,
            int blueValue,
            int greenValue,
            out int index
        );

        public int pixcmapGetIndex(
            HandleRef cmap,
            int redValue,
            int blueValue,
            int greenValue,
            out int index
        )
        {
            return NativepixcmapGetIndex(cmap, redValue, blueValue, greenValue, out index);
        }

        /// <summary>/// Returns 0 if the color exists in the color map; otherwise 1./// </summary>/// <returns>Returns 0 if OK; 1 on error.</returns>
        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixcmapHasColor"
        )]
        public static extern int NativepixcmapHasColor(HandleRef cmap, int color);

        public int pixcmapHasColor(HandleRef cmap, int color)
        {
            return NativepixcmapHasColor(cmap, color);
        }

        /// <summary>/// Returns the number of unique grey colors including black and white./// </summary>/// <returns>Returns 0 if OK; 1 on error.</returns>
        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixcmapCountGrayColors"
        )]
        public static extern int NativepixcmapCountGrayColors(HandleRef cmap, out int ngray);

        public int pixcmapCountGrayColors(HandleRef cmap, out int ngray)
        {
            return NativepixcmapCountGrayColors(cmap, out ngray);
        }

        /// <summary>/// Finds the index of the color entry with the rank intensity./// </summary>/// <returns>Returns 0 if OK; 1 on error.</returns>
        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixcmapCountGrayColors"
        )]
        public static extern int NativepixcmapGetRankIntensity(
            HandleRef cmap,
            float rankVal,
            out int index
        );

        public int pixcmapGetRankIntensity(HandleRef cmap, float rankVal, out int index)
        {
            return NativepixcmapGetRankIntensity(cmap, rankVal, out index);
        }

        /// <summary>/// Finds the index of the color entry closest to the specified color./// </summary>/// <returns>Returns 0 if OK; 1 on error.</returns>
        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixcmapGetNearestIndex"
        )]
        public static extern int NativepixcmapGetNearestIndex(
            HandleRef cmap,
            int rVal,
            int bVal,
            int gVal,
            out int index
        );

        public int pixcmapGetNearestIndex(
            HandleRef cmap,
            int rVal,
            int bVal,
            int gVal,
            out int index
        )
        {
            return NativepixcmapGetNearestIndex(cmap, rVal, bVal, gVal, out index);
        }

        /// <summary>/// Finds the index of the color entry closest to the specified color./// </summary>/// <remarks>/// Should only be used on gray colormaps./// </remarks>/// <returns>Returns 0 if OK; 1 on error.</returns>
        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixcmapGetNearestGrayIndex"
        )]
        public static extern int NativepixcmapGetNearestGrayIndex(
            HandleRef cmap,
            int val,
            out int index
        );

        public int pixcmapGetNearestGrayIndex(HandleRef cmap, int val, out int index)
        {
            return NativepixcmapGetNearestGrayIndex(cmap, val, out index);
        }

        // color map conversion
        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixcmapGrayToColor"
        )]
        public static extern IntPtr NativepixcmapGrayToColor(int color);

        public IntPtr pixcmapGrayToColor(int color)
        {
            return NativepixcmapGrayToColor(color);
        }

        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixcmapColorToGray"
        )]
        public static extern IntPtr NativepixcmapColorToGray(
            HandleRef cmaps,
            float redWeight,
            float greenWeight,
            float blueWeight
        );

        public IntPtr pixcmapColorToGray(
            HandleRef cmaps,
            float redWeight,
            float greenWeight,
            float blueWeight
        )
        {
            return NativepixcmapColorToGray(cmaps, redWeight, greenWeight, blueWeight);
        }

        // colormap serialization
        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixcmapColorToGray"
        )]
        public static extern int NativepixcmapToArrays(
            HandleRef cmap,
            out IntPtr redMap,
            out IntPtr blueMap,
            out IntPtr greenMap
        );

        public int pixcmapToArrays(
            HandleRef cmap,
            out IntPtr redMap,
            out IntPtr blueMap,
            out IntPtr greenMap
        )
        {
            return NativepixcmapToArrays(cmap, out redMap, out blueMap, out greenMap);
        }

        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixcmapToRGBTable"
        )]
        public static extern int NativepixcmapToRGBTable(
            HandleRef cmap,
            out IntPtr colorTable,
            out int colorCount
        );

        public int pixcmapToRGBTable(HandleRef cmap, out IntPtr colorTable, out int colorCount)
        {
            return NativepixcmapToRGBTable(cmap, out colorTable, out colorCount);
        }

        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixcmapSerializeToMemory"
        )]
        public static extern int NativepixcmapSerializeToMemory(
            HandleRef cmap,
            out int components,
            out int colorCount,
            out IntPtr colorData,
            out int colorDataLength
        );

        public int pixcmapSerializeToMemory(
            HandleRef cmap,
            out int components,
            out int colorCount,
            out IntPtr colorData,
            out int colorDataLength
        )
        {
            return NativepixcmapSerializeToMemory(
                cmap,
                out components,
                out colorCount,
                out colorData,
                out colorDataLength
            );
        }

        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixcmapDeserializeFromMemory"
        )]
        public static extern IntPtr NativepixcmapDeserializeFromMemory(
            HandleRef colorData,
            int colorCount,
            int colorDataLength
        );

        public IntPtr pixcmapDeserializeFromMemory(
            HandleRef colorData,
            int colorCount,
            int colorDataLength
        )
        {
            return NativepixcmapDeserializeFromMemory(colorData, colorCount, colorDataLength);
        }

        // colormap transformations
        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixcmapGammaTRC"
        )]
        public static extern int NativepixcmapGammaTRC(
            HandleRef cmap,
            float gamma,
            int minVal,
            int maxVal
        );

        public int pixcmapGammaTRC(HandleRef cmap, float gamma, int minVal, int maxVal)
        {
            return NativepixcmapGammaTRC(cmap, gamma, minVal, maxVal);
        }

        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixcmapContrastTRC"
        )]
        public static extern int NativepixcmapContrastTRC(HandleRef cmap, float factor);

        public int pixcmapContrastTRC(HandleRef cmap, float factor)
        {
            return NativepixcmapContrastTRC(cmap, factor);
        }

        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixcmapShiftIntensity"
        )]
        public static extern int NativepixcmapShiftIntensity(HandleRef cmap, float fraction);

        public int pixcmapShiftIntensity(HandleRef cmap, float fraction)
        {
            return NativepixcmapShiftIntensity(cmap, fraction);
        }

        #endregion
        #region Box
        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "boxaGetCount"
        )]
        public static extern int NativeboxaGetCount(HandleRef boxa);

        public int boxaGetCount(HandleRef boxa)
        {
            return NativeboxaGetCount(boxa);
        }

        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "boxaGetBox"
        )]
        public static extern IntPtr NativeboxaGetBox(
            HandleRef boxa,
            int index,
            PixArrayAccessType accesstype
        );

        public IntPtr boxaGetBox(HandleRef boxa, int index, PixArrayAccessType accesstype)
        {
            return NativeboxaGetBox(boxa, index, accesstype);
        }

        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "boxGetGeometry"
        )]
        public static extern int NativeboxGetGeometry(
            HandleRef box,
            out int px,
            out int py,
            out int pw,
            out int ph
        );

        public int boxGetGeometry(HandleRef box, out int px, out int py, out int pw, out int ph)
        {
            return NativeboxGetGeometry(box, out px, out py, out pw, out ph);
        }

        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "boxDestroy"
        )]
        public static extern void NativeboxDestroy(ref IntPtr box);

        public void boxDestroy(ref IntPtr box)
        {
            NativeboxDestroy(ref box);
        }

        [DllImport(
            NativeConstants.LeptonicaLinuxX64DllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "boxaDestroy"
        )]
        public static extern void NativeboxaDestroy(ref IntPtr box);

        public void boxaDestroy(ref IntPtr box)
        {
            NativeboxaDestroy(ref box);
        }

        #endregion
    }
}
