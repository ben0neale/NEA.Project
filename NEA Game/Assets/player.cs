using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public Rigidbody RB;
    public Animator anim;

    public float speed = 10;

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
            RB.AddForce((Vector3.forward + Vector3.left) * speed);
        }
        else if (Input.GetKey(KeyCode.D) && (Input.GetKey(KeyCode.W)))
        {
            anim.SetFloat("vertical", 1);
            anim.SetFloat("horizontal", -1);
            RB.AddForce((Vector3.forward + Vector3.right) * speed);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            anim.SetFloat("vertical", 1);
            anim.SetFloat("horizontal", 0);
            RB.AddForce(Vector3.forward * speed);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            anim.SetFloat("vertical", 1);
            anim.SetFloat("horizontal", 3);
            RB.AddForce(Vector3.left * speed);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            anim.SetFloat("vertical", 1);
            anim.SetFloat("horizontal", 2);
            RB.AddForce(Vector3.right * speed);
        }
        else
        {
            anim.SetFloat("horizontal", 0);
            anim.SetFloat("vertical", 0);
        }
    }
}
