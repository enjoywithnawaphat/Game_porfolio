using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flashlight : Interactable
{
    [SerializeField] private Item.ItemType itemType;
    [SerializeField] private int amount = 1;

    protected override void Interact()
    {
        PlayerController player = FindFirstObjectByType<PlayerController>();

        player.AddItem(itemType, amount);
    }
}
