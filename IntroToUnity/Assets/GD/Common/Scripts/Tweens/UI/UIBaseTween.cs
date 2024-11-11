using DG.Tweening;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Events;

namespace GD.Tweens
{
    /// <summary>
    /// Base class for UI panel tweens that can fade, slide, etc.
    /// </summary>
    public abstract class UIBaseTween : MonoBehaviour
    {
        #region Fields

        [SerializeField]
        [Tooltip("Specify the KeyCode to toggle the panel's visibility")]
        protected KeyCode keyCode = KeyCode.M;

        [SerializeField]
        [Tooltip("Common settings for the tween")]
        protected TweenSettings tweenSettings;

        [SerializeField, Tooltip("Event to call when the tween has completed")]
        [PropertyOrder(20)]
        protected UnityEvent onComplete;

        protected bool isVisible = false;

        #endregion Fields

        #region Properties

        protected float DurationSecs => tweenSettings.DurationSecs;
        protected float DelaySecs => tweenSettings.DelaySecs;
        protected Ease ShowEase => tweenSettings.ShowEase;
        protected Ease HideEase => tweenSettings.HideEase;

        #endregion Properties

        #region Methods

        protected virtual void Start()
        {
            InitializePanel();
        }

        private void Update()
        {
            if (Input.GetKeyDown(keyCode))
                TogglePanel();
        }

        private void TogglePanel()
        {
            if (isVisible)
                Hide();
            else
                Show();

            isVisible = !isVisible;
        }

        protected abstract void InitializePanel();

        protected abstract void Show();

        protected abstract void Hide();

        protected virtual void TweenComplete()
        {
            onComplete?.Invoke();
        }

        #endregion Methods
    }
}