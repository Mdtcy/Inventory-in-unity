using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 存储所有的item的数据库
/// </summary>
public class ItemDataBase : MonoBehaviour
{
    public List<Item> items = new List<Item>();

    private void Awake()
    {
        BuildDatabase();
    }

    public Item GetItem(int id)
    {
        return items.Find(Item => Item.id == id);
    }
    public Item GetItem(string itemName)
    {
        return items.Find(Item => Item.title == itemName);
    }
    void BuildDatabase()
    {
        items = new List<Item>()
        {
            new Item(0,"swod","dd",
            new Dictionary<string, int>{
                { "atk",15},
                {"def",15 }
            }),
            new Item(1,"bow","3a",
            new Dictionary<string, int>{
                { "atk",20},
                {"def",40 }
            }),
            new Item(2,"东西","332",
            new Dictionary<string, int>{
                { "atk",20},
                {"def",40 }
            })

        };
    }
}
