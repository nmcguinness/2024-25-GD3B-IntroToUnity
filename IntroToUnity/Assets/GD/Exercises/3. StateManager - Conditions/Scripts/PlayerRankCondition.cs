using GD.State;
using UnityEngine;

[CreateAssetMenu(menuName = "GD/Conditions/Single/Player Rank Condition")]
public class PlayerRankCondition : ConditionBase
{
    [SerializeField]
    private Player player;

    [SerializeField]
    private int rankThreshold = 200;

    protected override bool EvaluateCondition()
    {
        return player.rank >= rankThreshold;
    }
}