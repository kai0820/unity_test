using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private bool moving = false;
    private Quaternion ahead;
    private Vector3 ahead_vec;

    public float speed = 5.0f;

    private Animator m_Animator=null;

    void Start()
    {
        m_Animator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(moving)
        {
            move();
        }
        else
        {
            idle();
        }
    }

    void move()
    {
        m_Animator.SetFloat("Blend", 0.3f, 0.25f, Time.deltaTime);
        this.transform.rotation = ahead;
        this.transform.Translate(ahead_vec * Time.deltaTime * speed, Space.World);
    }

    void idle()
    {
        m_Animator.SetFloat("Blend", 0.0f, 0.0f, Time.deltaTime);
    }

    public void setMovingFlag(bool flag)
    {
        moving = flag;
    }

    public void setQua(Quaternion qua)
    {
        ahead = qua;
    }

    public void setTrans(Vector3 vec)
    {
        ahead_vec = vec;
    }

}
