using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponTypeHolder : MonoBehaviour
{
    public WeaponsCostSO weaponCostScript;
    public bool isItemSold;
    public bool isItemEquipped;
    [HideInInspector] public int coinAmount;
    private void Awake()
    {
        coinAmount = weaponCostScript.weaponCost;
        isItemSold = weaponCostScript.itemSold;
        isItemEquipped = weaponCostScript.itemEquipped;
    }
}
