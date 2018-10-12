using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

    public List<Item> characterItem = new List<Item>();
    public ItemDataBase itemDataBase;
    public UiInventory uiInventory;

    public void GiveItem(int id )
    {
        Item toAddItem = itemDataBase.GetItem(id);
        characterItem.Add(toAddItem);
        uiInventory.AddNewItem(toAddItem);
        Debug.Log("AddItem : " + toAddItem.title);
    }

    public void GiveItem(string itemName)
    {
        Item toAddItem = itemDataBase.GetItem(itemName);
        characterItem.Add(toAddItem);
        uiInventory.AddNewItem(toAddItem);
        Debug.Log("AddItem : " + toAddItem.title);
    }

    public Item CheckForItem(int id)
    {
        return characterItem.Find(Item => Item.id == id);
    }
    public Item CheckForItem(string itemName)
    {
        return characterItem.Find(Item => Item.title == itemName);
    }

    public void RemoveItem(int id)
    {
        Item itemToRemove = CheckForItem(id);
        
        if(itemToRemove!=null)
        {
            characterItem.Remove(itemToRemove);
            uiInventory.RemoveItem(itemToRemove);
            Debug.Log("Remove item: " + itemToRemove.title);
        }
        else
        {
            Debug.Log("Dong exist :  \" " + id+"\" id item!");
        }
    }
    public void RemoveItem(string itemName)
    {
        Item itemToRemove = CheckForItem(itemName);
        if(itemToRemove!=null)
        {
            characterItem.Remove(itemToRemove);
            uiInventory.RemoveItem(itemToRemove);
            Debug.Log("Dong exist :  \" " + itemName + "\"  item!");

        }
        else
        {
            Debug.Log("Dong exist : "+itemToRemove.title);
        }

    }
    void Start () {
        GiveItem(1);
        GiveItem(0);
        RemoveItem(1);
        RemoveItem(2);
	}
	
	
}
