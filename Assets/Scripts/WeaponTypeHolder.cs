using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class WeaponTypeHolder : MonoBehaviour
{
    public WeaponsCostSO weaponCostScript;
    public bool isItemSold;
    public bool isItemEquipped;
    [HideInInspector] public int _weaponCost;

    public string id;

    [ContextMenu("Generate guid for id")]
    private void GenerateGuid()
    {
        id = System.Guid.NewGuid().ToString();
    }
    private void Awake()
    {
        _weaponCost = weaponCostScript.weaponCost;
        isItemSold = weaponCostScript.itemSold;
        isItemEquipped = weaponCostScript.itemEquipped;
    }


}
