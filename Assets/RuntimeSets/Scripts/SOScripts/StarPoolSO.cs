using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "StarPool", menuName = "Pool/StarPool")]
public class StarPoolSO : ComponentPoolSO<Star>
{
    [SerializeField]
    private StarFactorySO _factory;

    public override IFactory<Star> Factory
    {
        get =>_factory;
        set =>_factory=value as StarFactorySO;
    }
}
