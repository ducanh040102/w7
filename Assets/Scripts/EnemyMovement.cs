using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    private GameObject player;
    private NavMeshAgent _navMeshAgent;

    private Animator _animator;

    private void Start()
    {
        player = GameObject.Find("Player");
        _navMeshAgent = gameObject.GetComponent<NavMeshAgent>();
        _animator = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        if (player)
        {
            _animator.SetBool("is_moving",true);
            _navMeshAgent.SetDestination(player.transform.position);
        }
        else
        {
            _animator.SetBool("is_moving",false);
        }
    }
}
