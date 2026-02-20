 using UnityEngine;

public class ItemPickup : Interactable 
{
    public Item Item;
    public override void Interact()
    {
        base.Interact();
        PickUp();
    }

    void PickUp()
    {
        Debug.Log ("Picking up item." + Item.name);
        bool wasPickedUp = Inventory.instance.Add(Item);

         if (wasPickedUp)
            Destroy(gameObject);
    }
}
