namespace Modules.WeaponConstructor.Sword
{
    public abstract class SwordCreator: Creator
    {
        
        public override Weapon Create()
        {
            return new Sword();
        }
    }
}