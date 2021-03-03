using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private BulletController bullet_controller;
    private PlayerController player_controller;

    // Start is called before the first frame update
    void Start()
    {
        bullet_controller = GameObject.FindObjectOfType<BulletController>();
        player_controller = GameObject.FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
