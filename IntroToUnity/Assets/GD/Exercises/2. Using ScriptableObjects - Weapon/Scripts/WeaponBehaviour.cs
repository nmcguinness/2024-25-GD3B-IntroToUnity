using System.Collections.Generic;
using UnityEngine;

public class WeaponBehaviour : MonoBehaviour
{
    #region Fields

    [SerializeField]
    private int clipSize;

    [SerializeField]
    private float range;

    [SerializeField]
    private int rank;

    [SerializeField]
    [ReadOnly]
    private bool isUpgraded;

    [SerializeField]
    [RequireInterface(typeof(IUpgradeWeapon))]
    private List<ScriptableObject> upgrades;

    #region Properties

    public int ClipSize { get => clipSize; set => clipSize = value; }
    public float Range { get => range; set => range = value; }
    public int Rank { get => rank; set => rank = value; }

    #endregion Properties

    #endregion Fields

    [ContextMenu("Apply Upgrade")]
    public void ApplyUpgrade()
    {
        ///var rand = new Random();
        //rand.Next(0, upgrade.Count);
        int rand = 2;

        var upgrade = upgrades[rand] as IUpgradeWeapon;
        upgrade.Upgrade(this);

        isUpgraded = true;
    }

    public override string ToString()
    {
        return $"{ClipSize},{Range},{Rank}";
    }
}