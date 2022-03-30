using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour{
    
    public Movement movement;
    public Rigidbody playerBody;

    void OnCollisionEnter (Collision collisionInfo) {

        if (collisionInfo.gameObject.name == "Obstacle"){

            movement.enabled = false;
        }

        if (collisionInfo.gameObject.name == "Jumppad"){

            playerBody.AddForce(0, 1000, 0);
        }
    }
}

