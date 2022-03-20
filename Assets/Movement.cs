using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public Rigidbody rb;
    public float speed = 1000f;
    public float speedIncrease = 0.1f;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void FixedUpdate() {
        transform.position = transform.position + Camera.main.transform * 
        speed = speed + speedIncrease;
    }
}
