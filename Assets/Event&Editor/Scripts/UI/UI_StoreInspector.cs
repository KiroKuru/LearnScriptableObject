using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_StoreInspector : MonoBehaviour
{
    [SerializeField]private Image _itemImage;
    [SerializeField]private TextMeshProUGUI _itemName;
    [SerializeField]private TextMeshProUGUI _itemDescription;
    [SerializeField]private TextMeshProUGUI _itemPrice;
    [SerializeField]private TextMeshProUGUI _itemAttackOrDefense;

    [SerializeField]private StoreSelectEventSO _selectEventSO;

    private void OnEnable() {
        _selectEventSO.OnSelect+=RefreshStoreInspectorUI;
    }

    public void RefreshStoreInspectorUI(StoreItemSO itemSO){
        _itemImage.sprite=itemSO.Icon;
        _itemName.text=itemSO.ItemName;
        _itemDescription.text=itemSO.Description;
        _itemAttackOrDefense.text=itemSO.Attack.ToString();
        _itemPrice.text=itemSO.Price.ToString();
    }
}
