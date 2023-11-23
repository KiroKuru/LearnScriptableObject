using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_StoreItem : MonoBehaviour
{
    [SerializeField]private StoreItemSO _itemSO;
    [SerializeField]private StoreSelectEventSO _selectEventSO;

    public void OnSelect(){
        _selectEventSO.Raise(_itemSO);
    }
}
