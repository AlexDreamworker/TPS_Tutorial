using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletProjectile : MonoBehaviour
{
    //[SerializeField] private Transform vfxHitGreen;
    //[SerializeField] private Transform vfxHitRed;

    private Rigidbody bulletRigidbody;

    private void Awake()
    {
        bulletRigidbody = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        float speed = 40f;
        bulletRigidbody.velocity = transform.forward * speed;
    }

    private void OnTriggerEnter(Collider other)
    {
        //----PARTICLE SETTINGS----
        //
        if (other.GetComponent<BulletTarget>() != null)
        {
            Debug.Log("This is a TARGET!");
            //Instantiate(vfxHitGreen, transform.position, Quaternion.identity);
        }
        else
        {
            Debug.Log("This is NOT a target");
            //Instantiate(vfxHitRed, transform.position, Quaternion.identity);
        }
        Destroy(gameObject);
    }
}
