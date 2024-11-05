using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToastManager : MonoBehaviour
{
    public void OnWillRenderObject()
    {
        Debug.Log("You won because your rank is above the threshold!");
    }
}