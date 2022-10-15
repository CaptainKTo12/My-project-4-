/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class opa : MonoBehaviour
{
    public Transform Player;
    public float speed = 4f;
    public Rigidbody rb;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = Vector3.MoveTorwards(transform.position, Player.position, speed * Time fixedDeltaTime);

        rb.MovePosition(pos);
        transform.LookAt(Player);
    }
}*/
