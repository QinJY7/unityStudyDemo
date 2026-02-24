using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson01_Trigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("有物体进入了触发器:" + other.name);
        if (other.CompareTag("Player"))//Cube的Tag需设置为Player
            Debug.Log("玩家进入!");
    }
}
