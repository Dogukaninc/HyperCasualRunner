using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class WeaponTypeHolder : MonoBehaviour, IDataPersistence
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
        isItemEquipped = weaponCostScript.itemEquipped;
    }
    public void LoadData(GameData data)
    {
        var weaponItem = this.gameObject.GetComponent<WeaponTypeHolder>();

        data.weaponSold.TryGetValue(weaponItem.id, out weaponItem.isItemSold);
        //if (weaponItem.isItemSold)
        //{
        //    //satýn alma butonunu kapat
        //}
    }

    public void SaveData(ref GameData data)
    {
        var weaponItem = this.gameObject.GetComponent<WeaponTypeHolder>();
        if (data.weaponSold.ContainsKey(weaponItem.id))
        {
            data.weaponSold.Remove(weaponItem.id);
        }
        data.weaponSold.Add(weaponItem.id, weaponItem.isItemSold);

    }

}
