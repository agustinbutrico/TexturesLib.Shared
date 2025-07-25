using System.Collections.Generic;
using UnityEngine;

namespace TexturesLib.Shared
{
    public static class SpriteHelper
    {
        private static readonly Dictionary<string, Sprite> _spriteCache = new Dictionary<string, Sprite>();

        public static Sprite FindSpriteByName(string spriteName)
        {
            if (_spriteCache.TryGetValue(spriteName, out var sprite))
                return sprite;

            foreach (var s in Resources.FindObjectsOfTypeAll<Sprite>())
            {
                if (s.name == spriteName || s.name == spriteName + "_TexturesLib")
                {
                    _spriteCache[spriteName] = s;
                    return s;
                }
            }

            Plugin.Log.LogWarning($"Sprite '{spriteName}' not found in memory.");
            return null;
        }
    }
}
