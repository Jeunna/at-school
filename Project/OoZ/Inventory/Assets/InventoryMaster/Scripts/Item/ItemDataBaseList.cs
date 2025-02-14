﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemDataBaseList : ScriptableObject
{             //The scriptableObject where the Item getting stored which you create(ItemDatabase)

    [SerializeField]
    public List<Item> itemList = new List<Item>();              //List of it

    public Item getItemByID(int id)
    {
        for (int i = 0; i < itemList.Count; i++)
        {
            if (itemList[i].itemID == id)
                return itemList[i].getCopy();
        }
        return null;
    }

    public Item getItemByName(string name)
    {
        for (int i = 0; i < itemList.Count; i++)
        {
            if (itemList[i].itemName.ToLower().Equals(name.ToLower()))
                return itemList[i].getCopy();
        }
        return null;
    }

    public int getItemValueByID(int id)
    {
        Item item = getItemByID(id);
        return item.itemValue;
    }

    public void setItemValue(int id, int value)
    {
        for (int i = 0; i < itemList.Count; i++)
        {
            if (itemList[i].itemID == id)
                itemList[i].itemValue = value;
        }
    }

    public void initItem()
    {
        for (int i = 0; i < itemList.Count; i++)
        {
            itemList[i].itemValue = 1;
        }
    }
}
