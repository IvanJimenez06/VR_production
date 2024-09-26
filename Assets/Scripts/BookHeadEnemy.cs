using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class BookHeadEnemy : Enemy
{
    public Animator animaciones;
    private NavMeshAgent agent;

    public void Awake()
    {
        base.Awake();
        agent = GetComponent<NavMeshAgent>();
    }

    public override void IdleState()
    {
        base.IdleState();
        animaciones.SetFloat("Velocidad", 0);
        agent.SetDestination(transform.position);
    }

    public override void FollowState()
    {
        base.FollowState();
        animaciones.SetFloat("Velocidad", 1);
        agent.SetDestination(target.position);
        
    }

    public override void AttackState()
    {
        base.AttackState();
        agent.SetDestination(transform.position);
        transform.LookAt(target, Vector3.up);
    }
}