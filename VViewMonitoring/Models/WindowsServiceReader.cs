using System;
using System.Collections.Generic;
using System.ServiceProcess;
using VViewMonitoring.Models;

namespace VViewMonitoring.SystemReaders
{
    public static class WindowsServiceReader
    {
        public static List<ServiceStatus> GetServices()
        {
            var servicesToCheck = new[]
            {
                "vwcardservice",
                "vwbgservice",
                "vwcfileservice"
            };

            var result = new List<ServiceStatus>();

            foreach (var serviceName in servicesToCheck)
            {
                try
                {
                    ServiceController sc = new ServiceController(serviceName);

                    result.Add(new ServiceStatus
                    {
                        Name = serviceName,
                        DisplayName = sc.DisplayName,
                        Status = sc.Status.ToString()
                    });
                }
                catch (Exception)
                {
                    result.Add(new ServiceStatus
                    {
                        Name = serviceName,
                        DisplayName = "Not Installed",
                        Status = "Not Found"
                    });
                }
            }

            return result;
        }
    }
}
