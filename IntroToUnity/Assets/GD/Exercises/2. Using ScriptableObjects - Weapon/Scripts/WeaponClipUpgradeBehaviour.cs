using UnityEngine;

[CreateAssetMenu(fileName = "WeaponClipUpgradeBehaviour",
    menuName = "SO/Upgrades/Weapon/Range")]
public class WeaponClipUpgradeBehaviour : ScriptableObject, IUpgradeWeapon
{
    public string description = "Add description...";
    public float multiplier = 1;

    public void Upgrade(WeaponBehaviour w)
    {
        w.Range += multiplier;
    }
}