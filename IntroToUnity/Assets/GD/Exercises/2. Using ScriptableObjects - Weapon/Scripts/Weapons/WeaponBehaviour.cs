using System.Collections.Generic;
using UnityEngine;

public class WeaponBehaviour : MonoBehaviour
{
    #region Fields

    [SerializeField]
    private WeaponData weaponData;

    [SerializeField]
    [ReadOnly]
    private bool isUpgraded;

    [SerializeField]
    [RequireInterface(typeof(IModifyWeapon))]
    private List<ScriptableObject> upgrades;

    #endregion Fields

    [ContextMenu("Apply Upgrade")]
    public void ApplyUpgrade()
    {
        //upgrade once
        if (isUpgraded)
        {
            Debug.LogWarning("Weapon is already upgraded");
            return;
        }

        //get a random index in the range
        var index = Random.Range(0, upgrades.Count);

        //get the upgrade at the index
        var upgrade = upgrades[index] as IModifyWeapon;

        //apply the upgrade
        upgrade.Apply(weaponData);

        //set the upgrade flag
        isUpgraded = true;
    }
}