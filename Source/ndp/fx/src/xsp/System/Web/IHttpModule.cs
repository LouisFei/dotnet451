//------------------------------------------------------------------------------
// <copyright file="IHttpModule.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>                                                                
//------------------------------------------------------------------------------

/*
 * IHttpModule interface
 * 
 * Copyright (c) 2000 Microsoft Corporation
 */

namespace System.Web 
{
using System;
using System.Security.Permissions;

    /// <devdoc>
    ///    <para>Provides module initialization and tear-down events to the inheriting class.</para>
    /// </devdoc>
    /// <summary>
    /// HttpModule有类似于过滤器的作用，可以没有，也可以有任意个，每一个都可以订阅管道事件中的任意个事件，
    /// 在每个订阅的事件中可自定义功能实现。
    /// </summary>
    public interface IHttpModule
{

    /// <devdoc>
    ///    <para>Invoked by ASP.NET to enable a module to set itself up to handle
    ///       requests.</para>
    /// </devdoc>
    void Init(HttpApplication context);


    /// <devdoc>
    ///    <para>Invoked by ASP.NET to enable a module to perform any final cleanup work prior to tear-down.</para>
    /// </devdoc>
    void Dispose();

}

}
