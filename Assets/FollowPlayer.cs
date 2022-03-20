using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public Transform player;
    public float horizontalOffset;
    public float verticalOffset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + new Vector3(0, verticalOffset, -horizontalOffset);
        transform.LookAt(player);
        transform.Translate(Vector3.right * Time.deltaTime);

    }
}
