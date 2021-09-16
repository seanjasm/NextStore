using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Web.Administration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using Microsoft.Web.Administration;

namespace NextStore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            

            using (ServerManager serverManager = new ServerManager())
            {
                /*
                Configuration config = serverManager.GetApplicationHostConfiguration();
                Microsoft.Web.Administration.ConfigurationSection applicationPoolsSection = config.GetSection("system.applicationHost/applicationPools");
                ConfigurationElementCollection applicationPoolsCollection = applicationPoolsSection.GetCollection();
                ConfigurationElement addElement = FindElement(applicationPoolsCollection, "add", "name", @"Nextstore");
                if (addElement == null) throw new InvalidOperationException("Element not found!");
                ConfigurationElementCollection environmentVariablesCollection = addElement.GetCollection("environmentVariables");
                ConfigurationElement addElement1 = environmentVariablesCollection.CreateElement("DT_TAGS");
                addElement1["name"] = @"foo";
                addElement1["value"] = @"bar";
                environmentVariablesCollection.Add(addElement1);
                serverManager.CommitChanges();
                */
            }

            CreateHostBuilder(args).Build().Run();

        }


        private static ConfigurationElement FindElement(ConfigurationElementCollection collection, string elementTagName, params string[] keyValues)
        {
            foreach (ConfigurationElement element in collection)
            {
                if (String.Equals(element.ElementTagName, elementTagName, StringComparison.OrdinalIgnoreCase))
                {
                    bool matches = true;
                    for (int i = 0; i < keyValues.Length; i += 2)
                    {
                        object o = element.GetAttributeValue(keyValues[i]);
                        string value = null;
                        if (o != null)
                        {
                            value = o.ToString();
                        }
                        if (!String.Equals(value, keyValues[i + 1], StringComparison.OrdinalIgnoreCase))
                        {
                            matches = false;
                            break;
                        }
                    }
                    if (matches)
                    {
                        return element;
                    }
                }
            }
            return null;
        }
    


    public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
