using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace TesseractDotnetWrapper.Interop
{
    /// <summary>
    /// The exported leptonica api signatures.
    /// </summary>
    /// <remarks>
    /// Please note this is only public for technical reasons (you can't proxy a internal interface).
    /// It should be considered an internal interface and is NOT part of the public api and may have
    /// breaking changes between releases.
    /// </remarks>
    public class NativeLeptonicaApiSignatures
    {
        #region PixA

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixaReadMultipageTiff"
        )]
        public static extern IntPtr pixaReadMultipageTiff(string filename);

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixaCreate"
        )]
        public static extern IntPtr pixaCreate(int n);

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixaAddPix"
        )]
        public static extern int pixaAddPix(
            HandleRef pixa,
            HandleRef pix,
            PixArrayAccessType copyflag
        );

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixaGetPix"
        )]
        public static extern IntPtr pixaGetPix(
            HandleRef pixa,
            int index,
            PixArrayAccessType accesstype
        );

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixaRemovePix"
        )]
        public static extern int pixaRemovePix(HandleRef pixa, int index);

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixaClear"
        )]
        public static extern int pixaClear(HandleRef pixa);

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixaGetCount"
        )]
        public static extern int pixaGetCount(HandleRef pixa);

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixaDestroy"
        )]
        public static extern void pixaDestroy(ref IntPtr pix);

        #endregion

        #region Pix

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixCreate"
        )]
        public static extern unsafe IntPtr pixCreate(int width, int height, int depth);

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixClone"
        )]
        public static extern unsafe IntPtr pixClone(HandleRef pix);

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixDestroy"
        )]
        public static extern void pixDestroy(ref IntPtr pix);

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixEqual"
        )]
        public static extern int pixEqual(HandleRef pix1, HandleRef pix2, out int same);

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixGetWidth"
        )]
        public static extern int pixGetWidth(HandleRef pix);

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixGetHeight"
        )]
        public static extern int pixGetHeight(HandleRef pix);

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixGetDepth"
        )]
        public static extern int pixGetDepth(HandleRef pix);

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixGetXRes"
        )]
        public static extern int pixGetXRes(HandleRef pix);

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixGetYRes"
        )]
        public static extern int pixGetYRes(HandleRef pix);

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixGetResolution"
        )]
        public static extern int pixGetResolution(HandleRef pix, out int xres, out int yres);

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixGetWpl"
        )]
        public static extern int pixGetWpl(HandleRef pix);

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixSetXRes"
        )]
        public static extern int pixSetXRes(HandleRef pix, int xres);

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixSetYRes"
        )]
        public static extern int pixSetYRes(HandleRef pix, int yres);

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixSetResolution"
        )]
        public static extern int pixSetResolution(HandleRef pix, int xres, int yres);

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixScaleResolution"
        )]
        public static extern int pixScaleResolution(HandleRef pix, float xscale, float yscale);

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixGetData"
        )]
        public static extern IntPtr pixGetData(HandleRef pix);

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixGetInputFormat"
        )]
        public static extern ImageFormat pixGetInputFormat(HandleRef pix);

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixSetInputFormat"
        )]
        public static extern int pixSetInputFormat(HandleRef pix, ImageFormat inputFormat);

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixEndianByteSwap"
        )]
        public static extern int pixEndianByteSwap(HandleRef pix);

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixRead"
        )]
        public static extern IntPtr pixRead(string filename);

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixReadMem"
        )]
        public static extern unsafe IntPtr pixReadMem(byte* data, int length);

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixReadMemTiff"
        )]
        public static extern unsafe IntPtr pixReadMemTiff(byte* data, int length, int page);

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixReadFromMultipageTiff"
        )]
        public static extern IntPtr pixReadFromMultipageTiff(string filename, ref int offset);

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixWrite"
        )]
        public static extern int pixWrite(string filename, HandleRef handle, ImageFormat format);

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixDisplayWrite"
        )]
        public static extern int pixDisplayWrite(HandleRef pixs, int reduction);

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixGetColormap"
        )]
        public static extern IntPtr pixGetColormap(HandleRef pix);

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixSetColormap"
        )]
        public static extern int pixSetColormap(HandleRef pix, HandleRef pixCmap);

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixDestroyColormap"
        )]
        public static extern int pixDestroyColormap(HandleRef pix);

        // pixconv.h functions

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixConvertRGBToGray"
        )]
        public static extern IntPtr pixConvertRGBToGray(
            HandleRef pix,
            float rwt,
            float gwt,
            float bwt
        );

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixConvertTo8"
        )]
        public static extern IntPtr pixConvertTo8(HandleRef pix, int cmapflag);

        // image analysis and manipulation functions

        // skew

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixDeskewGeneral"
        )]
        public static extern IntPtr pixDeskewGeneral(
            HandleRef pix,
            int redSweep,
            float sweepRange,
            float sweepDelta,
            int redSearch,
            int thresh,
            out float pAngle,
            out float pConf
        );

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixFindSkew"
        )]
        public static extern int pixFindSkew(HandleRef pixs, out float pangle, out float pconf);

        // rotation

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixRotate"
        )]
        public static extern IntPtr pixRotate(
            HandleRef pixs,
            float angle,
            RotationMethod type,
            RotationFill fillColor,
            int width,
            int heigh
        );

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixRotateOrth"
        )]
        public static extern IntPtr pixRotateOrth(HandleRef pixs, int quads);

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixRotateAMGray"
        )]
        public static extern IntPtr pixRotateAMGray(HandleRef pixs, float angle, byte grayval);

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixRotate90"
        )]
        public static extern IntPtr pixRotate90(HandleRef pixs, int direction);

        // Grayscale

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixCloseGray"
        )]
        public static extern IntPtr pixCloseGray(HandleRef pixs, int hsize, int vsize);

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixErodeGray"
        )]
        public static extern IntPtr pixErodeGray(HandleRef pixs, int hsize, int vsize);

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixAddGray"
        )]
        public static extern IntPtr pixAddGray(HandleRef pixd, HandleRef pixs1, HandleRef pixs2);

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixOpenGray"
        )]
        public static extern IntPtr pixOpenGray(HandleRef pixs, int hsize, int vsize);

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixCombineMasked"
        )]
        public static extern int pixCombineMasked(HandleRef pixd, HandleRef pixs, HandleRef pixm);

        // Threshold

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixThresholdToValue"
        )]
        public static extern IntPtr pixThresholdToValue(
            HandleRef pixd,
            HandleRef pixs,
            int threshval,
            int setval
        );

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixThresholdToBinary"
        )]
        public static extern IntPtr pixThresholdToBinary(HandleRef pixs, int thresh);

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixInvert"
        )]
        public static extern IntPtr pixInvert(HandleRef pixd, HandleRef pixs);

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixBackgroundNormFlex"
        )]
        public static extern IntPtr pixBackgroundNormFlex(
            HandleRef pixs,
            int sx,
            int sy,
            int smoothx,
            int smoothy,
            int delta
        );

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixGammaTRCMasked"
        )]
        public static extern IntPtr pixGammaTRCMasked(
            HandleRef pixd,
            HandleRef pixs,
            HandleRef pixm,
            float gamma,
            int minval,
            int maxval
        );

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixHMT"
        )]
        public static extern IntPtr pixHMT(HandleRef pixd, HandleRef pixs, HandleRef sel);

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixDilate"
        )]
        public static extern IntPtr pixDilate(HandleRef pixd, HandleRef pixs, HandleRef sel);

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixSubtract"
        )]
        public static extern IntPtr pixSubtract(HandleRef pixd, HandleRef pixs1, HandleRef pixs2);

        // Sel

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "selCreateFromString"
        )]
        public static extern IntPtr selCreateFromString(string text, int h, int w, string name);

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "selCreateBrick"
        )]
        public static extern IntPtr selCreateBrick(int h, int w, int cy, int cx, SelType type);

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "selDestroy"
        )]
        public static extern void selDestroy(ref IntPtr psel);

        // Binarization - src/binarize.c

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixOtsuAdaptiveThreshold"
        )]
        public static extern int pixOtsuAdaptiveThreshold(
            HandleRef pix,
            int sx,
            int sy,
            int smoothx,
            int smoothy,
            float scorefract,
            out IntPtr ppixth,
            out IntPtr ppixd
        );

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixSauvolaBinarize"
        )]
        public static extern int pixSauvolaBinarize(
            HandleRef pix,
            int whsize,
            float factor,
            int addborder,
            out IntPtr ppixm,
            out IntPtr ppixsd,
            out IntPtr ppixth,
            out IntPtr ppixd
        );

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixSauvolaBinarizeTiled"
        )]
        public static extern int pixSauvolaBinarizeTiled(
            HandleRef pix,
            int whsize,
            float factor,
            int nx,
            int ny,
            out IntPtr ppixth,
            out IntPtr ppixd
        );

        // Scaling - src/scale.c

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixScale"
        )]
        public static extern IntPtr pixScale(HandleRef pixs, float scalex, float scaley);

        #endregion

        #region Color map

        // Color map creation and deletion

        /// <summary>
        /// Creates a new colormap with the specified <paramref name="depth"/>.
        /// </summary>
        /// <param name="depth">The depth of the pix in bpp, can be 2, 4, or 8</param>
        /// <returns>The pointer to the color map, or null on error.</returns>
        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixcmapCreate"
        )]
        public static extern IntPtr pixcmapCreate(int depth);

        /// <summary>
        /// Creates a new colormap of the specified <paramref name="depth"/> with random colors where the first color can optionally be set to black, and the last optionally set to white.
        /// </summary>
        /// <param name="depth">The depth of the pix in bpp, can be 2, 4, or 8</param>
        /// <param name="hasBlack">If set to 1 the first color will be black.</param>
        /// <param name="hasWhite">If set to 1 the last color will be white.</param>
        /// <returns>The pointer to the color map, or null on error.</returns>
        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixcmapCreateRandom"
        )]
        public static extern IntPtr pixcmapCreateRandom(int depth, int hasBlack, int hasWhite);

        /// <summary>
        /// Creates a new colormap of the specified <paramref name="depth"/> with equally spaced gray color values.
        /// </summary>
        /// <param name="depth">The depth of the pix in bpp, can be 2, 4, or 8</param>
        /// <param name="levels">The number of levels (must be between 2 and 2^<paramref name="depth"/></param>
        /// <returns>The pointer to the colormap, or null on error.</returns>
        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixcmapCreateLinear"
        )]
        public static extern IntPtr pixcmapCreateLinear(int depth, int levels);

        /// <summary>
        /// Performs a deep copy of the color map.
        /// </summary>
        /// <param name="cmaps">The pointer to the colormap instance.</param>
        /// <returns>The pointer to the colormap, or null on error.</returns>
        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixcmapCopy"
        )]
        public static extern IntPtr pixcmapCopy(HandleRef cmaps);

        /// <summary>
        /// Destorys and cleans up any memory used by the color map.
        /// </summary>
        /// <param name="cmap">The pointer to the colormap instance, set to null on success.</param>
        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixcmapDestroy"
        )]
        public static extern void pixcmapDestroy(ref IntPtr cmap);

        // colormap metadata (depth, count, etc)

        /// <summary>
        /// Gets the number of color entries in the color map.
        /// </summary>
        /// <param name="cmap">The pointer to the colormap instance.</param>
        /// <returns>Returns the number of color entries in the color map, or 0 on error.</returns>
        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixcmapGetCount"
        )]
        public static extern int pixcmapGetCount(HandleRef cmap);

        /// <summary>
        /// Gets the number of free color entries in the color map.
        /// </summary>
        /// <param name="cmap">The pointer to the colormap instance.</param>
        /// <returns>Returns the number of free color entries in the color map, or 0 on error.</returns>
        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixcmapGetFreeCount"
        )]
        public static extern int pixcmapGetFreeCount(HandleRef cmap);

        /// <returns>Returns color maps depth, or 0 on error.</returns>
        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixcmapGetDepth"
        )]
        public static extern int pixcmapGetDepth(HandleRef cmap);

        /// <summary>
        /// Gets the minimum pix depth required to support the color map.
        /// </summary>
        /// <param name="cmap">The pointer to the colormap instance.</param>
        /// <param name="minDepth">Returns the minimum depth to support the colormap</param>
        /// <returns>Returns 0 if OK, 1 on error.</returns>
        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixcmapGetMinDepth"
        )]
        public static extern int pixcmapGetMinDepth(HandleRef cmap, out int minDepth);

        // colormap - color addition\clearing

        /// <summary>
        /// Removes all colors from the color map by setting the count to zero.
        /// </summary>
        /// <param name="cmap">The pointer to the colormap instance.</param>
        /// <returns>Returns 0 if OK, 1 on error.</returns>
        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixcmapClear"
        )]
        public static extern int pixcmapClear(HandleRef cmap);

        /// <summary>
        /// Adds the color to the pix color map if their is room.
        /// </summary>
        /// <returns>Returns 0 if OK, 1 on error.</returns>
        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixcmapAddColor"
        )]
        public static extern int pixcmapAddColor(
            HandleRef cmap,
            int redValue,
            int greenValue,
            int blueValue
        );

        /// <summary>
        /// Adds the specified color if it doesn't already exist, returning the colors index in the data array.
        /// </summary>
        /// <param name="cmap">The pointer to the colormap instance.</param>
        /// <param name="redValue">The red value</param>
        /// <param name="greenValue">The green value</param>
        /// <param name="blueValue">The blue value</param>
        /// <param name="colorIndex">The index of the new color if it was added, or the existing color if it already existed.</param>
        /// <returns>Returns 0 for success, 1 for error, 2 for not enough space.</returns>
        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixcmapAddNewColor"
        )]
        public static extern int pixcmapAddNewColor(
            HandleRef cmap,
            int redValue,
            int greenValue,
            int blueValue,
            out int colorIndex
        );

        /// <summary>
        /// Adds the specified color if it doesn't already exist, returning the color's index in the data array.
        /// </summary>
        /// <remarks>
        /// If the color doesn't exist and there is not enough room to add a new color return the nearest color.
        /// </remarks>
        /// <param name="cmap">The pointer to the colormap instance.</param>
        /// <param name="redValue">The red value</param>
        /// <param name="greenValue">The green value</param>
        /// <param name="blueValue">The blue value</param>
        /// <param name="colorIndex">The index of the new color if it was added, or the existing color if it already existed.</param>
        /// <returns>Returns 0 for success, 1 for error, 2 for not enough space.</returns>
        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixcmapAddNearestColor"
        )]
        public static extern int pixcmapAddNearestColor(
            HandleRef cmap,
            int redValue,
            int greenValue,
            int blueValue,
            out int colorIndex
        );

        /// <summary>
        /// Checks if the color already exists or if their is enough room to add it.
        /// </summary>
        /// <param name="cmap">The pointer to the colormap instance.</param>
        /// <param name="redValue">The red value</param>
        /// <param name="greenValue">The green value</param>
        /// <param name="blueValue">The blue value</param>
        /// <param name="usable">Returns 1 if usable; 0 if not.</param>
        /// <returns>Returns 0 if OK, 1 on error.</returns>
        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixcmapUsableColor"
        )]
        public static extern int pixcmapUsableColor(
            HandleRef cmap,
            int redValue,
            int greenValue,
            int blueValue,
            out int usable
        );

        /// <summary>
        /// Adds a color (black\white) if not already there returning it's index through <paramref name="index"/>.
        /// </summary>
        /// <param name="cmap">The pointer to the colormap instance.</param>
        /// <param name="color">The color to add (0 for black; 1 for white)</param>
        /// <param name="index">The index of the color.</param>
        /// <returns>Returns 0 if OK; 1 on error.</returns>
        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixcmapAddBlackOrWhite"
        )]
        public static extern int pixcmapAddBlackOrWhite(HandleRef cmap, int color, out int index);

        /// <summary>
        /// Sets the darkest color in the colormap to black, if <paramref name="setBlack"/> is 1.
        /// Sets the lightest color in the colormap to white if <paramref name="setWhite"/> is 1.
        /// </summary>
        /// <param name="cmap">The pointer to the colormap instance.</param>
        /// <param name="setBlack">0 for no operation; 1 to set darket color to black</param>
        /// <param name="setWhite">0 for no operation; 1 to set lightest color to white</param>
        /// <returns>Returns 0 if OK; 1 on error.</returns>
        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixcmapSetBlackAndWhite"
        )]
        public static extern int pixcmapSetBlackAndWhite(
            HandleRef cmap,
            int setBlack,
            int setWhite
        );

        // color access - color entry access

        /// <summary>
        /// Gets the color at the specified index.
        /// </summary>
        /// <param name="cmap">The pointer to the colormap instance.</param>
        /// <param name="index">The index of the color entry.</param>
        /// <param name="redValue">The color entry's red value.</param>
        /// <param name="blueValue">The color entry's blue value.</param>
        /// <param name="greenValue">The color entry's green value.</param>
        /// <returns>Returns 0 if OK; 1 if not accessable (caller should check).</returns>
        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixcmapGetColor"
        )]
        public static extern int pixcmapGetColor(
            HandleRef cmap,
            int index,
            out int redValue,
            out int blueValue,
            out int greenValue
        );

        /// <summary>
        /// Gets the color at the specified index.
        /// </summary>
        /// <remarks>
        /// The alpha channel will always be zero as it is not used in Leptonica color maps.
        /// </remarks>
        /// <param name="cmap">The pointer to the colormap instance.</param>
        /// <param name="index">The index of the color entry.</param>
        /// <param name="color">The color entry as 32 bit value</param>
        /// <returns>Returns 0 if OK; 1 if not accessable (caller should check).</returns>
        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixcmapGetColor32"
        )]
        public static extern int pixcmapGetColor32(HandleRef cmap, int index, out int color);

        /// <summary>
        /// Sets a previously allocated color entry.
        /// </summary>
        /// <param name="cmap">The pointer to the colormap instance.</param>
        /// <param name="index">The index of the colormap entry</param>
        /// <param name="redValue"></param>
        /// <param name="blueValue"></param>
        /// <param name="greenValue"></param>
        /// <returns>Returns 0 if OK; 1 if not accessable (caller should check).</returns>
        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixcmapResetColor"
        )]
        public static extern int pixcmapResetColor(
            HandleRef cmap,
            int index,
            int redValue,
            int blueValue,
            int greenValue
        );

        /// <summary>
        /// Gets the index of the color entry with the specified color, return 0 if found; 1 if not.
        /// </summary>
        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixcmapGetIndex"
        )]
        public static extern int pixcmapGetIndex(
            HandleRef cmap,
            int redValue,
            int blueValue,
            int greenValue,
            out int index
        );

        /// <summary>
        /// Returns 0 if the color exists in the color map; otherwise 1.
        /// </summary>
        /// <returns>Returns 0 if OK; 1 on error.</returns>
        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixcmapHasColor"
        )]
        public static extern int pixcmapHasColor(HandleRef cmap, int color);

        /// <summary>
        /// Returns the number of unique grey colors including black and white.
        /// </summary>
        /// <returns>Returns 0 if OK; 1 on error.</returns>
        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixcmapCountGrayColors"
        )]
        public static extern int pixcmapCountGrayColors(HandleRef cmap, out int ngray);

        /// <summary>
        /// Finds the index of the color entry with the rank intensity.
        /// </summary>
        /// <returns>Returns 0 if OK; 1 on error.</returns>
        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixcmapCountGrayColors"
        )]
        public static extern int pixcmapGetRankIntensity(
            HandleRef cmap,
            float rankVal,
            out int index
        );

        /// <summary>
        /// Finds the index of the color entry closest to the specified color.
        /// </summary>
        /// <returns>Returns 0 if OK; 1 on error.</returns>
        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixcmapGetNearestIndex"
        )]
        public static extern int pixcmapGetNearestIndex(
            HandleRef cmap,
            int rVal,
            int bVal,
            int gVal,
            out int index
        );

        /// <summary>
        /// Finds the index of the color entry closest to the specified color.
        /// </summary>
        /// <remarks>
        /// Should only be used on gray colormaps.
        /// </remarks>
        /// <returns>Returns 0 if OK; 1 on error.</returns>
        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixcmapGetNearestGrayIndex"
        )]
        public static extern int pixcmapGetNearestGrayIndex(HandleRef cmap, int val, out int index);

        // color map conversion

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixcmapGrayToColor"
        )]
        public static extern IntPtr pixcmapGrayToColor(int color);

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixcmapColorToGray"
        )]
        public static extern IntPtr pixcmapColorToGray(
            HandleRef cmaps,
            float redWeight,
            float greenWeight,
            float blueWeight
        );

        // colormap serialization

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixcmapColorToGray"
        )]
        public static extern int pixcmapToArrays(
            HandleRef cmap,
            out IntPtr redMap,
            out IntPtr blueMap,
            out IntPtr greenMap
        );

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixcmapToRGBTable"
        )]
        public static extern int pixcmapToRGBTable(
            HandleRef cmap,
            out IntPtr colorTable,
            out int colorCount
        );

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixcmapSerializeToMemory"
        )]
        public static extern int pixcmapSerializeToMemory(
            HandleRef cmap,
            out int components,
            out int colorCount,
            out IntPtr colorData,
            out int colorDataLength
        );

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixcmapDeserializeFromMemory"
        )]
        public static extern IntPtr pixcmapDeserializeFromMemory(
            HandleRef colorData,
            int colorCount,
            int colorDataLength
        );

        // colormap transformations

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixcmapGammaTRC"
        )]
        public static extern int pixcmapGammaTRC(
            HandleRef cmap,
            float gamma,
            int minVal,
            int maxVal
        );

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixcmapContrastTRC"
        )]
        public static extern int pixcmapContrastTRC(HandleRef cmap, float factor);

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "pixcmapShiftIntensity"
        )]
        public static extern int pixcmapShiftIntensity(HandleRef cmap, float fraction);

        #endregion

        #region Box

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "boxaGetCount"
        )]
        public static extern int boxaGetCount(HandleRef boxa);

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "boxaGetBox"
        )]
        public static extern IntPtr boxaGetBox(
            HandleRef boxa,
            int index,
            PixArrayAccessType accesstype
        );

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "boxGetGeometry"
        )]
        public static extern int boxGetGeometry(
            HandleRef box,
            out int px,
            out int py,
            out int pw,
            out int ph
        );

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "boxDestroy"
        )]
        public static extern void boxDestroy(ref IntPtr box);

        [DllImport(
            Constants.LeptonicaDllName,
            CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "boxaDestroy"
        )]
        public static extern void boxaDestroy(ref IntPtr box);

        #endregion
    }
}
