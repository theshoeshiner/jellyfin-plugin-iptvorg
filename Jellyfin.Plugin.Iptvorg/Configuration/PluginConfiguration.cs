using MediaBrowser.Model.Plugins;

namespace Jellyfin.Plugin.Iptvorg.Configuration;

/// <summary>
/// Plugin configuration.
/// </summary>
public class PluginConfiguration : BasePluginConfiguration
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PluginConfiguration"/> class.
    /// </summary>
    public PluginConfiguration()
    {
        IptvOrgPath = string.Empty;
    }

    public string IptvOrgPath { get; set; }

}
