using UnityEngine;

namespace Modules.WeaponConstructor.Sword
{
    [CreateAssetMenu(menuName = "Items/Sword", fileName = "SwordBlade", order = 0)]
    public class Sword : Weapon
    {
        public SwordBlade blade;
        public SwordGrip grip;
        public SwordGuard guard;
        public SwordHilt hilt;
    }
}