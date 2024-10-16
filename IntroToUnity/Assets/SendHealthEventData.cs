using GD;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendHealthEventData : MonoBehaviour
{
    [SerializeField]
    private IntGameEvent healthEvent;

    private void Update()
    {
        if (Time.time > 5)
            healthEvent.Raise(100);
    }
}