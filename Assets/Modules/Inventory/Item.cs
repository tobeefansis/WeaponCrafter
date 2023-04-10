using System;
using UnityEngine;

namespace Modules.Inventory
{
    [CreateAssetMenu(menuName = "Items/Create ItemData", fileName = "ItemData", order = 0)]
    public class Item  : ScriptableObject
    {
        public string ItemName;
        public Sprite ItemSprite;
        public Mesh ItemMesh;
    }
}