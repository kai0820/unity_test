using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        print(hor + "   " + ver);
        if (hor != 0 || ver != 0)
            moveRotatein(hor, ver);

    }

    private void moveRotatein(float hor, float ver)
    {
        Quaternion qt = Quaternion.LookRotation(new Vector3(hor, 0, ver));
        this.transform.rotation = qt;

        this.transform.Translate(0, 0, Time.deltaTime);
    }
}
