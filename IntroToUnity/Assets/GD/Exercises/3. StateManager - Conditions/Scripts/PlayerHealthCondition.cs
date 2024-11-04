using GD.State;
using UnityEngine;

[CreateAssetMenu(menuName = "GD/Conditions/Single/Player Health Condition")]
public class PlayerHealthCondition : ConditionBase
{
    [SerializeField]
    private Player player;

    [SerializeField]
    private int healthThreshold = 0;

    protected override bool EvaluateCondition()
    {
        //this code could be really complex and time-consuming
        return player.health <= healthThreshold;
    }
}