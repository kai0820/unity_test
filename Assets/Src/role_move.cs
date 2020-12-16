using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class role_move : MonoBehaviour
{
    private float x = 0;
    private float y = 0;
    private float z = 0;
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
        z += ver;
        if (hor != 0 || ver != 0)
            moveRotatein(hor, ver);
    }

    private void moveRotatein(float ver)
    {
        Quaternion qt = Quaternion.LookRotation(new Vector3(0, 0, ver));
        print(ver);
        this.transform.rotation = qt;

        this.transform.Translate(0, 0, Time.deltaTime);
    }

    private void moveRotatein(float hor, float ver)
    {
        Quaternion qt = Quaternion.LookRotation(new Vector3(0, 0, hor));
        print(hor);
        this.transform.rotation = qt;

        this.transform.Translate(0, 0, Time.deltaTime);
    }
}
