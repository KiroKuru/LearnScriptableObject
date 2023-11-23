using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    SpriteRenderer m_SpriteRenderer;
    
    public StarRuntimeSet RuntimeSet;

    private void OnEnable() {
        RuntimeSet.Add(this);
    }

    private void OnDisable() {
        RuntimeSet.Remove(this);
    }

    void Start()
    { 
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
        
        m_SpriteRenderer.color = Color.blue;
    }

    private void Update() {
        Object.Destroy(this.gameObject,Random.Range(3f,8f));
    }
}
