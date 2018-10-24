namespace System.Web.Routing {
    using System;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// 提供一种方式，用于指定 ASP.NET 路由不应处理 URL 模式的请求。
    /// </summary>
    [TypeForwardedFrom("System.Web.Routing, Version=3.5.0.0, Culture=Neutral, PublicKeyToken=31bf3856ad364e35")]
    public class StopRoutingHandler : IRouteHandler {

        /// <summary>
        /// 返回用于处理请求的对象。
        /// </summary>
        /// <param name="requestContext"></param>
        /// <returns></returns>
        protected virtual IHttpHandler GetHttpHandler(RequestContext requestContext) {
            throw new NotSupportedException();
        }

        #region IRouteHandler Members
        /// <summary>
        /// 返回用于处理请求的对象。
        /// </summary>
        /// <param name="requestContext"></param>
        /// <returns></returns>
        IHttpHandler IRouteHandler.GetHttpHandler(RequestContext requestContext) {
            return GetHttpHandler(requestContext);
        }
        #endregion

    }
}
