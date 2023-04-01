using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponTypeHolder : MonoBehaviour
{
    public WeaponsCostSO weaponCostScript;
    public bool isItemSold;
    public bool isItemEquipped;
    [HideInInspector] public int _weaponCost;
    private void Awake()
    {
        _weaponCost = weaponCostScript.weaponCost;
        isItemSold = weaponCostScript.itemSold;
        isItemEquipped = weaponCostScript.itemEquipped;
    }
}
