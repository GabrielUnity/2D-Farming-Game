﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryPanel : ItemPanel
{
    //[SerializeField] ItemContainer inventory;
    public override void OnClick(int id)
    {
        //ItemContainer inventory = GameManager.instance.inventoryContainer;
        GameManager.instance.dragAndDropController.OnClick(inventory.slots[id]);
        Show();
    }
}