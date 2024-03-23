using System.Runtime.InteropServices;

namespace TesseractCSharp.Interop
{
    public class NativeTessApi
    {
        const string nativeApi = "NativeTessApi";
        static NativeTessApi()
        {
            NativeConstants.InitNativeLoader();
        }

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessBaseAPIGetComponentImages"
        )]
        public static extern IntPtr BaseAPIGetComponentImages(
            HandleRef handle,
            PageIteratorLevel level,
            int text_only,
            IntPtr pixa,
            IntPtr blockids
        );

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessBaseAPIAnalyseLayout"
        )]
        public static extern IntPtr BaseAPIAnalyseLayout(HandleRef handle);

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessBaseAPIClear"
        )]
        public static extern void BaseAPIClear(HandleRef handle);

        /// <summary>/// Creates a new BaseAPI instance/// </summary>/// <returns></returns>
        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessBaseAPICreate"
        )]
        public static extern IntPtr BaseApiCreate();

        // Base API/// <summary>/// Deletes a base api instance./// </summary>/// <returns></returns>
        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessBaseAPIDelete"
        )]
        public static extern void BaseApiDelete(HandleRef ptr);

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessBaseAPIDetectOrientationScript"
        )]
        public static extern int TessBaseAPIDetectOrientationScript(
            HandleRef handle,
            out int orient_deg,
            out float orient_conf,
            out IntPtr script_name,
            out float script_conf
        );

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessBaseAPIGetBoolVariable"
        )]
        public static extern int BaseApiGetBoolVariable(
            HandleRef handle,
            string name,
            out int value
        );

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessBaseAPIGetDoubleVariable"
        )]
        public static extern int BaseApiGetDoubleVariable(
            HandleRef handle,
            string name,
            out double value
        );

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessBaseAPIGetHOCRText"
        )]
        public static extern IntPtr BaseApiGetHOCRTextInternal(HandleRef handle, int pageNum);

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessBaseAPIGetAltoText"
        )]
        public static extern IntPtr BaseApiGetAltoTextInternal(HandleRef handle, int pageNum);

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessBaseAPIGetTsvText"
        )]
        public static extern IntPtr BaseApiGetTsvTextInternal(HandleRef handle, int pageNum);

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessBaseAPIGetBoxText"
        )]
        public static extern IntPtr BaseApiGetBoxTextInternal(HandleRef handle, int pageNum);

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessBaseAPIGetLSTMBoxText"
        )]
        public static extern IntPtr BaseApiGetLSTMBoxTextInternal(HandleRef handle, int pageNum);

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessBaseAPIGetWordStrBoxText"
        )]
        public static extern IntPtr BaseApiGetWordStrBoxTextInternal(HandleRef handle, int pageNum);

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessBaseAPIGetUNLVText"
        )]
        public static extern IntPtr BaseApiGetUNLVTextInternal(HandleRef handle);

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessBaseAPIGetIntVariable"
        )]
        public static extern int BaseApiGetIntVariable(
            HandleRef handle,
            string name,
            out int value
        );

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessBaseAPIGetIterator"
        )]
        public static extern IntPtr BaseApiGetIterator(HandleRef handle);

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessBaseAPIGetPageSegMode"
        )]
        public static extern PageSegMode BaseAPIGetPageSegMode(HandleRef handle);

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessBaseAPIGetStringVariable"
        )]
        public static extern IntPtr BaseApiGetStringVariableInternal(HandleRef handle, string name);

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessBaseAPIGetThresholdedImage"
        )]
        public static extern IntPtr BaseAPIGetThresholdedImage(HandleRef handle);

        // The following were causing issues on Linux/MacOsX when used in .net core//[DllImport(nativeApi, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TessBaseAPIProcessPages")]//int BaseAPIProcessPages(HandleRef handle, string filename, string retry_config, int timeout_millisec, HandleRef renderer);
        //[DllImport(nativeApi, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TessBaseAPIProcessPage")]//int BaseAPIProcessPage(HandleRef handle, Pix pix, int page_index, string filename, string retry_config, int timeout_millisec, HandleRef renderer);
        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessBaseAPISetInputName"
        )]
        public static extern void BaseAPISetInputName(HandleRef handle, string name);

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessBaseAPIGetDatapath"
        )]
        public static extern string BaseAPIGetDatapath(HandleRef handle);

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessBaseAPISetOutputName"
        )]
        public static extern void BaseAPISetOutputName(HandleRef handle, string name);

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessBaseAPIGetUTF8Text"
        )]
        public static extern IntPtr BaseAPIGetUTF8TextInternal(HandleRef handle);

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessBaseAPIInit4"
        )]
        public static extern int BaseApiInit(
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

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessBaseAPIMeanTextConf"
        )]
        public static extern int BaseAPIMeanTextConf(HandleRef handle);

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessBaseAPIRecognize"
        )]
        public static extern int BaseApiRecognize(HandleRef handle, HandleRef monitor);

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessBaseAPISetDebugVariable"
        )]
        public static extern int BaseApiSetDebugVariable(
            HandleRef handle,
            string name,
            IntPtr valPtr
        );

        // image analysis
        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessBaseAPISetImage2"
        )]
        public static extern void BaseApiSetImage(HandleRef handle, HandleRef pixHandle);

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessBaseAPISetInputName"
        )]
        public static extern void BaseApiSetInputName(HandleRef handle, string value);

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessBaseAPISetPageSegMode"
        )]
        public static extern void BaseAPISetPageSegMode(HandleRef handle, PageSegMode mode);

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessBaseAPISetRectangle"
        )]
        public static extern void BaseApiSetRectangle(
            HandleRef handle,
            int left,
            int top,
            int width,
            int height
        );

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessBaseAPISetVariable"
        )]
        public static extern int BaseApiSetVariable(HandleRef handle, string name, IntPtr valPtr);

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessDeleteIntArray"
        )]
        public static extern void DeleteIntArray(IntPtr arr);

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessDeleteText"
        )]
        public static extern void DeleteText(IntPtr textPtr);

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessDeleteTextArray"
        )]
        public static extern void DeleteTextArray(IntPtr arr);

        // Helper functions
        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessVersion"
        )]
        public static extern IntPtr GetVersion();

        // result iterator
        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessPageIteratorBaseline"
        )]
        public static extern int PageIteratorBaseline(
            HandleRef handle,
            PageIteratorLevel level,
            out int x1,
            out int y1,
            out int x2,
            out int y2
        );

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessPageIteratorBegin"
        )]
        public static extern void PageIteratorBegin(HandleRef handle);

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessPageIteratorBlockType"
        )]
        public static extern PolyBlockType PageIteratorBlockType(HandleRef handle);

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessPageIteratorBoundingBox"
        )]
        public static extern int PageIteratorBoundingBox(
            HandleRef handle,
            PageIteratorLevel level,
            out int left,
            out int top,
            out int right,
            out int bottom
        );

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessPageIteratorCopy"
        )]
        public static extern IntPtr PageIteratorCopy(HandleRef handle);

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessPageIteratorDelete"
        )]
        public static extern void PageIteratorDelete(HandleRef handle);

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessPageIteratorGetBinaryImage"
        )]
        public static extern IntPtr PageIteratorGetBinaryImage(
            HandleRef handle,
            PageIteratorLevel level
        );

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessPageIteratorGetImage"
        )]
        public static extern IntPtr PageIteratorGetImage(
            HandleRef handle,
            PageIteratorLevel level,
            int padding,
            HandleRef originalImage,
            out int left,
            out int top
        );

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessPageIteratorIsAtBeginningOf"
        )]
        public static extern int PageIteratorIsAtBeginningOf(
            HandleRef handle,
            PageIteratorLevel level
        );

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessPageIteratorIsAtFinalElement"
        )]
        public static extern int PageIteratorIsAtFinalElement(
            HandleRef handle,
            PageIteratorLevel level,
            PageIteratorLevel element
        );

        // page iterator
        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessPageIteratorNext"
        )]
        public static extern int PageIteratorNext(HandleRef handle, PageIteratorLevel level);

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessPageIteratorOrientation"
        )]
        public static extern void PageIteratorOrientation(
            HandleRef handle,
            out Orientation orientation,
            out WritingDirection writing_direction,
            out TextLineOrder textLineOrder,
            out float deskew_angle
        );

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessResultIteratorCopy"
        )]
        public static extern IntPtr ResultIteratorCopy(HandleRef handle);

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessResultIteratorDelete"
        )]
        public static extern void ResultIteratorDelete(HandleRef handle);

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessResultIteratorConfidence"
        )]
        public static extern float ResultIteratorGetConfidence(
            HandleRef handle,
            PageIteratorLevel level
        );

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessResultIteratorWordFontAttributes"
        )]
        public static extern IntPtr ResultIteratorWordFontAttributes(
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

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessResultIteratorWordIsFromDictionary"
        )]
        public static extern bool ResultIteratorWordIsFromDictionary(HandleRef handle);

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessResultIteratorWordIsNumeric"
        )]
        public static extern bool ResultIteratorWordIsNumeric(HandleRef handle);

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessResultIteratorWordRecognitionLanguage"
        )]
        public static extern IntPtr ResultIteratorWordRecognitionLanguageInternal(HandleRef handle);

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessResultIteratorSymbolIsSuperscript"
        )]
        public static extern bool ResultIteratorSymbolIsSuperscript(HandleRef handle);

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessResultIteratorSymbolIsSubscript"
        )]
        public static extern bool ResultIteratorSymbolIsSubscript(HandleRef handle);

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessResultIteratorSymbolIsDropcap"
        )]
        public static extern bool ResultIteratorSymbolIsDropcap(HandleRef handle);

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessResultIteratorGetPageIterator"
        )]
        public static extern IntPtr ResultIteratorGetPageIterator(HandleRef handle);

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessResultIteratorGetUTF8Text"
        )]
        public static extern IntPtr ResultIteratorGetUTF8TextInternal(
            HandleRef handle,
            PageIteratorLevel level
        );

        #region Choice Iterator
        /// <summary>/// Native API call to TessResultIteratorGetChoiceIterator/// </summary>/// <param name="handle"></param>/// <returns></returns>
        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessResultIteratorGetChoiceIterator"
        )]
        public static extern IntPtr ResultIteratorGetChoiceIterator(HandleRef handle);

        /// <summary>/// Native API call to TessChoiceIteratorDelete/// </summary>/// <param name="handle"></param>
        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessChoiceIteratorDelete"
        )]
        public static extern void ChoiceIteratorDelete(HandleRef handle);

        /// <summary>/// Native API call to TessChoiceIteratorNext/// </summary>/// <param name="handle"></param>/// <returns></returns>
        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessChoiceIteratorNext"
        )]
        public static extern int ChoiceIteratorNext(HandleRef handle);

        /// <summary>/// Native API call to TessChoiceIteratorGetUTF8Text/// </summary>/// <param name="handle"></param>/// <returns></returns>
        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessChoiceIteratorGetUTF8Text"
        )]
        public static extern IntPtr ChoiceIteratorGetUTF8TextInternal(HandleRef handle);

        /// <summary>/// Native API call to TessChoiceIteratorConfidence/// </summary>/// <param name="handle"></param>/// <returns></returns>
        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessChoiceIteratorConfidence"
        )]
        public static extern float ChoiceIteratorGetConfidence(HandleRef handle);

        #endregion Choice Iterator
        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessBaseAPIPrintVariablesToFile"
        )]
        public static extern int BaseApiPrintVariablesToFile(HandleRef handle, string filename);

        #region Renderer API
        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessTextRendererCreate"
        )]
        public static extern IntPtr TextRendererCreate(string outputbase);

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessAltoRendererCreate"
        )]
        public static extern IntPtr AltoRendererCreate(string outputbase);

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessTsvRendererCreate"
        )]
        public static extern IntPtr TsvRendererCreate(string outputbase);

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessHOcrRendererCreate"
        )]
        public static extern IntPtr HOcrRendererCreate(string outputbase);

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessHOcrRendererCreate2"
        )]
        public static extern IntPtr HOcrRendererCreate2(string outputbase, int font_info);

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessPDFRendererCreate"
        )]
        public static extern IntPtr PDFRendererCreate(
            string outputbase,
            IntPtr datadir,
            int textonly
        );

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessUnlvRendererCreate"
        )]
        public static extern IntPtr UnlvRendererCreate(string outputbase);

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessBoxTextRendererCreate"
        )]
        public static extern IntPtr BoxTextRendererCreate(string outputbase);

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessLSTMBoxRendererCreate"
        )]
        public static extern IntPtr LSTMBoxRendererCreate(string outputbase);

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessWordStrBoxRendererCreate"
        )]
        public static extern IntPtr WordStrBoxRendererCreate(string outputbase);

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessDeleteResultRenderer"
        )]
        public static extern void DeleteResultRenderer(HandleRef renderer);

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessResultRendererInsert"
        )]
        public static extern void ResultRendererInsert(HandleRef renderer, HandleRef next);

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessResultRendererNext"
        )]
        public static extern IntPtr ResultRendererNext(HandleRef renderer);

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessResultRendererBeginDocument"
        )]
        public static extern int ResultRendererBeginDocument(HandleRef renderer, IntPtr titlePtr);

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessResultRendererAddImage"
        )]
        public static extern int ResultRendererAddImage(HandleRef renderer, HandleRef api);

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessResultRendererEndDocument"
        )]
        public static extern int ResultRendererEndDocument(HandleRef renderer);

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessResultRendererExtention"
        )]
        public static extern IntPtr ResultRendererExtention(HandleRef renderer);

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessResultRendererTitle"
        )]
        public static extern IntPtr ResultRendererTitle(HandleRef renderer);

        [DllImport(
            nativeApi,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "TessResultRendererImageNum"
        )]
        public static extern int ResultRendererImageNum(HandleRef renderer);

        #endregion Renderer API
    }
}
