using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class updateTest : MonoBehaviour
{
    void Start()
    {
        
    }


    public float moveSpeed = 2f;
    void Update()
    {
        float step = moveSpeed * Time.deltaTime;
        transform.position += new Vector3(step, 0f, 0f);
    }
}
