using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootShoot2 : MonoBehaviour
{
    public int damage;

    private Rigidbody rb;

    private bool targetHit;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (targetHit)
            return;
        else
            targetHit = true;
        
        if(collision.gameObject.GetComponent<ShootShoot>() != null)
        {
            ShootShoot enemy = collision.gameObject.GetComponent<ShootShoot>();

            enemy.TakeDamage(damage);

            Destroy(gameObject);
        }

        rb.isKinematic = true;

        transform.SetParent(collision.transform);
    }
}
