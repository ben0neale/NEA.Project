using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public CharacterController controller;

    public Animator anim;

    public float speed = 8;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.A) && (Input.GetKey(KeyCode.W)))
        {
            anim.SetFloat("vertical", 1);
            anim.SetFloat("horizontal", 1);
        }
        else if (Input.GetKey(KeyCode.D) && (Input.GetKey(KeyCode.W)))
        {
            anim.SetFloat("vertical", 1);
            anim.SetFloat("horizontal", -1);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            anim.SetFloat("vertical", 1);
            anim.SetFloat("horizontal", 0);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            anim.SetFloat("vertical", 1);
            anim.SetFloat("horizontal", 3);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            anim.SetFloat("vertical", 1);
            anim.SetFloat("horizontal", 2);
        }
        else
        {
            anim.SetFloat("horizontal", 0);
            anim.SetFloat("vertical", 0);
        }
    }
}
