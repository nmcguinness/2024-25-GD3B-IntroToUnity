using GD.Selection;
using UnityEngine;

public class AudioSelectionResponse : MonoBehaviour, ISelectionResponse
{
    [SerializeField]
    private AudioClip audioClip;

    private Transform currentTransform;

    public void OnSelect(Transform transform)
    {
        //BUG - only sound after first select

        //play one shot audio clip
        if (currentTransform != null && currentTransform != transform)
            AudioSource.PlayClipAtPoint(audioClip, transform.position);

        //store what we selected
        currentTransform = transform;
    }

    public void OnDeselect(Transform transform)
    {
        //throw new System.NotImplementedException();
    }
}