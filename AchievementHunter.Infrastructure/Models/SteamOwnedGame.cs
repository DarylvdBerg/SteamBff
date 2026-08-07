using Newtonsoft.Json;

namespace AchievementHunter.Infrastructure.Models;

public class SteamOwnedGame
{
    public int AppId { get; init; }
    
    public string Name { get; init; }
    
    [JsonProperty("playtime_forever")]
    public int PlaytimeForever { get; init; }
    
    [JsonProperty("img_icon_url")]
    public string ImgIconUrl { get; init; }
    
    [JsonProperty("has_community_visible_stats")]
    public bool HasCommunityVisibleStats { get; init; }
    
    [JsonProperty("playtime_windows_forever")]
    public int PlayTimeWindowsForever { get; init; }
    
    [JsonProperty("playtime_linux_forever")]
    public int PlayTimeLinuxForever { get; init; }
    
    [JsonProperty("playtime_mac_forever")]
    public int PlayTimeMacForever { get; init; }
    
    [JsonProperty("content_descriptorids")]
    public IEnumerable<int> ContentDescriptorIds { get; init; }
    
    [JsonProperty("playtime_disconnected")]
    public int PlaytimeDisconnected { get; init; }
    
    
}