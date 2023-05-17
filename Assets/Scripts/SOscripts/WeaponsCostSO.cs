using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptbleObjects", fileName = "WeaponCost")]
public class WeaponsCostSO : ScriptableObject
{
    public int weaponCost;
    public bool itemEquipped = false;
}
