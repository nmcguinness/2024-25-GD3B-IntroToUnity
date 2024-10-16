using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthChangeListener : MonoBehaviour
{
    public void OnPlayerHealthChanged(int delta)
    {
        Debug.Log($"Player health changed by {delta}");
    }
}