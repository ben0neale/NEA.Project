﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public Rigidbody RB;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) && (Input.GetKey(KeyCode.W)))
        {
            anim.SetFloat("vertical", 1);
            anim.SetFloat("horizontal", 1);
            RB.AddForce(-6, 0, 6);
        }
        else if (Input.GetKey(KeyCode.D) && (Input.GetKey(KeyCode.W)))
        {
            anim.SetFloat("vertical", 1);
            anim.SetFloat("horizontal", -1);
            RB.AddForce(6, 0, 6);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            anim.SetFloat("vertical", 1);
            anim.SetFloat("horizontal", 0);
            RB.AddForce(0, 0, 6);
        }
        else
        {
            anim.SetFloat("horizontal", 0);
            anim.SetFloat("vertical", 0);
        }
    }
}
