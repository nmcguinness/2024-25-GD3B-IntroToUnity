using GD.Types;
using Sirenix.OdinInspector;
using UnityEngine;

namespace GD.Items
{
    [CreateAssetMenu(fileName = "ItemData", menuName = "GD/Data/Item")]
    public class ItemData : ScriptableGameObject
    {
        #region Fields

        [FoldoutGroup("Type & Category", expanded: true)]
        [SerializeField]
        [Tooltip("The name of the item")]
        [Range(0, int.MaxValue)]
        private int value = 1;

        [FoldoutGroup("Type & Category", expanded: true)]
        [SerializeField]
        [Tooltip("The category of item")]
        [EnumToggleButtons]
        private ItemCategoryType itemCategory = ItemCategoryType.Consumable;

        [FoldoutGroup("Type & Category")]
        [SerializeField, EnumPaging]
        [Tooltip("The type of item")]
        private ItemType itemType = ItemType.Resource;

        [FoldoutGroup("Type & Category")]
        [SerializeField]
        [Tooltip("The order of the objective in the list of objectives")]
        [Range(-1, int.MaxValue)]
        private int objectiveOrder = -1;

        [FoldoutGroup("UI & Sound", expanded: true)]
        [SerializeField]
        [PreviewField(50, ObjectFieldAlignment.Left)]
        private Sprite uiIcon;

        [FoldoutGroup("UI & Sound")]
        [SerializeField]
        [AudioClipButton]
        private AudioClip audioClip;

        #endregion Fields

        #region Properties

        public int Value { get => value; set => this.value = value; }

        public ItemCategoryType ItemCategory { get => itemCategory; set => itemCategory = value; }
        public ItemType ItemType { get => itemType; set => itemType = value; }

        public Sprite UiIcon { get => uiIcon; set => uiIcon = value; }
        public AudioClip AudioClip { get => audioClip; set => audioClip = value; }

        #endregion Properties
    }
}