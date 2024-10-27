using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(NavMeshAgent))]

public class BookHeadEnemy : Enemy
{
    private NavMeshAgent agent;
    public Animator animaciones;

    public void Awake()
    {
        base.Awake();
        agent = GetComponent<NavMeshAgent>();
    }

    public override void IdleState()
    {
        base.IdleState();
        agent.SetDestination(transform.position);
        animaciones.SetFloat("Velocidad", 0);
    }

    public override void FollowState()
    {
        base.FollowState();      
        agent.SetDestination(target.position);
        animaciones.SetFloat("Velocidad", 1);
    }

    public override void AttackState()
    {
        base.AttackState();
        agent.SetDestination(transform.position);
        transform.LookAt(target, Vector3.up);
        FindAnyObjectByType<GameOver>().MostrarGameOver();
        Debug.Log("moriste");
    }
}