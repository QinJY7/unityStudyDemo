using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{

    public float speed = 5f;
    private Rigidbody rb;
    void Awake()
    {
        Debug.Log("Awake：物体被加载时执行一次（脚本未启用也会执行）");
    }

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (rb != null)
            rb.useGravity = false;
    }

    void Update()
    {
        //获取键盘输入
        float h = Input.GetAxisRaw("Horizontal");//A左=-1 D右=1
        float v = Input.GetAxisRaw("Vertical");//S下=-1 W上=1
        Vector3 dir = new Vector3(h, 0f, v);
        if (dir.sqrMagnitude > 0.01f)
            dir = dir.normalized;//归一化，避免斜向更快
        if (rb != null)
            rb.MovePosition(rb.position + dir * speed * Time.deltaTime);
        else
            transform.position += dir * speed * Time.deltaTime;

    }
}
