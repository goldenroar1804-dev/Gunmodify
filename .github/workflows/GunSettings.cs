namespace GunModifier
{
    public static class GunSettings
    {
        // Damage multiplier
        public static float DamageMultiplier = 1.0f;

        // Fire rate multiplier
        public static float FireRateMultiplier = 1.0f;

        // Recoil multiplier
        public static float RecoilMultiplier = 1.0f;

        // Magazine capacity multiplier
        public static float MagazineMultiplier = 1.0f;

        // Infinite ammo toggle
        public static bool InfiniteAmmo = false;

        // Extended magazine toggle
        public static bool ExtendedMagazine = false;

        // Reset all settings
        public static void Reset()
        {
            DamageMultiplier = 1.0f;
            FireRateMultiplier = 1.0f;
            RecoilMultiplier = 1.0f;
            MagazineMultiplier = 1.0f;
            InfiniteAmmo = false;
            ExtendedMagazine = false;
        }
    }
}
