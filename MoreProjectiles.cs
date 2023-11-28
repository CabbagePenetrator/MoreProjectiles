using PugMod;
using UnityEngine;
using System.Linq;

public class MoreProjectiles : IMod
{
    public const string VERSION = "0.0.1";
    public const string NAME = "More Projectiles";
    public const string AUTHOR = "CabbagePenetrator";

    private LoadedMod modInfo;

    public void EarlyInit()
    {
        modInfo = API.ModLoader.LoadedMods.FirstOrDefault(obj => obj.Handlers.Contains(this));

        if (modInfo == null)
        {
            Debug.Log($"[{NAME}]: Failed to load {NAME}!");
            return;
        }

        Debug.Log($"[{NAME}]: Mod loaded successfully!");
    }

    public void Init()
    {
        //
    }

    public void ModObjectLoaded(Object obj)
    {
        //
    }

    public void Shutdown()
    {
        //
    }

    public void Update()
    {
        //
    }
}
