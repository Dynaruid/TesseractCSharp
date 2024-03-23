using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using TesseractCSharp.Interop;

namespace TesseractCSharp
{
    /// <summary>
    /// Represents a colormap.
    /// </summary>
    /// <remarks>
    /// Once the colormap is assigned to a pix it is owned by that pix and will be disposed off automatically
    /// when the pix is disposed off.
    /// </remarks>
    public sealed class PixColormap : IDisposable
    {
        private HandleRef handle;

        internal PixColormap(IntPtr handle)
        {
            this.handle = new HandleRef(this, handle);
        }

        public static PixColormap Create(int depth)
        {
            if (!(depth == 1 || depth == 2 || depth == 4 || depth == 8))
            {
                throw new ArgumentOutOfRangeException("depth", "Depth must be 1, 2, 4, or 8 bpp.");
            }

            var handle = NativeLeptonicaApi.pixcmapCreate(depth);
            if (handle == IntPtr.Zero)
            {
                throw new InvalidOperationException("Failed to create colormap.");
            }
            return new PixColormap(handle);
        }

        public static PixColormap CreateLinear(int depth, int levels)
        {
            if (!(depth == 1 || depth == 2 || depth == 4 || depth == 8))
            {
                throw new ArgumentOutOfRangeException("depth", "Depth must be 1, 2, 4, or 8 bpp.");
            }
            if (levels < 2 || levels > (2 << depth))
                throw new ArgumentOutOfRangeException(
                    "levels",
                    "Depth must be 2 and 2^depth (inclusive)."
                );

            var handle = NativeLeptonicaApi.pixcmapCreateLinear(depth, levels);
            if (handle == IntPtr.Zero)
            {
                throw new InvalidOperationException("Failed to create colormap.");
            }
            return new PixColormap(handle);
        }

        public static PixColormap CreateLinear(int depth, bool firstIsBlack, bool lastIsWhite)
        {
            if (!(depth == 1 || depth == 2 || depth == 4 || depth == 8))
            {
                throw new ArgumentOutOfRangeException("depth", "Depth must be 1, 2, 4, or 8 bpp.");
            }

            var handle = NativeLeptonicaApi.pixcmapCreateRandom(
                depth,
                firstIsBlack ? 1 : 0,
                lastIsWhite ? 1 : 0
            );
            if (handle == IntPtr.Zero)
            {
                throw new InvalidOperationException("Failed to create colormap.");
            }
            return new PixColormap(handle);
        }

        internal HandleRef Handle
        {
            get { return handle; }
        }

        public int Depth
        {
            get { return NativeLeptonicaApi.pixcmapGetDepth(handle); }
        }

        public int Count
        {
            get { return NativeLeptonicaApi.pixcmapGetCount(handle); }
        }

        public int FreeCount
        {
            get { return NativeLeptonicaApi.pixcmapGetFreeCount(handle); }
        }

        public bool AddColor(PixColor color)
        {
            return NativeLeptonicaApi.pixcmapAddColor(
                    handle,
                    color.Red,
                    color.Green,
                    color.Blue
                ) == 0;
        }

        public bool AddNewColor(PixColor color, out int index)
        {
            return NativeLeptonicaApi.pixcmapAddNewColor(
                    handle,
                    color.Red,
                    color.Green,
                    color.Blue,
                    out index
                ) == 0;
        }

        public bool AddNearestColor(PixColor color, out int index)
        {
            return NativeLeptonicaApi.pixcmapAddNearestColor(
                    handle,
                    color.Red,
                    color.Green,
                    color.Blue,
                    out index
                ) == 0;
        }

        public bool AddBlackOrWhite(int color, out int index)
        {
            return NativeLeptonicaApi.pixcmapAddBlackOrWhite(handle, color, out index) == 0;
        }

        public bool SetBlackOrWhite(bool setBlack, bool setWhite)
        {
            return NativeLeptonicaApi.pixcmapSetBlackAndWhite(
                    handle,
                    setBlack ? 1 : 0,
                    setWhite ? 1 : 0
                ) == 0;
        }

        public bool IsUsableColor(PixColor color)
        {
            int usable;
            if (
                NativeLeptonicaApi.pixcmapUsableColor(
                    handle,
                    color.Red,
                    color.Green,
                    color.Blue,
                    out usable
                ) == 0
            )
            {
                return usable == 1;
            }
            else
            {
                throw new InvalidOperationException("Failed to detect if color was usable or not.");
            }
        }

        public void Clear()
        {
            if (NativeLeptonicaApi.pixcmapClear(handle) != 0)
            {
                throw new InvalidOperationException("Failed to clear color map.");
            }
        }

        public PixColor this[int index]
        {
            get
            {
                int color;
                if (NativeLeptonicaApi.pixcmapGetColor32(handle, index, out color) == 0)
                {
                    return PixColor.FromRgb((uint)color);
                }
                else
                {
                    throw new InvalidOperationException("Failed to retrieve color.");
                }
            }
            set
            {
                if (
                    NativeLeptonicaApi.pixcmapResetColor(
                        handle,
                        index,
                        value.Red,
                        value.Green,
                        value.Blue
                    ) != 0
                )
                {
                    throw new InvalidOperationException("Failed to reset color.");
                }
            }
        }

        public void Dispose()
        {
            IntPtr tmpHandle = Handle.Handle;
            NativeLeptonicaApi.pixcmapDestroy(ref tmpHandle);
            this.handle = new HandleRef(this, IntPtr.Zero);
        }
    }
}
