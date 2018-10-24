//------------------------------------------------------------------------------
// <copyright file="RequestNotification.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>                                                                
//------------------------------------------------------------------------------

/*
 */
namespace System.Web {

    using System;

    //
    //  ********NOTE********
    //  This enum is also reflected in rscaps.idl as part of the interface. 
    //  Any changes to one, must be reflected in the other!
    //

        /// <summary>
        /// Http请求通知
        /// </summary>
    [Flags]
    public enum RequestNotification {
        /// <summary>
        /// 在 ASP.NET 响应请求时作为 HTTP 执行管线链中的第一个事件发生。
        /// </summary>
        BeginRequest = 0x00000001,  // request is beginning
        /// <summary>
        /// 当安全模块已建立用户标识时发生。
        /// </summary>
        AuthenticateRequest = 0x00000002,  // request is being authenticated
        /// <summary>
        /// 当安全模块已验证用户授权时发生。
        /// </summary>
        AuthorizeRequest = 0x00000004,  // request is being authorized
        /// <summary>
        /// 在 ASP.NET 完成授权事件以使缓存模块从缓存中为请求提供服务后发生，从而绕过事件处理程序（例如某个页或 XML Web services）的执行。
        /// </summary>
        ResolveRequestCache = 0x00000008,  // satisfy request from cache
        /// <summary>
        /// 在选择了用来响应请求的处理程序时发生。
        /// </summary>
        MapRequestHandler = 0x00000010,  // map handler for request
        /// <summary>
        /// 当 ASP.NET 获取与当前请求关联的当前状态（如会话状态）时发生。
        /// </summary>
        AcquireRequestState = 0x00000020,  // acquire request state
        /// <summary>
        /// 
        /// </summary>
        PreExecuteRequestHandler  = 0x00000040,
        ExecuteRequestHandler     = 0x00000080,  // execute handler
        /// <summary>
        /// 在 ASP.NET 执行完所有请求事件处理程序后发生。 该事件将使状态模块保存当前状态数据。
        /// </summary>
        ReleaseRequestState = 0x00000100,  // release request state
        /// <summary>
        /// 当 ASP.NET 执行完事件处理程序以使缓存模块存储将用于从缓存为后续请求提供服务的响应时发生。
        /// </summary>
        UpdateRequestCache = 0x00000200,  // update cache
        /// <summary>
        /// 恰好在 ASP.NET 为当前请求执行任何记录之前发生。
        /// </summary>
        LogRequest = 0x00000400,  // log request
        /// <summary>
        /// 在 ASP.NET 响应请求时作为 HTTP 执行管线链中的最后一个事件发生。
        /// </summary>
        EndRequest = 0x00000800,  // end request
        /// <summary>
        /// 
        /// </summary>
        SendResponse              = 0x20000000   // send response
    }

}
