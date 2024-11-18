using UnityEngine;
using UnityEngine.InputSystem;
using Sirenix.OdinInspector;
using GD.Selection;

namespace GD.Navigation
{
    /// <summary>
    /// Main controller for character navigation and interaction.
    /// </summary>
    public class CharacterNavigationController : MonoBehaviour
    {
        private IRayProvider rayProvider;
        private ISelector selector;

        private ISelectable selectable;
        private IWaypointManager waypointManager;
        private IMovementController movementController;

        private void Start()
        {
            selectable = GetComponent<ISelectable>();
            waypointManager = GetComponent<IWaypointManager>();
            movementController = GetComponent<IMovementController>();
            rayProvider = GetComponent<IRayProvider>();
            selector = GetComponent<ISelector>();
        }

        public void OnSelectPlayer(InputAction.CallbackContext context)
        {
            selectable.Select();
        }

        public void OnSelectWaypoint(InputAction.CallbackContext context)
        {
            selector.Check(rayProvider.CreateRay());
            if (selector.GetSelection() != null)
            {
                var hitInfo = selector.GetHitInfo();
                waypointManager.SetWaypoint(hitInfo.point);
                movementController.MoveTo(hitInfo.point);
            }
        }

        private void Update()
        {
            movementController.StopMovement();
        }
    }
}