﻿using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SyntheticTable : MonoBehaviour
{
    public static List<SyntheticItem> syntheticItems = new List<SyntheticItem>
    {
        new SyntheticItem
        {
            firstItemName = ItemNameDictionary.Hand,
            secondItemName = ItemNameDictionary.Alarm,
            itemEvents = GameObject.Find(ItemNameDictionary.Alarm).GetComponent<ItemEventBasic>().itemEvent,
            generateItemNames = GetListItems(ItemNameDictionary.Eyes),
            disappearItemNames = GetListItems(ItemNameDictionary.Alarm)
        },
        new SyntheticItem
        {
            firstItemName = ItemNameDictionary.Mouth,
            secondItemName = ItemNameDictionary.Face,
            itemEvents = FaceManager.GetFaceEvent(FaceManager.Instance.ChangeWakeUpFace),
            generateItemNames = GetListItems(ItemNameDictionary.Door, ItemNameDictionary.Wardrobe, ItemNameDictionary.Table)
        },
        new SyntheticItem
        {
            firstItemName = ItemNameDictionary.Eyes,
            secondItemName = ItemNameDictionary.Table,
            generateItemNames = GetListItems(ItemNameDictionary.Wallet, ItemNameDictionary.Phone)
        },
        new SyntheticItem
        {
            firstItemName = ItemNameDictionary.Hand,
            secondItemName = ItemNameDictionary.Wardrobe,
            generateItemNames = GetListItems(ItemNameDictionary.Clothes)
        },
        new SyntheticItem
        {
            firstItemName = ItemNameDictionary.Clothes,
            secondItemName = ItemNameDictionary.Face,
            itemEvents = FaceManager.GetFaceEvent(FaceManager.Instance.ChangeNormalFace),
            disappearItemNames = GetListItems(ItemNameDictionary.Clothes)
        },
        new SyntheticItem
        {
            firstItemName = ItemNameDictionary.Foot,
            secondItemName = ItemNameDictionary.Door,
            generateItemNames = GetListItems(ItemNameDictionary.Home, ItemNameDictionary.MRT),
            disappearItemNames = GetListItems(ItemNameDictionary.Door, ItemNameDictionary.Wardrobe, ItemNameDictionary.Table)
        },
        new SyntheticItem
        {
            firstItemName = ItemNameDictionary.Foot,
            secondItemName = ItemNameDictionary.MRT,
            generateItemNames = GetListItems(ItemNameDictionary.Office,ItemNameDictionary.Game,ItemNameDictionary.Shop)
        },
        new SyntheticItem
        {
            firstItemName = ItemNameDictionary.Foot,
            secondItemName = ItemNameDictionary.Home,
            itemEvents = FaceManager.GetFaceEvent(FaceManager.Instance.ChangeNormalFace2),
            generateItemNames = GetListItems(ItemNameDictionary.Door, ItemNameDictionary.Wardrobe, ItemNameDictionary.Table),
            disappearItemNames = GetListItems(ItemNameDictionary.MRT, ItemNameDictionary.Home, ItemNameDictionary.Computer, ItemNameDictionary.Office, ItemNameDictionary.Keyboard)
        },
        new SyntheticItem
        {
            firstItemName = ItemNameDictionary.Foot,
            secondItemName = ItemNameDictionary.Shop,
            generateItemNames = GetListItems(ItemNameDictionary.Food)
        },
        new SyntheticItem
        {
            firstItemName = ItemNameDictionary.MRT,
            secondItemName = ItemNameDictionary.Shop,
            generateItemNames = GetListItems(ItemNameDictionary.Food)
        },
        new SyntheticItem
        {
            firstItemName = ItemNameDictionary.MRT,
            secondItemName = ItemNameDictionary.Office,
            generateItemNames = GetListItems(ItemNameDictionary.CoWorker,ItemNameDictionary.Computer),
            disappearItemNames = GetListItems(ItemNameDictionary.MRT, ItemNameDictionary.Home)
        },
        new SyntheticItem
        {
            firstItemName = ItemNameDictionary.Hand,
            secondItemName = ItemNameDictionary.CoWorker,
            generateItemNames = GetListItems(ItemNameDictionary.Project)
        },
        new SyntheticItem
        {
            firstItemName = ItemNameDictionary.Eyes,
            secondItemName = ItemNameDictionary.Computer,
            generateItemNames = GetListItems(ItemNameDictionary.Keyboard),
            disappearItemNames = GetListItems(ItemNameDictionary.Computer)
        },
        new SyntheticItem
        {
            firstItemName = ItemNameDictionary.Hand,
            secondItemName = ItemNameDictionary.Keyboard,
            generateItemNames = GetListItems(ItemNameDictionary.Windows)
        },
        new SyntheticItem
        {
            firstItemName = ItemNameDictionary.Windows,
            secondItemName = ItemNameDictionary.Project,
            generateItemNames = GetListItems(ItemNameDictionary.Bug),
            disappearItemNames = GetListItems(ItemNameDictionary.Project, ItemNameDictionary.Windows)
        },
       new SyntheticItem
        {
            firstItemName = ItemNameDictionary.Project,
            secondItemName = ItemNameDictionary.Windows,
            generateItemNames = GetListItems(ItemNameDictionary.Bug),
            disappearItemNames = GetListItems(ItemNameDictionary.Project, ItemNameDictionary.Windows)
        },
        new SyntheticItem
        {
            firstItemName = ItemNameDictionary.Keyboard,
            secondItemName = ItemNameDictionary.Bug,
            generateItemNames = GetListItems(ItemNameDictionary.DoneWork),
            disappearItemNames = GetListItems(ItemNameDictionary.Bug)
        },
        new SyntheticItem
        {
            firstItemName = ItemNameDictionary.Eyes,
            secondItemName = ItemNameDictionary.AD,
            generateItemNames = GetListItems(ItemNameDictionary.GlobalGameJamActivityInformation),
            disappearItemNames = GetListItems(ItemNameDictionary.AD)
        },
        new SyntheticItem
        {
            firstItemName = ItemNameDictionary.Hand,
            secondItemName = ItemNameDictionary.Game,
            generateItemNames = GetListItems(ItemNameDictionary.Dream),
            disappearItemNames = GetListItems(ItemNameDictionary.Game, ItemNameDictionary.Keyboard)
        },
        new SyntheticItem
        {
            firstItemName = ItemNameDictionary.Hand,
            secondItemName = ItemNameDictionary.Phone,
            generateItemNames = GetListItems(ItemNameDictionary.AD),
            disappearItemNames = GetListItems(ItemNameDictionary.Phone)
        },
        new SyntheticItem
        {
            firstItemName = ItemNameDictionary.DoneWork,
            secondItemName = ItemNameDictionary.CoWorker,
            generateItemNames = GetListItems(ItemNameDictionary.Home),
            disappearItemNames = GetListItems(ItemNameDictionary.CoWorker, ItemNameDictionary.DoneWork)
        },
        new SyntheticItem
        {
            firstItemName = ItemNameDictionary.Home,
            secondItemName = ItemNameDictionary.Face,
            generateItemNames = GetListItems(ItemNameDictionary.Home),
            disappearItemNames = GetListItems()
        },
        new SyntheticItem
        {
            firstItemName = ItemNameDictionary.GlobalGameJamActivityInformation,
            secondItemName = ItemNameDictionary.Dream,
            itemEvents = EndingManager.GetEndEvent(EndingManager.Instance.GetTrueEnd)
        }
    };

    public static List<string> GetListItems(params string[] itemNames)
    {
        List<string> generateItems = new List<string>();
        generateItems.AddRange(itemNames);
        return generateItems;
    }
}

public class SyntheticItem
{
    public string firstItemName;
    public string secondItemName;
    public UnityEvent itemEvents;
    public List<string> generateItemNames;
    public List<string> disappearItemNames;
}
