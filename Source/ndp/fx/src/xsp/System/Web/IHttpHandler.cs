//------------------------------------------------------------------------------
// <copyright file="IHttpHandler.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>                                                                
//------------------------------------------------------------------------------

/*
 * Synchronous Http request handler interface
 * 
 * Copyright (c) 1998 Microsoft Corporation
 */

namespace System.Web {
    
    using System.Security.Permissions;

    /// <devdoc>
    ///    <para>
    ///       Defines the contract that developers must implement to synchronously process HTTP web requests.
    ///       定义开发人员为同步处理HTTP web请求而必须实现的契约。
    ///       Developers implement the ProcessRequest method to provide custom URL execution.
    ///       开发人员实现ProcessRequest方法以提供定制的URL执行。
    ///    </para>
    /// </devdoc>
    /// <summary>
    /// 用于处理请求的对象。
    /// 定义 ASP.NET 为使用自定义 HTTP 处理程序同步处理 HTTP Web 请求而实现的协定。
    /// HTTP 处理程序为您提供一种与低级别的请求和响应服务的 IIS Web 服务器进行交互，
    /// 并提供功能非常类似于 ISAPI 扩展，但更简单的编程模型。
    /// </summary>
    public interface IHttpHandler {

        /// <devdoc>
        ///    <para>
        ///       Drives web processing execution.
        ///    </para>
        /// </devdoc>
        /// <summary>
        /// 启用 HTTP Web 请求的处理
        /// </summary>
        /// <param name="context"></param>
        void ProcessRequest(HttpContext context);

        /// <devdoc>
        ///    <para>
        ///       Allows an IHTTPHandler instance to indicate at the end of a request whether it can be recycled and used for another request.
        ///    </para>
        /// </devdoc>
        /// <summary>
        /// 获取一个值，该值指示其他请求是否可以使用 IHttpHandler 实例。
        /// </summary>
        bool IsReusable { get; }
    }

}
