using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="StoreItemSO",menuName ="ScriptableObjects/NewStoreItemSO",order =1)]
public class StoreItemSO : ScriptableObject
{
    [SerializeField]private string itemName;
    [SerializeField]private string description;
    [SerializeField]private Sprite icon;
    [SerializeField]private int price;
    [SerializeField]private int attack;
    [SerializeField]private int defense;

    public string ItemName=>itemName;
    public string Description=>description;
    public Sprite Icon=>icon;
    public int Price=>price;
    public int Attack=>attack;
    public int Defense=>defense;

    [Header("Sound FX")]
    public AudioClip[]clips;

    [Range(0f,1f)]public float minVolume;
    [Range(0f,1f)]public float maxVolume;
    [Range(-2f,2f)]public float minPitch;
    [Range(-2f,2f)]public float maxPitch;

    public void Play(AudioSource source){
        if(clips.Length<=0)
            return;
            
        source.clip=clips[Random.Range(0,clips.Length)];
        source.volume=Random.Range(minVolume,maxVolume);
        source.pitch=Random.Range(minPitch,maxPitch);

        source.Play();
    }
}
