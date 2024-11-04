using GD.State;
using UnityEngine;

[CreateAssetMenu(menuName = "GD/Conditions/Single/Has Hero Object")]
public class PlayerHasHeroObject : ConditionBase
{
    [SerializeField]
    private Player player;

    protected override bool EvaluateCondition()
    {
        return player.hasHeroObject;
    }
}