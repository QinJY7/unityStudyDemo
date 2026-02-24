using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson01_Spawn : MonoBehaviour
{
    
    void Start()
    {
        
    }

    public GameObject prefab;
    public KeyCode spawnKey = KeyCode.S;
    void Update()
    {
        if(Input.GetKeyDown(spawnKey) && prefab != null)
        {
            Vector3 pos = transform.position + Random.insideUnitSphere * 2f;
            pos.y = transform.position.y;
            Instantiate(prefab, pos, Quaternion.identity);
        }

    }
}
