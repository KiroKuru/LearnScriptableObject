using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    SpriteRenderer m_SpriteRenderer;
    public StarRuntimeSet RuntimeSet;
    public StarPoolSO starPoolSO;

    private void OnEnable()
    {
        RuntimeSet.Add(this);
        transform.position=new Vector3(Random.Range(-7.8f,7.8f),Random.Range(-4.2f,4.2f),0);
        Invoke("SelfDestroy", Random.Range(3f, 6f));
    }

    private void OnDisable()
    {
        RuntimeSet.Remove(this);
    }

    void Start()
    {
        m_SpriteRenderer = GetComponent<SpriteRenderer>();

        m_SpriteRenderer.color = Color.blue;
    }

    public void SelfDestroy()
    {
        if (starPoolSO != null)
            starPoolSO.Return(this);
    }
}
