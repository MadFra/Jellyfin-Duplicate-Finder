using System;
using System.Collections.Generic;
using Jellyfin.Plugin.DuplicateFinder.Configuration;
using MediaBrowser.Common.Configuration;
using MediaBrowser.Common.Plugins;
using MediaBrowser.Model.Plugins;
using MediaBrowser.Model.Serialization;

namespace Jellyfin.Plugin.DuplicateFinder
{
    public class Plugin : BasePlugin<PluginConfiguration>, IHasWebPages
    {
        public Plugin(IApplicationPaths appPaths, IXmlSerializer xmlSerializer)
            : base(appPaths, xmlSerializer)
        {
        }

        public override string Name => "DuplicateFinder";

        public override string Description => "Generate Duplicate Report";

        public PluginConfiguration PluginConfiguration => Configuration;

        public override Guid Id { get; } = new Guid("b014bf53-1954-4b6b-873b-9ec656866b4e");

        public IEnumerable<PluginPageInfo> GetPages()
        {
            return new PluginPageInfo[]
            {
                new PluginPageInfo
                {
                    Name = "reports",
                    EmbeddedResourcePath = GetType().Namespace + ".Web.reports.html",
                    EnableInMainMenu = true
                },
                new PluginPageInfo
                {
                    Name = "reportsjs",
                    EmbeddedResourcePath = GetType().Namespace + ".Web.reports.js"
                }
            };
        }
    }
}
