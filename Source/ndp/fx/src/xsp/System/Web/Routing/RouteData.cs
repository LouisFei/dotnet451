namespace System.Web.Routing {
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// 封装有关路由的信息。
    /// </summary>
    [TypeForwardedFrom("System.Web.Routing, Version=3.5.0.0, Culture=Neutral, PublicKeyToken=31bf3856ad364e35")]
    public class RouteData {
        private IRouteHandler _routeHandler;
        private RouteValueDictionary _values = new RouteValueDictionary();
        private RouteValueDictionary _dataTokens = new RouteValueDictionary();

        public RouteData() {
        }

        /// <summary>
        /// 使用指定路由和路由处理程序初始化 RouteData 类的新实例。
        /// </summary>
        /// <param name="route"></param>
        /// <param name="routeHandler"></param>
        public RouteData(RouteBase route, IRouteHandler routeHandler) {
            Route = route;
            RouteHandler = routeHandler;
        }

        public RouteValueDictionary DataTokens {
            get {
                return _dataTokens;
            }
        }

        /// <summary>
        /// 获取或设置表示路由的对象。
        /// </summary>
        public RouteBase Route {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置可处理请求路由的对象。
        /// </summary>
        public IRouteHandler RouteHandler {
            get {
                return _routeHandler;
            }
            set {
                _routeHandler = value;
            }
        }

        /// <summary>
        /// 获取 URL 参数值的集合和路由的默认值。
        /// </summary>
        public RouteValueDictionary Values {
            get {
                return _values;
            }
        }

        /// <summary>
        /// 使用指定标识符检索值。
        /// </summary>
        /// <param name="valueName"></param>
        /// <returns></returns>
        public string GetRequiredString(string valueName) {
            object value;
            if (Values.TryGetValue(valueName, out value)) {
                string valueString = value as string;
                if (!String.IsNullOrEmpty(valueString)) {
                    return valueString;
                }
            }
            throw new InvalidOperationException(
                String.Format(
                    CultureInfo.CurrentUICulture,
                    SR.GetString(SR.RouteData_RequiredValue),
                    valueName));
        }
    }
}
