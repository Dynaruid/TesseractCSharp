using System;
using System.Runtime.InteropServices;

namespace TesseractDotnetWrapper.Interop
{
    public interface INativeTessApi
    {
        IntPtr BaseAPIGetComponentImages(
            HandleRef handle,
            PageIteratorLevel level,
            int text_only,
            IntPtr pixa,
            IntPtr blockids
        );

        IntPtr BaseAPIAnalyseLayout(HandleRef handle);
        void BaseAPIClear(HandleRef handle);
        IntPtr BaseApiCreate();
        void BaseApiDelete(HandleRef ptr);
        int TessBaseAPIDetectOrientationScript(
            HandleRef handle,
            out int orient_deg,
            out float orient_conf,
            out IntPtr script_name,
            out float script_conf
        );
        int BaseApiGetBoolVariable(HandleRef handle, string name, out int value);
        int BaseApiGetDoubleVariable(HandleRef handle, string name, out double value);
        IntPtr BaseApiGetHOCRTextInternal(HandleRef handle, int pageNum);
        IntPtr BaseApiGetAltoTextInternal(HandleRef handle, int pageNum);
        IntPtr BaseApiGetTsvTextInternal(HandleRef handle, int pageNum);
        IntPtr BaseApiGetBoxTextInternal(HandleRef handle, int pageNum);
        IntPtr BaseApiGetLSTMBoxTextInternal(HandleRef handle, int pageNum);
        IntPtr BaseApiGetWordStrBoxTextInternal(HandleRef handle, int pageNum);
        IntPtr BaseApiGetUNLVTextInternal(HandleRef handle);
        int BaseApiGetIntVariable(HandleRef handle, string name, out int value);
        IntPtr BaseApiGetIterator(HandleRef handle);
        PageSegMode BaseAPIGetPageSegMode(HandleRef handle);
        IntPtr BaseApiGetStringVariableInternal(HandleRef handle, string name);
        IntPtr BaseAPIGetThresholdedImage(HandleRef handle);

        //int BaseAPIProcessPages(HandleRef handle, string filename, string retry_config, int timeout_millisec, HandleRef renderer);
        //int BaseAPIProcessPage(HandleRef handle, Pix pix, int page_index, string filename, string retry_config, int timeout_millisec, HandleRef renderer);
        void BaseAPISetInputName(HandleRef handle, string name);
        string BaseAPIGetDatapath(HandleRef handle);
        void BaseAPISetOutputName(HandleRef handle, string name);
        IntPtr BaseAPIGetUTF8TextInternal(HandleRef handle);
        int BaseApiInit(
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
        int BaseAPIMeanTextConf(HandleRef handle);
        int BaseApiRecognize(HandleRef handle, HandleRef monitor);
        int BaseApiSetDebugVariable(HandleRef handle, string name, IntPtr valPtr);
        void BaseApiSetImage(HandleRef handle, HandleRef pixHandle);
        void BaseApiSetInputName(HandleRef handle, string value);
        void BaseAPISetPageSegMode(HandleRef handle, PageSegMode mode);
        void BaseApiSetRectangle(HandleRef handle, int left, int top, int width, int height);
        int BaseApiSetVariable(HandleRef handle, string name, IntPtr valPtr);
        void DeleteIntArray(IntPtr arr);
        void DeleteText(IntPtr textPtr);
        void DeleteTextArray(IntPtr arr);
        IntPtr GetVersion();

        int PageIteratorBaseline(
            HandleRef handle,
            PageIteratorLevel level,
            out int x1,
            out int y1,
            out int x2,
            out int y2
        );
        void PageIteratorBegin(HandleRef handle);
        PolyBlockType PageIteratorBlockType(HandleRef handle);
        int PageIteratorBoundingBox(
            HandleRef handle,
            PageIteratorLevel level,
            out int left,
            out int top,
            out int right,
            out int bottom
        );
        IntPtr PageIteratorCopy(HandleRef handle);
        void PageIteratorDelete(HandleRef handle);
        IntPtr PageIteratorGetBinaryImage(HandleRef handle, PageIteratorLevel level);
        IntPtr PageIteratorGetImage(
            HandleRef handle,
            PageIteratorLevel level,
            int padding,
            HandleRef originalImage,
            out int left,
            out int top
        );
        int PageIteratorIsAtBeginningOf(HandleRef handle, PageIteratorLevel level);
        int PageIteratorIsAtFinalElement(
            HandleRef handle,
            PageIteratorLevel level,
            PageIteratorLevel element
        );
        int PageIteratorNext(HandleRef handle, PageIteratorLevel level);
        void PageIteratorOrientation(
            HandleRef handle,
            out Orientation orientation,
            out WritingDirection writing_direction,
            out TextLineOrder textLineOrder,
            out float deskew_angle
        );
        IntPtr ResultIteratorCopy(HandleRef handle);
        void ResultIteratorDelete(HandleRef handle);
        float ResultIteratorGetConfidence(HandleRef handle, PageIteratorLevel level);
        IntPtr ResultIteratorWordFontAttributes(
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
        bool ResultIteratorWordIsFromDictionary(HandleRef handle);
        bool ResultIteratorWordIsNumeric(HandleRef handle);
        IntPtr ResultIteratorWordRecognitionLanguageInternal(HandleRef handle);
        bool ResultIteratorSymbolIsSuperscript(HandleRef handle);
        bool ResultIteratorSymbolIsSubscript(HandleRef handle);
        bool ResultIteratorSymbolIsDropcap(HandleRef handle);
        IntPtr ResultIteratorGetPageIterator(HandleRef handle);
        IntPtr ResultIteratorGetUTF8TextInternal(HandleRef handle, PageIteratorLevel level);

        IntPtr ResultIteratorGetChoiceIterator(HandleRef handle);
        void ChoiceIteratorDelete(HandleRef handle);
        int ChoiceIteratorNext(HandleRef handle);
        IntPtr ChoiceIteratorGetUTF8TextInternal(HandleRef handle);
        float ChoiceIteratorGetConfidence(HandleRef handle);

        int BaseApiPrintVariablesToFile(HandleRef handle, string filename);
        #region Renderer API
        IntPtr TextRendererCreate(string outputbase);
        IntPtr AltoRendererCreate(string outputbase);
        IntPtr TsvRendererCreate(string outputbase);
        IntPtr HOcrRendererCreate(string outputbase);
        IntPtr HOcrRendererCreate2(string outputbase, int font_info);
        IntPtr PDFRendererCreate(string outputbase, IntPtr datadir, int textonly);
        IntPtr UnlvRendererCreate(string outputbase);
        IntPtr BoxTextRendererCreate(string outputbase);
        IntPtr LSTMBoxRendererCreate(string outputbase);
        IntPtr WordStrBoxRendererCreate(string outputbase);
        void DeleteResultRenderer(HandleRef renderer);
        void ResultRendererInsert(HandleRef renderer, HandleRef next);
        IntPtr ResultRendererNext(HandleRef renderer);
        int ResultRendererBeginDocument(HandleRef renderer, IntPtr titlePtr);
        int ResultRendererAddImage(HandleRef renderer, HandleRef api);
        int ResultRendererEndDocument(HandleRef renderer);

        #endregion Renderer API
    }
}
