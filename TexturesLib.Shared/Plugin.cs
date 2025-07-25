using BepInEx;

namespace TexturesLib.Shared
{
    [BepInPlugin("AgusBut.TexturesLib.Shared", "TexturesLib.Shared", "1.0.0")]
    public class Plugin : BaseUnityPlugin
    {
        public static Plugin Instance { get; private set; }
        public static BepInEx.Logging.ManualLogSource Log { get; private set; }

        private void Awake()
        {
            Instance = this;
            Log = base.Logger;

            Logger.LogInfo("TexturesLib.Shared loaded successfully.");
        }
    }
}
