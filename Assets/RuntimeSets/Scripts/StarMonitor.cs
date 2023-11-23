using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarMonitor : MonoBehaviour
{
    public StarRuntimeSet starRuntimeSet;
    public int starCount=30;

    public GameObject Star;
    private float spawnCoolDown;

    private void Start() {
        starRuntimeSet=Star.GetComponent<Star>().RuntimeSet;
        spawnCoolDown=0;
    }

    public void SpawnStar(){
        Vector3 spawnPos=new Vector3(Random.Range(-7.8f,7.8f),Random.Range(-4.2f,4.2f),0);
        GameObject newStar=GameObject.Instantiate(Star);
        newStar.transform.position=spawnPos;
    }

    private void Update()
	{
		spawnCoolDown -= Time.deltaTime;
		if (spawnCoolDown <= 0) {
			spawnCoolDown = 0.1f;
			
			if (starRuntimeSet.Items.Count < starCount) {
				SpawnStar ();
			}
		}
	}
}
