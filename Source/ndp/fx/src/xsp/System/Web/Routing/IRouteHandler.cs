namespace System.Web.Routing {
    using System.Runtime.CompilerServices;

    /// <summary>
    /// 定义为了处理匹配路由模式的请求，类必须实现的协定。
    /// </summary>
    [TypeForwardedFrom("System.Web.Routing, Version=3.5.0.0, Culture=Neutral, PublicKeyToken=31bf3856ad364e35")]
    public interface IRouteHandler {
        /// <summary>
        /// 提供用于处理请求的对象。
        /// </summary>
        /// <param name="requestContext">一个对象，用于封装有关请求的信息。</param>
        /// <returns></returns>
        IHttpHandler GetHttpHandler(RequestContext requestContext);
    }
}
