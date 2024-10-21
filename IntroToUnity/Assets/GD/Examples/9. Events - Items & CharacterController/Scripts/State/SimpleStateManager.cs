using GD;
using GD.Items;
using System.Collections.Generic;
using UnityEngine;

public class SimpleStateManager : MonoBehaviour, IHandleTicks
{
    [SerializeField]
    private int totalObjectiveCount = 3;

    [SerializeField]
    private TimeTickSystem.TickRateMultiplierType tickRateMultiplierType = TimeTickSystem.TickRateMultiplierType.EighthTime;

    [SerializeField]
    private List<ItemData> orderedObjectives;

    private void Awake()
    {
        //notice that we have to cast using "as" otherwise it will just be a reference to a Singleton<MonoBehaviour>
        TimeTickSystem.Instance.RegisterListener(tickRateMultiplierType,
            HandleTick);
    }

    private void OnDestroy()
    {
        //don't forget to un-register!
        TimeTickSystem.Instance.UnregisterListener(tickRateMultiplierType,
            HandleTick);
    }

    public void OnInteractablePickup(ItemData data)
    {
        if (data != null)
            orderedObjectives.Add(data);
    }

    public void HandleTick()
    {
        Debug.Log($"SimpleStateManager.HandleTick() at {Time.time}");

        if (orderedObjectives.Count == totalObjectiveCount - 1)
        {
            //check that the first and second are in the correct order

            //if yes, then success

            //congratulate player

            //show main menu for new game

            //if no, then notify player

            //wait for menu "OK" or a countdown

            //send event to restart player
        }
    }
}