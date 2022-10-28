using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Round : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public GameObject rocketPrefab;

    public float bulletForce = 20f;
    public float rocketForce = 10f;
    public float pistolRate = 1f;
    public float machineRate = .2f;
    public float shotgunRate = 1f;
    public float rocketRate = 3f;

    public float tiltAroundZ = 30f;
    public float xAngle = 3f;
    public float yAngle = 5f;
    public float maxSpread = 2f;
    public float rocketHeight = 20f;
    
    float nextfire;

    public void ShootPistol()
    {
        if( Time.time > nextfire)
        {
            nextfire = Time.time + pistolRate;
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            bullet.GetComponent<Rigidbody2D>().AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
        }
    }

    public void ShootMachine()
    {
        if (Time.time > nextfire)
        {
            nextfire = Time.time + machineRate;
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            bullet.GetComponent<Rigidbody2D>().AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
        }
    }

    public void ShootShotgun()
    {
        if (Time.time > nextfire)
        {
            nextfire = Time.time + shotgunRate;

            Quaternion leftTarget = Quaternion.Euler(0, 0, tiltAroundZ);
            Quaternion rightTarget = Quaternion.Euler(0, 0, -tiltAroundZ);
            Vector3 angle0 = new Vector3(Random.Range(-maxSpread,maxSpread), Random.Range(1,maxSpread), 0);

            GameObject bullet0 = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation) as GameObject;
            bullet0.GetComponent<Rigidbody2D>().AddForce((firePoint.forward + angle0) * bulletForce, ForceMode2D.Impulse);

            Vector3 angle1 = new Vector3(Random.Range(-maxSpread,maxSpread), Random.Range(1,maxSpread), 0);
            GameObject bullet1 = Instantiate(bulletPrefab, firePoint.position, leftTarget) as GameObject;
            bullet1.GetComponent<Rigidbody2D>().AddForce((firePoint.forward + angle1) * bulletForce, ForceMode2D.Impulse);

            Vector3 angle2 = new Vector3(Random.Range(-maxSpread,maxSpread), Random.Range(1,maxSpread), 0);
            GameObject bullet2 = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation * rightTarget) as GameObject;
            bullet2.GetComponent<Rigidbody2D>().AddForce((firePoint.forward + angle2) * bulletForce, ForceMode2D.Impulse);
        }
    }

    public void ShootRocket()
    {
        if (Time.time > nextfire)
        {
            nextfire = Time.time + rocketRate;
            float randomY = Random.Range(0, rocketHeight);
            Debug.Log(randomY);

            GameObject rocket = Instantiate(rocketPrefab, firePoint.position, firePoint.rotation) as GameObject;
            Rigidbody2D rocketRB = rocket.GetComponent<Rigidbody2D>();
            Transform rocketPos = rocket.GetComponent<Transform>();

            rocketRB.AddForce(firePoint.up * rocketForce, ForceMode2D.Impulse);
        }
    }
}
