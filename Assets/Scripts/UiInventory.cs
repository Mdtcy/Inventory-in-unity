using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiInventory : MonoBehaviour {

    public List<UiItem> uiItems = new List<UiItem>();
    public GameObject slotPrefab;
    public Transform slotPanel;

    /// <summary>
    /// 初始化UIInventory里的UIItem
    /// </summary>
    private void Awake()
    {
        for(int i=0;i<20;i++)
        {
            GameObject instance = Instantiate(slotPrefab);
            instance.transform.SetParent(slotPanel);
            uiItems.Add(instance.GetComponentInChildren<UiItem>());
        }
    }
    /// <summary>
    /// 更新index位置的item
    /// </summary>
    /// <param name="index"></param>
    /// <param name="item"></param>
    public void UpdateSlot(int index,Item item)
    {
        uiItems[index].UpdateItem(item);
    }

    public void AddNewItem(Item item)
    {
        UpdateSlot(uiItems.FindIndex(i=>i.item==null), item);
    }

    public void RemoveItem(Item item)
    {
        UpdateSlot(uiItems.FindIndex(i => i.item == item), null);
    }

}
