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

    [RequireInterface(typeof(IUpgradeWeapon))]
    public List<ScriptableObject> upgrade;

    #region Properties

    public int ClipSize { get => clipSize; set => clipSize = value; }
    public float Range { get => range; set => range = value; }
    public int Rank { get => rank; set => rank = value; }

    #endregion Properties

    #endregion Fields

    public void ApplyUpgrade()
    {
        //TODO: Implement upgrade logic ONCE only
    }

    public override string ToString()
    {
        return $"{ClipSize},{Range},{Rank}";
    }
}