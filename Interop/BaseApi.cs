using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using TesseractDotnetWrapper.Internal;

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

    internal static class TessApi
    {
        public static INativeTessApi NativeTess;
        public static INativeLeptonicaApi NativeLeptonica;

        static TessApi()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                //windows
                NativeTess = new NativeTessApiWindows();
                NativeLeptonica = new NativeLeptonicaApiWindow();
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                //macos
                NativeTess = new NativeTessApiMacos();
                NativeLeptonica = new NativeLeptonicaApiMacos();
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                //linux
                NativeTess = new NativeTessApiLinux();
                NativeLeptonica = new NativeLeptonicaApiLinux();
            }
            else
            {
                //unknown...
                NativeTess = new NativeTessApiWindows();
                NativeLeptonica = new NativeLeptonicaApiWindow();
            }
        }

        //XHTML Begin Tag:
        public const string xhtmlBeginTag =
            "<?xml version=\"1.0\" encoding=\"UTF-8\"?>\n"
            + "<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\"\n"
            + "    \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">\n"
            + "<html xmlns=\"http://www.w3.org/1999/xhtml\" xml:lang=\"en\" "
            + "lang=\"en\">\n <head>\n  <title></title>\n"
            + "<meta http-equiv=\"Content-Type\" content=\"text/html;"
            + "charset=utf-8\" />\n"
            + "  <meta name='ocr-system' content='tesseract' />\n"
            + "  <meta name='ocr-capabilities' content='ocr_page ocr_carea ocr_par"
            + " ocr_line ocrx_word"
            + "'/>\n"
            + "</head>\n<body>\n";

        //XHTML End Tag:
        public const string xhtmlEndTag = " </body>\n</html>\n";

        public const string htmlBeginTag =
            "<!DOCTYPE html PUBLIC \"-//W3C//DTD HTML 4.01 Transitional//EN\""
            + " \"http://www.w3.org/TR/html4/loose.dtd\">\n"
            + "<html>\n<head>\n<title></title>\n"
            + "<meta http-equiv=\"Content-Type\" content=\"text/html;"
            + "charset=utf-8\" />\n<meta name='ocr-system' content='tesseract'/>\n"
            + "</head>\n<body>\n";

        public const string htmlEndTag = "</body>\n</html>\n";

        public static string? BaseApiGetVersion()
        {
            IntPtr versionHandle = TessApi.NativeTess.GetVersion();
            if (versionHandle != IntPtr.Zero)
            {
                var result = MarshalHelper.PtrToString(versionHandle, Encoding.UTF8);
                return result;
            }

            return null;
        }

        public static string? BaseAPIGetHOCRText(HandleRef handle, int pageNum)
        {
            IntPtr txtHandle = TessApi.NativeTess.BaseApiGetHOCRTextInternal(handle, pageNum);
            if (txtHandle != IntPtr.Zero)
            {
                var result = MarshalHelper.PtrToString(txtHandle, Encoding.UTF8);
                TessApi.NativeTess.DeleteText(txtHandle);
                return htmlBeginTag + result + htmlEndTag;
            }
            else
            {
                return null;
            }
        }

        //Just Copied:
        public static string? BaseAPIGetHOCRText2(HandleRef handle, int pageNum)
        {
            IntPtr txtHandle = TessApi.NativeTess.BaseApiGetHOCRTextInternal(handle, pageNum);
            if (txtHandle != IntPtr.Zero)
            {
                var result = MarshalHelper.PtrToString(txtHandle, Encoding.UTF8);
                TessApi.NativeTess.DeleteText(txtHandle);
                return xhtmlBeginTag + result + xhtmlEndTag;
            }
            else
            {
                return null;
            }
        }

        public static string? BaseAPIGetAltoText(HandleRef handle, int pageNum)
        {
            IntPtr txtHandle = TessApi.NativeTess.BaseApiGetAltoTextInternal(handle, pageNum);
            if (txtHandle != IntPtr.Zero)
            {
                var result = MarshalHelper.PtrToString(txtHandle, Encoding.UTF8);
                TessApi.NativeTess.DeleteText(txtHandle);
                return result;
            }
            else
            {
                return null;
            }
        }

        public static string? BaseAPIGetTsvText(HandleRef handle, int pageNum)
        {
            IntPtr txtHandle = TessApi.NativeTess.BaseApiGetTsvTextInternal(handle, pageNum);
            if (txtHandle != IntPtr.Zero)
            {
                var result = MarshalHelper.PtrToString(txtHandle, Encoding.UTF8);
                TessApi.NativeTess.DeleteText(txtHandle);
                return result;
            }
            else
            {
                return null;
            }
        }

        public static string? BaseAPIGetBoxText(HandleRef handle, int pageNum)
        {
            IntPtr txtHandle = TessApi.NativeTess.BaseApiGetBoxTextInternal(handle, pageNum);
            if (txtHandle != IntPtr.Zero)
            {
                var result = MarshalHelper.PtrToString(txtHandle, Encoding.UTF8);
                TessApi.NativeTess.DeleteText(txtHandle);
                return result;
            }
            else
            {
                return null;
            }
        }

        public static string? BaseAPIGetLSTMBoxText(HandleRef handle, int pageNum)
        {
            IntPtr txtHandle = TessApi.NativeTess.BaseApiGetLSTMBoxTextInternal(handle, pageNum);
            if (txtHandle != IntPtr.Zero)
            {
                var result = MarshalHelper.PtrToString(txtHandle, Encoding.UTF8);
                TessApi.NativeTess.DeleteText(txtHandle);
                return result;
            }
            else
            {
                return null;
            }
        }

        public static string? BaseAPIGetWordStrBoxText(HandleRef handle, int pageNum)
        {
            IntPtr txtHandle = TessApi.NativeTess.BaseApiGetWordStrBoxTextInternal(handle, pageNum);
            if (txtHandle != IntPtr.Zero)
            {
                var result = MarshalHelper.PtrToString(txtHandle, Encoding.UTF8);
                TessApi.NativeTess.DeleteText(txtHandle);
                return result;
            }
            else
            {
                return null;
            }
        }

        public static string? BaseAPIGetUNLVText(HandleRef handle)
        {
            IntPtr txtHandle = TessApi.NativeTess.BaseApiGetUNLVTextInternal(handle);
            if (txtHandle != IntPtr.Zero)
            {
                var result = MarshalHelper.PtrToString(txtHandle, Encoding.UTF8);
                TessApi.NativeTess.DeleteText(txtHandle);
                return result;
            }
            else
            {
                return null;
            }
        }

        public static string? BaseApiGetStringVariable(HandleRef handle, string name)
        {
            var resultHandle = TessApi.NativeTess.BaseApiGetStringVariableInternal(handle, name);
            if (resultHandle != IntPtr.Zero)
            {
                return MarshalHelper.PtrToString(resultHandle, Encoding.UTF8);
            }
            else
            {
                return null;
            }
        }

        public static string? BaseAPIGetUTF8Text(HandleRef handle)
        {
            IntPtr txtHandle = TessApi.NativeTess.BaseAPIGetUTF8TextInternal(handle);
            if (txtHandle != IntPtr.Zero)
            {
                var result = MarshalHelper.PtrToString(txtHandle, Encoding.UTF8);
                TessApi.NativeTess.DeleteText(txtHandle);
                return result;
            }
            else
            {
                return null;
            }
        }

        public static int BaseApiInit(
            HandleRef handle,
            string datapath,
            string language,
            int mode,
            IEnumerable<string> configFiles,
            IDictionary<string, object> initialValues,
            bool setOnlyNonDebugParams
        )
        {
            Guard.Require(
                "handle",
                handle.Handle != IntPtr.Zero,
                "Handle for BaseApi, created through BaseApiCreate is required."
            );
            Guard.RequireNotNullOrEmpty("language", language);
            Guard.RequireNotNull("configFiles", configFiles);
            Guard.RequireNotNull("initialValues", initialValues);

            string[] configFilesArray = new List<string>(configFiles).ToArray();

            string[] varNames = new string[initialValues.Count];
            string[] varValues = new string[initialValues.Count];
            int i = 0;
            foreach (var pair in initialValues)
            {
                Guard.Require(
                    "initialValues",
                    !String.IsNullOrEmpty(pair.Key),
                    "Variable must have a name."
                );

                Guard.Require(
                    "initialValues",
                    pair.Value != null,
                    "Variable '{0}': The type '{1}' is not supported.",
                    pair.Key,
                    pair.Value!.GetType()
                );
                varNames[i] = pair.Key;
                string varValue;
                if (TessConvert.TryToString(pair.Value, out varValue))
                {
                    varValues[i] = varValue;
                }
                else
                {
                    throw new ArgumentException(
                        String.Format(
                            "Variable '{0}': The type '{1}' is not supported.",
                            pair.Key,
                            pair.Value.GetType()
                        ),
                        "initialValues"
                    );
                }
                i++;
            }

            return TessApi.NativeTess.BaseApiInit(
                handle,
                datapath,
                language,
                mode,
                configFilesArray,
                configFilesArray.Length,
                varNames,
                varValues,
                new UIntPtr((uint)varNames.Length),
                setOnlyNonDebugParams
            );
        }

        public static int BaseApiSetDebugVariable(HandleRef handle, string name, string value)
        {
            IntPtr valuePtr = IntPtr.Zero;
            try
            {
                valuePtr = MarshalHelper.StringToPtr(value, Encoding.UTF8);
                return TessApi.NativeTess.BaseApiSetDebugVariable(handle, name, valuePtr);
            }
            finally
            {
                if (valuePtr != IntPtr.Zero)
                {
                    Marshal.FreeHGlobal(valuePtr);
                }
            }
        }

        public static int BaseApiSetVariable(HandleRef handle, string name, string value)
        {
            IntPtr valuePtr = IntPtr.Zero;
            try
            {
                valuePtr = MarshalHelper.StringToPtr(value, Encoding.UTF8);
                return TessApi.NativeTess.BaseApiSetVariable(handle, name, valuePtr);
            }
            finally
            {
                if (valuePtr != IntPtr.Zero)
                {
                    Marshal.FreeHGlobal(valuePtr);
                }
            }
        }

        public static string? ResultIteratorWordRecognitionLanguage(HandleRef handle)
        {
            // per docs (ltrresultiterator.h:118 as of 4897796 in github:tesseract-ocr/tesseract)
            // this return value should *NOT* be deleted.
            IntPtr txtHandle = TessApi.NativeTess.ResultIteratorWordRecognitionLanguageInternal(
                handle
            );

            return txtHandle != IntPtr.Zero
                ? MarshalHelper.PtrToString(txtHandle, Encoding.UTF8)
                : null;
        }

        public static string? ResultIteratorGetUTF8Text(HandleRef handle, PageIteratorLevel level)
        {
            IntPtr txtHandle = TessApi.NativeTess.ResultIteratorGetUTF8TextInternal(handle, level);
            if (txtHandle != IntPtr.Zero)
            {
                var result = MarshalHelper.PtrToString(txtHandle, Encoding.UTF8);
                TessApi.NativeTess.DeleteText(txtHandle);
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Returns the null terminated UTF-8 encoded text string for the current choice
        /// </summary>
        /// <remarks>
        /// NOTE: Unlike LTRResultIterator::GetUTF8Text, the return points to an
        /// internal structure and should NOT be delete[]ed to free after use.
        /// </remarks>
        /// <param name="choiceIteratorHandle"></param>
        /// <returns>string</returns>
        internal static string ChoiceIteratorGetUTF8Text(HandleRef choiceIteratorHandle)
        {
            Guard.Require(
                "choiceIteratorHandle",
                choiceIteratorHandle.Handle != IntPtr.Zero,
                "ChoiceIterator Handle cannot be a null IntPtr and is required"
            );
            IntPtr txtChoiceHandle = TessApi.NativeTess.ChoiceIteratorGetUTF8TextInternal(
                choiceIteratorHandle
            );
            return MarshalHelper.PtrToString(txtChoiceHandle, Encoding.UTF8);
        }

        // hOCR Extension
    }
}
