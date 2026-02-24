using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lesson01_getcomponent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Transform t = GetComponent<Transform>();
        if (t != null)
            t.position = new Vector3(0f, 1f, 0f);

        transform.position = new Vector3(0f, 1f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
