using UnityEngine;

public class IDontKnow : MonoBehaviour
{
    [SerializeField]
    private Vector3 axis = new Vector3(0, 1, 0);

    //[SerializeField]
    //private float angle = 1;

    [SerializeField]
    private RotationParameter rotation;

    [SerializeField]
    private Space space = Space.Self;

    public Transform target;

    // Update is called once per frame
    private void Update()
    {
    }

    // This function is called every fixed framerate frame, if the MonoBehaviour is enabled
    private void FixedUpdate()
    {
        target.transform.Rotate(axis, rotation.RotationAngle, space);
    }
}