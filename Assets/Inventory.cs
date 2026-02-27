using UnityEngine;
using System.Collections.Generic;

public class Inventory : MonoBehaviour
{
    #region Singleton

    public static Inventory instance;

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("More than one instance of Inventory found!");
            return;
        }
        instance = this;
    }

    #endregion

    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallback;

    public int space = 20;

    public List<Item> items = new List<Item>();

    // Add an item to the inventory
    public bool Add(Item item)
    {
        if (!item.isDefaultItem)
        {
            if (items.Count >= space)
            {
                Debug.Log("Not enough room.");
                return false;
            }

            items.Add(item);

            // Update UI
            if (onItemChangedCallback != null)
                onItemChangedCallback.Invoke();
        }
        return true;
    }

    // Remove an item from the inventory
    public void Remove(Item item)
    {
        if (items.Contains(item))
        {
            items.Remove(item);

            // Update UI
            if (onItemChangedCallback != null)
                onItemChangedCallback.Invoke();
        }
    }
}