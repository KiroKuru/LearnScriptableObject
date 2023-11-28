using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarMonitor : MonoBehaviour
{
    //public StarRuntimeSet starRuntimeSet;
    public StarPoolSO starPoolSO;
    public int initialSize;
    private float spawnCoolDown;

    private void Start()
    {
        starPoolSO.PreWarm(initialSize);
        spawnCoolDown = 0;
    }

    private void Update()
    {
        spawnCoolDown -= Time.deltaTime;
        if (spawnCoolDown <= 0)
        {
            spawnCoolDown = 0.1f;

            Star star = starPoolSO.Request();
            star.starPoolSO = starPoolSO;
        }
    }
}
