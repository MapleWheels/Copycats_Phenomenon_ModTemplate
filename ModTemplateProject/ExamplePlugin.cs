using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BepInEx;

namespace ModTemplateProject
{
    [BepInPlugin("com.test.exampleplugin", "Example Plugin", "0.0.0")]
    public class ExamplePlugin : BaseUnityPlugin
    {
        void Awake()
        {
            Logger.LogWarning("Plugin loaded.");
            Logger.LogError("Plugin loaded.");
            Logger.LogInfo("Plugin loaded.");
            Logger.LogDebug("Plugin loaded.");

            UnityEngine.Debug.LogWarning("Example Plugin loaded.");
        }
    }
}
