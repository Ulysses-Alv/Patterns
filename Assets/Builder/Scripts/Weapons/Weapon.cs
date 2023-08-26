using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] int damage;
    [SerializeField] WeaponRange weaponRange;
    [SerializeField] TypeOfWeapon typeOfWeapon;
}
public enum WeaponRange
{
    Short_Range, 
    Long_Range

}
public enum TypeOfWeapon
{
    Physical,
    Magical
}
