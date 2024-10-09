using UnityEngine;

[CreateAssetMenu(fileName = "WeaponClipUpgradeBehaviour",
    menuName = "SO/Generate/Item")]
public class GenerateItem : ScriptableObject, IGenerateItem
{
    [SerializeField]
    private string description;

    [SerializeField]
    private GameObject prefab;

    public GameObject Generate(Transform transform)
    {
        //make an instance appear at the transform
        return Instantiate(prefab, transform);
    }
}