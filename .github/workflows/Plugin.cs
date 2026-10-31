using MelonLoader;
using BoneLib;

[assembly: MelonInfo(typeof(GunModifier.Plugin), "Gun Modifier", "1.0.0", "GunModifier")]
[assembly: MelonGame("Stress Level Zero", "BONELAB")]

namespace GunModifier
{
    public class Plugin : MelonMod
    {
        public override void OnInitializeMelon()
        {
            MelonLogger.Msg("Gun Modifier loaded!");

            CreateMenu();
        }

        private void CreateMenu()
        {
            MelonLogger.Msg("Gun Modifier menu initializing...");
        }
    }
}
