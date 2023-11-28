using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="StarFactory",menuName ="Factory/StarFactory")]
public class StarFactorySO : FactorySO<Star>
{
    public Star prefab;

    public override Star Create()
    {
        Vector3 spawnPos=new Vector3(Random.Range(-7.8f,7.8f),Random.Range(-4.2f,4.2f),0);
        Star instance=Instantiate(prefab);
        instance.transform.position=spawnPos;
        return instance;
    }
}
