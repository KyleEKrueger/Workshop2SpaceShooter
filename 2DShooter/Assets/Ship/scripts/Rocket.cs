using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    public GameObject explosionPrefab;

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "StopPlate")
        {
            Explosion();
            Destroy(this.gameObject);
            GameObject explosion = Instantiate(explosionPrefab, transform.position, transform.rotation) as GameObject;
            StartCoroutine(Explosion());
            Destroy(explosion);
        }
    }

    IEnumerator Explosion()
    {
        Debug.Log("Start Explosion");
        //CheckForEnemies();
        yield return new WaitForSeconds(3);
        Debug.Log("Remove Explosion");
    }

    void CheckForEnemies()
    {
        Debug.Log("Check For Enemies");
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, 4f);
        foreach(Collider2D c in colliders)
        {
            if (c.GetComponent<EnemyStateManager>())
            {
                c.GetComponent<EnemyStateManager>().DestroyEnemy();
            }
        }
    }
}
