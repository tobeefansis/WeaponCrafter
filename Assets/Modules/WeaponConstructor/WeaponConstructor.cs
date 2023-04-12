using Modules.Inventory;
using UnityEngine;
using Zenject;

namespace Modules.WeaponConstructor
{
    public class WeaponConstructor : MonoBehaviour
    {
        [Inject] private WeaponConstructorView weaponConstructorView;

        [SerializeField] private CreatorItem creatorItem;
        [SerializeField] private Creator creator;
        [Inject]  [SerializeField] private InventoryData inventoryData;
       
        public void SetCreator(CreatorItem newCreator)
        {
            creatorItem = newCreator;
            if (creatorItem== null)
            {
                
                inventoryData.AddItems( weaponConstructorView.creator.GetItems());
                weaponConstructorView.InstantiateCreator(null);
                return;
            }
            creator = weaponConstructorView.InstantiateCreator(creatorItem.Creator);
        }

        public CreatorItem CreatorItem
        {
            get => creatorItem;
            set => SetCreator(value);
        }

        public void Create()
        {
        }
    }
}