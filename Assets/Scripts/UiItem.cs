using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UiItem : MonoBehaviour {

    public Item item;
    private Image itemImage;

    private void Awake()
    {
        itemImage = GetComponent<Image>();
        UpdateItem(null);
    }

    /// <summary>
    /// 更新UIItem里的图标，如果这个slot里没有item，则将sprite设为透明
    /// </summary>
    /// <param name="item"></param>
    public void UpdateItem(Item item)
    {
        this.item = item;
        if(this.item!=null)
        {
            itemImage.color = Color.white;
            itemImage.sprite = this.item.icon;
        }
        else
        {
            itemImage.color = Color.clear;
        }
    }
}
