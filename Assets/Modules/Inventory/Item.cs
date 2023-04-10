using System;
using UnityEngine;

namespace Modules.Inventory
{
    [Serializable]
    public class Item 
    {
        [SerializeField] private ItemData _data;
        [SerializeField] private int count;
        public string ItemName=> _data.itemName;
        public int ItemCount=> count;
        public Sprite ItemSprite=> _data.itemSprite;
        public Mesh ItemMesh=> _data.itemMesh;
        public int MaxCount=> _data.maxCount;
    }
}