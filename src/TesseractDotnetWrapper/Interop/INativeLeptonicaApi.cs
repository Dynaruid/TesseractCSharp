using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace TesseractDotnetWrapper.Interop
{
    public interface INativeLeptonicaApi
    {
        #region PixA
        IntPtr pixaReadMultipageTiff(string filename);
        IntPtr pixaCreate(int n);
        int pixaAddPix(HandleRef pixa, HandleRef pix, PixArrayAccessType copyflag);
        IntPtr pixaGetPix(HandleRef pixa, int index, PixArrayAccessType accesstype);
        int pixaRemovePix(HandleRef pixa, int index);
        int pixaClear(HandleRef pixa);
        int pixaGetCount(HandleRef pixa);
        void pixaDestroy(ref IntPtr pix);
        #endregion
        #region Pix
        unsafe IntPtr pixCreate(int width, int height, int depth);
        unsafe IntPtr pixClone(HandleRef pix);
        void pixDestroy(ref IntPtr pix);
        int pixEqual(HandleRef pix1, HandleRef pix2, out int same);
        int pixGetWidth(HandleRef pix);
        int pixGetHeight(HandleRef pix);
        int pixGetDepth(HandleRef pix);
        int pixGetXRes(HandleRef pix);
        int pixGetYRes(HandleRef pix);
        int pixGetResolution(HandleRef pix, out int xres, out int yres);
        int pixGetWpl(HandleRef pix);
        int pixSetXRes(HandleRef pix, int xres);
        int pixSetYRes(HandleRef pix, int yres);
        int pixSetResolution(HandleRef pix, int xres, int yres);
        int pixScaleResolution(HandleRef pix, float xscale, float yscale);
        IntPtr pixGetData(HandleRef pix);
        ImageFormat pixGetInputFormat(HandleRef pix);
        int pixSetInputFormat(HandleRef pix, ImageFormat inputFormat);
        int pixEndianByteSwap(HandleRef pix);
        IntPtr pixRead(string filename);
        unsafe IntPtr pixReadMem(byte* data, int length);
        unsafe IntPtr pixReadMemTiff(byte* data, int length, int page);
        IntPtr pixReadFromMultipageTiff(string filename, ref int offset);
        int pixWrite(string filename, HandleRef handle, ImageFormat format);
        int pixDisplayWrite(HandleRef pixs, int reduction);
        IntPtr pixGetColormap(HandleRef pix);
        int pixSetColormap(HandleRef pix, HandleRef pixCmap);
        int pixDestroyColormap(HandleRef pix);

        IntPtr pixConvertRGBToGray(HandleRef pix, float rwt, float gwt, float bwt);
        IntPtr pixConvertTo8(HandleRef pix, int cmapflag);

        IntPtr pixDeskewGeneral(
            HandleRef pix,
            int redSweep,
            float sweepRange,
            float sweepDelta,
            int redSearch,
            int thresh,
            out float pAngle,
            out float pConf
        );
        int pixFindSkew(HandleRef pixs, out float pangle, out float pconf);

        IntPtr pixRotate(
            HandleRef pixs,
            float angle,
            RotationMethod type,
            RotationFill fillColor,
            int width,
            int heigh
        );
        IntPtr pixRotateOrth(HandleRef pixs, int quads);
        IntPtr pixRotateAMGray(HandleRef pixs, float angle, byte grayval);
        IntPtr pixRotate90(HandleRef pixs, int direction);

        IntPtr pixCloseGray(HandleRef pixs, int hsize, int vsize);
        IntPtr pixErodeGray(HandleRef pixs, int hsize, int vsize);
        IntPtr pixAddGray(HandleRef pixd, HandleRef pixs1, HandleRef pixs2);
        IntPtr pixOpenGray(HandleRef pixs, int hsize, int vsize);
        int pixCombineMasked(HandleRef pixd, HandleRef pixs, HandleRef pixm);

        IntPtr pixThresholdToValue(HandleRef pixd, HandleRef pixs, int threshval, int setval);
        IntPtr pixThresholdToBinary(HandleRef pixs, int thresh);
        IntPtr pixInvert(HandleRef pixd, HandleRef pixs);
        IntPtr pixBackgroundNormFlex(
            HandleRef pixs,
            int sx,
            int sy,
            int smoothx,
            int smoothy,
            int delta
        );
        IntPtr pixGammaTRCMasked(
            HandleRef pixd,
            HandleRef pixs,
            HandleRef pixm,
            float gamma,
            int minval,
            int maxval
        );
        IntPtr pixHMT(HandleRef pixd, HandleRef pixs, HandleRef sel);
        IntPtr pixDilate(HandleRef pixd, HandleRef pixs, HandleRef sel);
        IntPtr pixSubtract(HandleRef pixd, HandleRef pixs1, HandleRef pixs2);

        IntPtr selCreateFromString(string text, int h, int w, string name);
        IntPtr selCreateBrick(int h, int w, int cy, int cx, SelType type);
        void selDestroy(ref IntPtr psel);

        int pixOtsuAdaptiveThreshold(
            HandleRef pix,
            int sx,
            int sy,
            int smoothx,
            int smoothy,
            float scorefract,
            out IntPtr ppixth,
            out IntPtr ppixd
        );
        int pixSauvolaBinarize(
            HandleRef pix,
            int whsize,
            float factor,
            int addborder,
            out IntPtr ppixm,
            out IntPtr ppixsd,
            out IntPtr ppixth,
            out IntPtr ppixd
        );
        int pixSauvolaBinarizeTiled(
            HandleRef pix,
            int whsize,
            float factor,
            int nx,
            int ny,
            out IntPtr ppixth,
            out IntPtr ppixd
        );

        IntPtr pixScale(HandleRef pixs, float scalex, float scaley);
        #endregion
        #region Color map

        IntPtr pixcmapCreate(int depth);
        IntPtr pixcmapCreateRandom(int depth, int hasBlack, int hasWhite);
        IntPtr pixcmapCreateLinear(int depth, int levels);
        IntPtr pixcmapCopy(HandleRef cmaps);
        void pixcmapDestroy(ref IntPtr cmap);

        int pixcmapGetCount(HandleRef cmap);
        int pixcmapGetFreeCount(HandleRef cmap);
        int pixcmapGetDepth(HandleRef cmap);
        int pixcmapGetMinDepth(HandleRef cmap, out int minDepth);

        int pixcmapClear(HandleRef cmap);
        int pixcmapAddColor(HandleRef cmap, int redValue, int greenValue, int blueValue);
        int pixcmapAddNewColor(
            HandleRef cmap,
            int redValue,
            int greenValue,
            int blueValue,
            out int colorIndex
        );
        int pixcmapAddNearestColor(
            HandleRef cmap,
            int redValue,
            int greenValue,
            int blueValue,
            out int colorIndex
        );
        int pixcmapUsableColor(
            HandleRef cmap,
            int redValue,
            int greenValue,
            int blueValue,
            out int usable
        );
        int pixcmapAddBlackOrWhite(HandleRef cmap, int color, out int index);
        int pixcmapSetBlackAndWhite(HandleRef cmap, int setBlack, int setWhite);

        int pixcmapGetColor(
            HandleRef cmap,
            int index,
            out int redValue,
            out int blueValue,
            out int greenValue
        );
        int pixcmapGetColor32(HandleRef cmap, int index, out int color);
        int pixcmapResetColor(
            HandleRef cmap,
            int index,
            int redValue,
            int blueValue,
            int greenValue
        );
        int pixcmapGetIndex(
            HandleRef cmap,
            int redValue,
            int blueValue,
            int greenValue,
            out int index
        );
        int pixcmapHasColor(HandleRef cmap, int color);
        int pixcmapCountGrayColors(HandleRef cmap, out int ngray);
        int pixcmapGetRankIntensity(HandleRef cmap, float rankVal, out int index);
        int pixcmapGetNearestIndex(HandleRef cmap, int rVal, int bVal, int gVal, out int index);
        int pixcmapGetNearestGrayIndex(HandleRef cmap, int val, out int index);

        IntPtr pixcmapGrayToColor(int color);
        IntPtr pixcmapColorToGray(
            HandleRef cmaps,
            float redWeight,
            float greenWeight,
            float blueWeight
        );

        int pixcmapToArrays(
            HandleRef cmap,
            out IntPtr redMap,
            out IntPtr blueMap,
            out IntPtr greenMap
        );
        int pixcmapToRGBTable(HandleRef cmap, out IntPtr colorTable, out int colorCount);
        int pixcmapSerializeToMemory(
            HandleRef cmap,
            out int components,
            out int colorCount,
            out IntPtr colorData,
            out int colorDataLength
        );
        IntPtr pixcmapDeserializeFromMemory(
            HandleRef colorData,
            int colorCount,
            int colorDataLength
        );

        int pixcmapGammaTRC(HandleRef cmap, float gamma, int minVal, int maxVal);
        int pixcmapContrastTRC(HandleRef cmap, float factor);
        int pixcmapShiftIntensity(HandleRef cmap, float fraction);
        #endregion
        #region Box
        int boxaGetCount(HandleRef boxa);
        IntPtr boxaGetBox(HandleRef boxa, int index, PixArrayAccessType accesstype);
        int boxGetGeometry(HandleRef box, out int px, out int py, out int pw, out int ph);
        void boxDestroy(ref IntPtr box);
        void boxaDestroy(ref IntPtr box);

        #endregion
    }
}
