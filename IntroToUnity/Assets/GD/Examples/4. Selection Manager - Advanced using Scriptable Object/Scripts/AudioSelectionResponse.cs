using GD.Selection;
using UnityEngine;

public class AudioSelectionResponse : MonoBehaviour, ISelectionResponse
{
    public void OnDeselect(Transform transform)
    {
        //throw new System.NotImplementedException();
    }

    public void OnSelect(Transform transform)
    {
        //play one shot audio clip
    }
}