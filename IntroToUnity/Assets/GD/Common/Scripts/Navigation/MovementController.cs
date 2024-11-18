
using UnityEngine;
using UnityEngine.AI;
using Sirenix.OdinInspector;

namespace GD.Navigation
{
    /// <summary>
    /// Controls character movement and animations.
    /// </summary>
    public class MovementController : MonoBehaviour, IMovementController
    {
        private NavMeshAgent navMeshAgent;
        private Animator animator;

        private void Start()
        {
            navMeshAgent = GetComponent<NavMeshAgent>();
            animator = GetComponent<Animator>();
        }

        public void MoveTo(Vector3 destination)
        {
            navMeshAgent.SetDestination(destination);
            animator.SetBool("IsWalking", true);
        }

        public void StopMovement()
        {
            if (Vector3.Distance(navMeshAgent.destination, transform.position) <= navMeshAgent.stoppingDistance)
            {
                animator.SetBool("IsWalking", false);
            }
        }
    }
}
