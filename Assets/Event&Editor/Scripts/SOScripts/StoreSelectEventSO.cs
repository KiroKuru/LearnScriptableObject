using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName ="Events/SelectEventSO")]
public class StoreSelectEventSO : ScriptableObject
{
    public UnityAction<StoreItemSO>OnSelect;

    public void Raise(StoreItemSO itemSO){
        OnSelect?.Invoke(itemSO);
    }
}
