// ==++==
// 
//   Copyright (c) Microsoft Corporation.  All rights reserved.
// 
// ==--==
/*============================================================
**
** Interface: IAsyncResult
**
** Purpose: Interface to encapsulate the results of an async
**          operation
**
===========================================================*/
namespace System {
    
    using System;
    using System.Threading;

    /// <summary>
    /// 表示异步操作的状态。
    /// IAsyncResult接口由包含可异步操作的方法的类实现。 
    /// 它是启动异步操作，
    /// 如方法的返回类型FileStream.BeginRead，并将它传递到方法，结束异步操作，如FileStream.EndRead。 
    /// IAsyncResult 对象还传递给调用的方法AsyncCallback委托的异步操作完成时。
    /// 支持的对象，IAsyncResult接口存储异步操作的状态信息，并提供要允许在操作完成时要发出信号的线程的同步对象。
    /// </summary>
    [System.Runtime.InteropServices.ComVisible(true)]
    public interface IAsyncResult
    {
        /// <summary>
        /// 获取一个值，该值指示异步操作是否已完成。
        /// </summary>
        bool IsCompleted { get; }

        /// <summary>
        /// 获取用于等待异步操作完成的 WaitHandle。
        /// </summary>
        WaitHandle AsyncWaitHandle { get; }

        /// <summary>
        /// 获取一个用户定义的对象，该对象限定或包含有关异步操作的信息。
        /// </summary>
        Object AsyncState      { get; }

        /// <summary>
        /// 获取一个值，该值指示异步操作是否同步完成。
        /// </summary>
        bool       CompletedSynchronously { get; }
   
    
    }

}
