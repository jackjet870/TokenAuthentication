using System.Web.Http;

namespace TokenAuthentication.WebApi
{
    public static class FilterConfig
    {
        public static void FilterConfiguration(HttpConfiguration config)
        {
            config.Filters.Add(new AuthorizeAttribute());
            // config.Filters.Add(new RequireHttpsAttribute());
        }
    }
}