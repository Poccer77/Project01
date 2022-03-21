using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public GameObject player;
    public float Offset;

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position - player.transform.forward * Offset;
        transform.LookAt (player.transform.position);
        transform.position = new Vector3 (transform.position.x, transform.position.y + (Offset / 3), transform.position.z);
    }
}
