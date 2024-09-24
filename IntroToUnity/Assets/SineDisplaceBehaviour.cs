using UnityEngine;

public class SineDisplaceBehaviour : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Transform of the object to be displaced")]
    private Transform target;

    // This function is called every fixed framerate frame, if the MonoBehaviour is enabled
    private void FixedUpdate()
    {
        //Mathf.Sin()
        //Time.time
        //Amplitude, frequency, direction
    }
}