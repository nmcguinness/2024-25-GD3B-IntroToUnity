using DG.Tweening;
using UnityEngine;

public class CanvasTweenBehaviour : MonoBehaviour
{
    [SerializeField]
    private Ease ease = Ease.OutBounce;

    [SerializeField]
    [Range(0.1f, 10.0f)]
    private float duration = 1.0f;

    [SerializeField]
    private RectTransform targetTransform;

    private void Awake()
    {
        //move the canvas in using DoTween
        targetTransform.anchoredPosition = new Vector2(0, -Screen.height);
    }

    private void Start()
    {
        //use DoTween to move the canvas in
        targetTransform.DOAnchorPos(new Vector2(0, 0), duration).SetEase(ease);
    }
}