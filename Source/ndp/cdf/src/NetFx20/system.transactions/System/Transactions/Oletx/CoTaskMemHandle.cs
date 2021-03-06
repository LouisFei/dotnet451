//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace System.Transactions.Oletx
{
    using System;
    using System.Runtime.ConstrainedExecution;
    using System.Runtime.InteropServices;
    using System.Security;

    internal sealed class CoTaskMemHandle : SafeHandle
    {
        // FXCop is complaining because we don't have any callers to the constructor.  But they are created by COMInterop when we use them
        // as "out" parameters to calls to the proxy shim interfaces.
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        public CoTaskMemHandle() : base(IntPtr.Zero, true)
        {
        }

        public override bool IsInvalid
        {
            get
            {
                return IsClosed || this.handle == IntPtr.Zero;
            }
        }
/*
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        [DllImport("ole32.dll", EntryPoint="CoTaskMemAlloc"),
         SuppressUnmanagedCodeSecurity]
        public static extern CoTaskMemHandle Alloc(IntPtr size);
*/
        [DllImport("ole32.dll"),
         SuppressUnmanagedCodeSecurity,
         ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
        private static extern void CoTaskMemFree(IntPtr ptr);
        
        override protected bool ReleaseHandle()
        {
            CoTaskMemFree(this.handle);
            return true;
        }

    }    
}
