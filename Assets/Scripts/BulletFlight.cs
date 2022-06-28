using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QFSW.MOP2;

public class BulletFlight : MonoBehaviour
{
    [SerializeField] private float flightSpeed;

    public ObjectPool bullet;
    
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * flightSpeed);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Block"))
        {
            bullet.Release(gameObject);
        }
    }
}
