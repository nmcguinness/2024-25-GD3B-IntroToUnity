using DG.Tweening;
using UnityEngine;

namespace GD.Tweens
{
    public class UIFadeTween : UIBaseTween
    {
        [SerializeField, Tooltip("Specify the CanvasGroup component of the UI panel for fading")]
        private CanvasGroup panelCanvasGroup;

        protected override void InitializePanel()
        {
            panelCanvasGroup.alpha = 0;
        }

        protected override void Show()
        {
            panelCanvasGroup.DOFade(1, DurationSecs)
                .SetEase(ShowEase)
                .SetDelay(DelaySecs)
                .OnComplete(TweenComplete);
        }

        protected override void Hide()
        {
            panelCanvasGroup.DOFade(0, DurationSecs)
                .SetEase(HideEase)
                 .SetDelay(DelaySecs)
                .OnComplete(TweenComplete);
        }
    }
}