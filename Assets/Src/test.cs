using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 旋转注视
        Quaternion qua = Quaternion.LookRotation(new Vector3(Time.deltaTime, 0, Time.deltaTime));
        // 人物旋转
        transform.rotation = qua;

        this.transform.Translate(new Vector3(0, 0, 1), Space.World);
    }
}
