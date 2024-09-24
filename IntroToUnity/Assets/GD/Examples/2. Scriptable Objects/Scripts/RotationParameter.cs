using UnityEngine;

[CreateAssetMenu(fileName = "RotatationParameter", menuName = "GD/SO/MyGameName/Parameters/Rotation")]
public class RotationParameter : ScriptableObject
{
    [SerializeField]
    private float rotationAngle;

    public float RotationAngle { get => rotationAngle; set => rotationAngle = value; }
}