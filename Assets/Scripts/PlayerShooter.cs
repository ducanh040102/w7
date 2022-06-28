using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QFSW.MOP2;

public class PlayerShooter : MonoBehaviour
{
    [SerializeField] private float fireRate = 1f;
    [SerializeField] private Transform gunBarrelEnd;
    [SerializeField] private AudioClip _fireAudioClip;
    [SerializeField] private ParticleSystem _fireParticle;

    public ObjectPool bullet;
    
    private Transform _player;
    private float timeCountDown = 0f;
    private AudioSource _audioSource;

    private void Start()
    {
        _player = gameObject.GetComponent<Transform>();
        _audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        timeCountDown -= Time.deltaTime;
        
        if (Input.GetMouseButton(0) && timeCountDown <= 0)
        {
            
            bullet.GetObject(gunBarrelEnd.position,_player.rotation);
            timeCountDown = fireRate;
            _audioSource.PlayOneShot(_fireAudioClip);
            _fireParticle.Play();
        }
    }
}
