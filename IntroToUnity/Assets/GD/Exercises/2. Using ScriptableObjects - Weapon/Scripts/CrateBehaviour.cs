using System.Collections.Generic;
using UnityEngine;

public class CrateBehaviour : MonoBehaviour
{
    [SerializeField]
    [RequireInterface(typeof(IGenerateItem))]
    private List<ScriptableObject> items;

    [SerializeField]
    private Transform target;

    [ContextMenu("Generate Crate Item")]
    public void GenerateCrateItem()
    {
        // Generate a random item from the items
        int index = Random.RandomRange(0, items.Count);

        var generator = items[index] as IGenerateItem;
        generator.Generate(target);

        //instanciate and output to the ground
    }
}