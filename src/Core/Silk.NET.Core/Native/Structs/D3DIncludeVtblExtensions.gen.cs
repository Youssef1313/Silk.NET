// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Core.Native;

public unsafe static class D3DIncludeVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int Open(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, byte* pFileName, void* pParentData, void** ppData, uint* pBytes)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)@this->LpVtbl[0])(@this, IncludeType, pFileName, pParentData, ppData, pBytes);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, byte* pFileName, void* pParentData, void** ppData, ref uint pBytes)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pBytesPtr = &pBytes)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)@this->LpVtbl[0])(@this, IncludeType, pFileName, pParentData, ppData, pBytesPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, byte* pFileName, void* pParentData, ref void* ppData, uint* pBytes)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppDataPtr = &ppData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)@this->LpVtbl[0])(@this, IncludeType, pFileName, pParentData, ppDataPtr, pBytes);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, byte* pFileName, void* pParentData, ref void* ppData, ref uint pBytes)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppDataPtr = &ppData)
        {
            fixed (uint* pBytesPtr = &pBytes)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)@this->LpVtbl[0])(@this, IncludeType, pFileName, pParentData, ppDataPtr, pBytesPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open<T0>(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, byte* pFileName, ref T0 pParentData, void** ppData, uint* pBytes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pParentDataPtr = &pParentData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)@this->LpVtbl[0])(@this, IncludeType, pFileName, pParentDataPtr, ppData, pBytes);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open<T0>(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, byte* pFileName, ref T0 pParentData, void** ppData, ref uint pBytes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pParentDataPtr = &pParentData)
        {
            fixed (uint* pBytesPtr = &pBytes)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)@this->LpVtbl[0])(@this, IncludeType, pFileName, pParentDataPtr, ppData, pBytesPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open<T0>(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, byte* pFileName, ref T0 pParentData, ref void* ppData, uint* pBytes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pParentDataPtr = &pParentData)
        {
            fixed (void** ppDataPtr = &ppData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)@this->LpVtbl[0])(@this, IncludeType, pFileName, pParentDataPtr, ppDataPtr, pBytes);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open<T0>(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, byte* pFileName, ref T0 pParentData, ref void* ppData, ref uint pBytes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pParentDataPtr = &pParentData)
        {
            fixed (void** ppDataPtr = &ppData)
            {
                fixed (uint* pBytesPtr = &pBytes)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)@this->LpVtbl[0])(@this, IncludeType, pFileName, pParentDataPtr, ppDataPtr, pBytesPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, ref byte pFileName, void* pParentData, void** ppData, uint* pBytes)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pFileNamePtr = &pFileName)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)@this->LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentData, ppData, pBytes);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, ref byte pFileName, void* pParentData, void** ppData, ref uint pBytes)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pFileNamePtr = &pFileName)
        {
            fixed (uint* pBytesPtr = &pBytes)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)@this->LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentData, ppData, pBytesPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, ref byte pFileName, void* pParentData, ref void* ppData, uint* pBytes)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pFileNamePtr = &pFileName)
        {
            fixed (void** ppDataPtr = &ppData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)@this->LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentData, ppDataPtr, pBytes);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, ref byte pFileName, void* pParentData, ref void* ppData, ref uint pBytes)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pFileNamePtr = &pFileName)
        {
            fixed (void** ppDataPtr = &ppData)
            {
                fixed (uint* pBytesPtr = &pBytes)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)@this->LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentData, ppDataPtr, pBytesPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open<T0>(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, ref byte pFileName, ref T0 pParentData, void** ppData, uint* pBytes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pFileNamePtr = &pFileName)
        {
            fixed (void* pParentDataPtr = &pParentData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)@this->LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentDataPtr, ppData, pBytes);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open<T0>(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, ref byte pFileName, ref T0 pParentData, void** ppData, ref uint pBytes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pFileNamePtr = &pFileName)
        {
            fixed (void* pParentDataPtr = &pParentData)
            {
                fixed (uint* pBytesPtr = &pBytes)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)@this->LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentDataPtr, ppData, pBytesPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open<T0>(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, ref byte pFileName, ref T0 pParentData, ref void* ppData, uint* pBytes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pFileNamePtr = &pFileName)
        {
            fixed (void* pParentDataPtr = &pParentData)
            {
                fixed (void** ppDataPtr = &ppData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)@this->LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentDataPtr, ppDataPtr, pBytes);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open<T0>(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, ref byte pFileName, ref T0 pParentData, ref void* ppData, ref uint pBytes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pFileNamePtr = &pFileName)
        {
            fixed (void* pParentDataPtr = &pParentData)
            {
                fixed (void** ppDataPtr = &ppData)
                {
                    fixed (uint* pBytesPtr = &pBytes)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)@this->LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentDataPtr, ppDataPtr, pBytesPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFileName, void* pParentData, void** ppData, uint* pBytes)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pFileNamePtr = (byte*) SilkMarshal.StringToPtr(pFileName, NativeStringEncoding.LPStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)@this->LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentData, ppData, pBytes);
        SilkMarshal.Free((nint)pFileNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFileName, void* pParentData, void** ppData, ref uint pBytes)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pFileNamePtr = (byte*) SilkMarshal.StringToPtr(pFileName, NativeStringEncoding.LPStr);
        fixed (uint* pBytesPtr = &pBytes)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)@this->LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentData, ppData, pBytesPtr);
        }
        SilkMarshal.Free((nint)pFileNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFileName, void* pParentData, ref void* ppData, uint* pBytes)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pFileNamePtr = (byte*) SilkMarshal.StringToPtr(pFileName, NativeStringEncoding.LPStr);
        fixed (void** ppDataPtr = &ppData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)@this->LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentData, ppDataPtr, pBytes);
        }
        SilkMarshal.Free((nint)pFileNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFileName, void* pParentData, ref void* ppData, ref uint pBytes)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pFileNamePtr = (byte*) SilkMarshal.StringToPtr(pFileName, NativeStringEncoding.LPStr);
        fixed (void** ppDataPtr = &ppData)
        {
            fixed (uint* pBytesPtr = &pBytes)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)@this->LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentData, ppDataPtr, pBytesPtr);
            }
        }
        SilkMarshal.Free((nint)pFileNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open<T0>(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFileName, ref T0 pParentData, void** ppData, uint* pBytes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pFileNamePtr = (byte*) SilkMarshal.StringToPtr(pFileName, NativeStringEncoding.LPStr);
        fixed (void* pParentDataPtr = &pParentData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)@this->LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentDataPtr, ppData, pBytes);
        }
        SilkMarshal.Free((nint)pFileNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open<T0>(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFileName, ref T0 pParentData, void** ppData, ref uint pBytes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pFileNamePtr = (byte*) SilkMarshal.StringToPtr(pFileName, NativeStringEncoding.LPStr);
        fixed (void* pParentDataPtr = &pParentData)
        {
            fixed (uint* pBytesPtr = &pBytes)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)@this->LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentDataPtr, ppData, pBytesPtr);
            }
        }
        SilkMarshal.Free((nint)pFileNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open<T0>(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFileName, ref T0 pParentData, ref void* ppData, uint* pBytes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pFileNamePtr = (byte*) SilkMarshal.StringToPtr(pFileName, NativeStringEncoding.LPStr);
        fixed (void* pParentDataPtr = &pParentData)
        {
            fixed (void** ppDataPtr = &ppData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)@this->LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentDataPtr, ppDataPtr, pBytes);
            }
        }
        SilkMarshal.Free((nint)pFileNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open<T0>(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFileName, ref T0 pParentData, ref void* ppData, ref uint pBytes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pFileNamePtr = (byte*) SilkMarshal.StringToPtr(pFileName, NativeStringEncoding.LPStr);
        fixed (void* pParentDataPtr = &pParentData)
        {
            fixed (void** ppDataPtr = &ppData)
            {
                fixed (uint* pBytesPtr = &pBytes)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)@this->LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentDataPtr, ppDataPtr, pBytesPtr);
                }
            }
        }
        SilkMarshal.Free((nint)pFileNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Close(this ComPtr<ID3DInclude> thisVtbl, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, void*, int>)@this->LpVtbl[1])(@this, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Close<T0>(this ComPtr<ID3DInclude> thisVtbl, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, void*, int>)@this->LpVtbl[1])(@this, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, byte* pFileName, void* pParentData, void** ppData, Span<uint> pBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Open(IncludeType, pFileName, pParentData, ppData, ref pBytes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, byte* pFileName, void* pParentData, ref void* ppData, Span<uint> pBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Open(IncludeType, pFileName, pParentData, ref ppData, ref pBytes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open<T0>(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, byte* pFileName, Span<T0> pParentData, void** ppData, uint* pBytes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Open(IncludeType, pFileName, ref pParentData.GetPinnableReference(), ppData, pBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open<T0>(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, byte* pFileName, Span<T0> pParentData, void** ppData, Span<uint> pBytes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Open(IncludeType, pFileName, ref pParentData.GetPinnableReference(), ppData, ref pBytes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open<T0>(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, byte* pFileName, Span<T0> pParentData, ref void* ppData, uint* pBytes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Open(IncludeType, pFileName, ref pParentData.GetPinnableReference(), ref ppData, pBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open<T0>(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, byte* pFileName, Span<T0> pParentData, ref void* ppData, Span<uint> pBytes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Open(IncludeType, pFileName, ref pParentData.GetPinnableReference(), ref ppData, ref pBytes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, Span<byte> pFileName, void* pParentData, void** ppData, uint* pBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Open(IncludeType, ref pFileName.GetPinnableReference(), pParentData, ppData, pBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, Span<byte> pFileName, void* pParentData, void** ppData, Span<uint> pBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Open(IncludeType, ref pFileName.GetPinnableReference(), pParentData, ppData, ref pBytes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, Span<byte> pFileName, void* pParentData, ref void* ppData, uint* pBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Open(IncludeType, ref pFileName.GetPinnableReference(), pParentData, ref ppData, pBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, Span<byte> pFileName, void* pParentData, ref void* ppData, Span<uint> pBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Open(IncludeType, ref pFileName.GetPinnableReference(), pParentData, ref ppData, ref pBytes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open<T0>(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, Span<byte> pFileName, Span<T0> pParentData, void** ppData, uint* pBytes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Open(IncludeType, ref pFileName.GetPinnableReference(), ref pParentData.GetPinnableReference(), ppData, pBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open<T0>(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, Span<byte> pFileName, Span<T0> pParentData, void** ppData, Span<uint> pBytes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Open(IncludeType, ref pFileName.GetPinnableReference(), ref pParentData.GetPinnableReference(), ppData, ref pBytes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open<T0>(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, Span<byte> pFileName, Span<T0> pParentData, ref void* ppData, uint* pBytes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Open(IncludeType, ref pFileName.GetPinnableReference(), ref pParentData.GetPinnableReference(), ref ppData, pBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open<T0>(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, Span<byte> pFileName, Span<T0> pParentData, ref void* ppData, Span<uint> pBytes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Open(IncludeType, ref pFileName.GetPinnableReference(), ref pParentData.GetPinnableReference(), ref ppData, ref pBytes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFileName, void* pParentData, void** ppData, Span<uint> pBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Open(IncludeType, pFileName, pParentData, ppData, ref pBytes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFileName, void* pParentData, ref void* ppData, Span<uint> pBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Open(IncludeType, pFileName, pParentData, ref ppData, ref pBytes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open<T0>(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFileName, Span<T0> pParentData, void** ppData, uint* pBytes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Open(IncludeType, pFileName, ref pParentData.GetPinnableReference(), ppData, pBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open<T0>(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFileName, Span<T0> pParentData, void** ppData, Span<uint> pBytes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Open(IncludeType, pFileName, ref pParentData.GetPinnableReference(), ppData, ref pBytes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open<T0>(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFileName, Span<T0> pParentData, ref void* ppData, uint* pBytes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Open(IncludeType, pFileName, ref pParentData.GetPinnableReference(), ref ppData, pBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open<T0>(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFileName, Span<T0> pParentData, ref void* ppData, Span<uint> pBytes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Open(IncludeType, pFileName, ref pParentData.GetPinnableReference(), ref ppData, ref pBytes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int Close<T0>(this ComPtr<ID3DInclude> thisVtbl, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Close(ref pData.GetPinnableReference());
    }

}
