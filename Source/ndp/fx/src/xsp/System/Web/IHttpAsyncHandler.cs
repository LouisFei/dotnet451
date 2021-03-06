﻿//------------------------------------------------------------------------------
// <copyright file="IHttpAsyncHandler.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>                                                                
//------------------------------------------------------------------------------

/*
 * Asynchronous Http request handler interface
 * 
 * Copyright (c) 2000 Microsoft Corporation
 */

namespace System.Web {

    using System.Security.Permissions;

    /// <devdoc>
    ///    <para>When implemented by a class, defines the contract that Http Async Handler objects must implement.</para>
    /// </devdoc>
    /// <summary>
    /// 定义 HTTP 异步处理程序对象必须实现的协定。
    /// </summary>
    public interface IHttpAsyncHandler : IHttpHandler {

        /// <devdoc>
        ///    <para>Registers handler for async notification.</para>
        /// </devdoc>
        /// 启动对 HTTP 处理程序的异步调用。
        IAsyncResult BeginProcessRequest(HttpContext context, AsyncCallback cb, Object extraData);

        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        /// 进程结束时提供异步处理 End 方法。
        void EndProcessRequest(IAsyncResult result);
    }

}
