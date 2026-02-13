using UnityEngine;

[CreateAssetMenu(fileName="New Item", menuName = "Inventory/Item")]
public class Item : ScriptableOject
{
    new public strinng name = "New Item";
    public Sprite icon = null;
    public bool isDefaultItem = false;

    //5:29 min /ep.04
}
