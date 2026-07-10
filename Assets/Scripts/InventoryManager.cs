using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    private ItemClass currentItem;

    public void Add(ItemClass item)
    {
        if (currentItem == null)
        {
            // This should be a gameobject later on housing the attached itemclass
            DropItem();
            currentItem = item;
        }
    }
    public void Remove(ItemClass item)
    {
        currentItem = null;
    }

    public void DropItem()
    {
        
    }
}
