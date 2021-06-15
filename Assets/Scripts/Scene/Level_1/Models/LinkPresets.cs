using System.Collections.Generic;

namespace Assets.Scripts.Scene.Level_1.Models
{
    public static class LinkPresets
    {
        public static readonly List<LinkPair> Presets = new List<LinkPair>();

        static LinkPresets()
        {
            Presets.Add(new LinkPair("google.com", "goog1e.com"));
            Presets.Add(new LinkPair("youtube.com", "youtude.com"));
            Presets.Add(new LinkPair("twitter.com", "twltter.com"));
            Presets.Add(new LinkPair("github.com", "github.cum"));
            Presets.Add(new LinkPair("yandex.ru", "yandexx.ru"));
            Presets.Add(new LinkPair("steamcommunity.com", "steamconmunity.com"));
            Presets.Add(new LinkPair("support.google.com", "suport.google.com"));
        }
    }
}
