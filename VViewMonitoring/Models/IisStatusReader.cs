using Microsoft.Web.Administration;
using VViewMonitoring.Models;

namespace VViewMonitoring.SystemReaders
{
    public static class IisStatusReader
    {
        public static List<IisSiteStatus> GetSites()
        {
            var siteNames = new[]
            {
                "view.vwc.api",
                "view.vwc.idp",
                "view.vwc.web"
            };

            var result = new List<IisSiteStatus>();

            using var manager = new ServerManager();

            foreach (var siteName in siteNames)
            {
                var site = manager.Sites.FirstOrDefault(s => s.Name == siteName);

                if (site != null)
                {
                    result.Add(new IisSiteStatus
                    {
                        SiteName = site.Name,
                        State = site.State.ToString(),
                        AppPool = site.Applications.First().ApplicationPoolName
                    });
                }
                else
                {
                    result.Add(new IisSiteStatus
                    {
                        SiteName = siteName,
                        State = "Not Found",
                        AppPool = "-"
                    });
                }
            }

            return result;
        }
    }
}
