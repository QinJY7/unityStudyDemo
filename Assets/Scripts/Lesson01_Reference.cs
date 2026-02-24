using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson01_Reference : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public Transform target;

    void Update()
    {
        if (target == null) return;
        transform.position = Vector3.MoveTowards(transform.position, target.position, 2f * Time.deltaTime);
    }
}

