using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public Rigidbody rb;
    public float speed;
    public float speedIncrease;
    public float rotateSpeed;
    private float mouseRotate;

    // Update is called once per frame
    void FixedUpdate() {

        transform.position += transform.forward * speed * Time.deltaTime;
        speed += speedIncrease;

        if(Input.GetKey("d")){
            rb.transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);
        }

        else if(Input.GetKey("a")){
            rb.transform.Rotate(0, -rotateSpeed * Time.deltaTime, 0);
        }

        if (Input.GetKeyDown("space")){
            rb.AddForce(0, 300, 0);
        }
    }
}
