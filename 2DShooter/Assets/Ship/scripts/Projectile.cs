using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D coll)
    {
        Destroy(gameObject);

        if (coll.gameObject.tag == ("Enemy"))
        {
            Destroy(coll.gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        Destroy(gameObject);
    }
}
