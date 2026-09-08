using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Item
{
    public enum ItemType
    {
        Flashlight,
        Key,
    }

    public ItemType itemType;
    public int amount;

    public Sprite GetSprite()
    {
        switch (itemType)
        {
            default:
            case ItemType.Flashlight: return ItemAssets.Instance.flashlight;
            case ItemType.Key: return ItemAssets.Instance.key;
        }
    }

    public GameObject GetGameObject()
    {
        switch (itemType)
        {
            default:
            case ItemType.Flashlight: return ItemAssets.Instance.pfflashlight;
            case ItemType.Key: return ItemAssets.Instance.pfkey;
        }
    }

    public bool IsStackable()
    {
        switch (itemType)
        {
            default:
            case ItemType.Flashlight:
            case ItemType.Key:
                return true;
        }
    }

}