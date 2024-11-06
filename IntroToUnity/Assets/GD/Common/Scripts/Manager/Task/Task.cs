using UnityEngine;
using UnityEngine.Events;
using Sirenix.OdinInspector;
using GD.Types;

namespace GD.Tasks
{
    /// <summary>
    /// <b>Task</b> represents a scheduled task that can be executed by the <see cref="TaskManager"/>.
    /// It supports delayed execution, repetition, and events for start and completion.
    /// </summary>
    [CreateAssetMenu(fileName = "Task", menuName = "GD/Tasks/Task")]
    public class Task : ScriptableGameObject
    {
        #region Fields and Properties

        // Group settings under a foldout
        [FoldoutGroup("Settings"), SerializeField, Tooltip("Initial delay in seconds before the task is first executed")]
        private float delay = 0f;

        [FoldoutGroup("Settings"), SerializeField, Tooltip("Interval in seconds between task repetitions")]
        private float repeatInterval = 0f;

        [FoldoutGroup("Settings"), SerializeField, Tooltip("Number of times the task should repeat. 1 = execute once, N = execute N times, -1 = infinite repetitions")]
        private int repeatCount = 1;

        // UnityEvents for task start and completion
        [FoldoutGroup("Events"), SerializeField, Tooltip("Event invoked when the task starts")]
        private UnityEvent onStarted = new UnityEvent();

        [FoldoutGroup("Events"), SerializeField, Tooltip("Event invoked when the task completes")]
        private UnityEvent onCompleted = new UnityEvent();

        // Non-serialized runtime fields
        [SerializeField, HideInInspector]
        private int currentExecutions = 0;

        [SerializeField, HideInInspector]
        private float scheduledTime;

        // Public properties to access private fields
        [FoldoutGroup("Settings"), PropertyOrder(0)]
        public float Delay
        {
            get => delay;
            set => delay = Mathf.Max(0f, value);
        }

        [FoldoutGroup("Settings"), PropertyOrder(1)]
        public float RepeatInterval
        {
            get => repeatInterval;
            set => repeatInterval = Mathf.Max(0f, value);
        }

        [FoldoutGroup("Settings"), PropertyOrder(2)]
        public int RepeatCount
        {
            get => repeatCount;
            set
            {
                if (value == 0)
                    throw new System.ArgumentException("RepeatCount cannot be zero.", nameof(value));
                repeatCount = value;
            }
        }

        [FoldoutGroup("Events"), PropertyOrder(3)]
        public UnityEvent OnStarted
        {
            get => onStarted;
            set => onStarted = value ?? new UnityEvent();
        }

        [FoldoutGroup("Events"), PropertyOrder(4)]
        public UnityEvent OnCompleted
        {
            get => onCompleted;
            set => onCompleted = value ?? new UnityEvent();
        }

        // Runtime Info for display in TaskManager
        [TableColumnWidth(150, Resizable = false), ShowInInspector, ReadOnly, LabelText("Task Name")]
        public string TaskName => name;

        [TableColumnWidth(50, Resizable = false), ShowInInspector, ReadOnly, LabelText("Exec Count")]
        public int CurrentExecutions
        {
            get => currentExecutions;
            private set => currentExecutions = value;
        }

        [TableColumnWidth(80, Resizable = false), ShowInInspector, ReadOnly, LabelText("Next In"), PropertyOrder(7)]
        public string TimeUntilNextExecution
        {
            get
            {
                float timeRemaining = ScheduledTime - Time.time;
                return timeRemaining > 0 ? timeRemaining.ToString("F2") + "s" : "Executing";
            }
        }

        [TableColumnWidth(60, Resizable = false), ShowInInspector, ReadOnly, LabelText("Repeats")]
        public string RepeatInfo => RepeatCount == -1 ? "∞" : (RepeatCount - CurrentExecutions).ToString();

        #endregion Fields and Properties

        #region Methods

        /// <summary>
        /// Determines if the task should be rescheduled based on the repeat count.
        /// </summary>
        public bool ShouldReschedule()
        {
            // Repeat indefinitely if RepeatCount is -1
            if (RepeatCount == -1)
            {
                return true;
            }

            // Reschedule if CurrentExecutions is less than RepeatCount
            return CurrentExecutions < RepeatCount;
        }

        /// <summary>
        /// Executes the task by invoking the OnStarted and OnCompleted events.
        /// Increments the execution count.
        /// </summary>
        /// <param name="context">The context containing dependencies for the task.</param>
        public virtual void Execute(TaskContext context)
        {
            // Increment the execution count
            CurrentExecutions++;

            // Invoke the OnStarted event
            OnStarted?.Invoke();

            // Perform task-specific logic using the context
            PerformTaskLogic(context);

            // Invoke the OnCompleted event
            OnCompleted?.Invoke();
        }

        /// <summary>
        /// Performs the task-specific logic. Override this method in subclasses to implement custom behavior.
        /// </summary>
        /// <param name="context">The context containing dependencies for the task.</param>
        protected virtual void PerformTaskLogic(TaskContext context)
        {
            // Default implementation does nothing
            // Subclasses can override this method to implement task-specific logic
        }

        /// <summary>
        /// Resets the task's execution data.
        /// Should be called before scheduling the task to clear previous execution state.
        /// </summary>
        public void ResetTask()
        {
            CurrentExecutions = 0;
        }

        /// <summary>
        /// Gets or sets the scheduled time for the task execution.
        /// </summary>
        [ShowInInspector, ReadOnly]
        public float ScheduledTime
        {
            get => scheduledTime;
            internal set => scheduledTime = value;
        }

        #endregion Methods
    }
}