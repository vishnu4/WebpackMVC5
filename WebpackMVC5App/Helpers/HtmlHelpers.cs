using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Caching;
using System.Web;
using System.Web.Hosting;

namespace System.Web.Mvc
{

    public static class HtmlExtensions
    {
        //http://madskristensen.net/post/cache-busting-in-aspnet
        public static string Tag(this UrlHelper url, string rootRelativePath)
        {
            //HttpContext.Current.Cache[]
            ObjectCache  cache = System.Runtime.Caching.MemoryCache.Default;
            if (!cache.Contains(rootRelativePath) || cache[rootRelativePath] ==null)
            {
                string absolute = HostingEnvironment.MapPath(rootRelativePath);
                DateTime date = File.GetLastWriteTime(absolute);

                //int index = rootRelativePath.LastIndexOf('/');
                //string result = url.Content(rootRelativePath.Insert(index, "/v-" + date.Ticks));  //have a problem with the fonts when i do it this way

                string result = url.Content(rootRelativePath + "?v-" + date.Ticks);
                if (!string.IsNullOrEmpty(result))
                {
                    if (cache.Contains(rootRelativePath))
                    {
                        cache[rootRelativePath] = result;
                    }
                    else
                    {
                        CacheItemPolicy policy = new CacheItemPolicy();
                        policy.AbsoluteExpiration = DateTime.Now + TimeSpan.FromMinutes(int.MaxValue);
                        cache.Add(new CacheItem(rootRelativePath, result), policy);
                    }
                }
            }
            return (string)cache[rootRelativePath];
        }

    }
}