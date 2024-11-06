using UnityEngine;

namespace GD.State
{
    /// <summary>
    /// A composite condition that is met when all child conditions are met.
    /// </summary>
    [CreateAssetMenu(fileName = "AndCondition", menuName = "GD/Conditions/Composite/And Condition")]
    public class AndCondition : CompositeCondition
    {
        /// <summary>
        /// Evaluates the condition logic: returns true if all child conditions are met.
        /// </summary>
        /// <returns>True if all child conditions are met; otherwise, false.</returns>
        protected override bool EvaluateCondition(ConditionContext conditionContext)
        {
            // Sort conditions by priority before evaluation
            SortConditionsByPriority();

            bool allMet = true;
            foreach (var condition in conditions)
            {
                if (!condition.Evaluate(conditionContext))
                    return false;
            }
            if (allMet && TimeMet == -1f)
            {
                TimeMet = Time.timeSinceLevelLoad;
                OnConditionMet?.Invoke();
            }
            return allMet;
        }
    }
}