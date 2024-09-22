using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class Enemy : MonoBehaviour
{
    public States state;
    public float attackDistance;
    public float followDistance;
    public float escapeDistance;

    public bool authomaticTargetSelection = true;
    public Transform target;
    public float distance;

    public void Awake()
    {
        if(authomaticTargetSelection)
            target = GameObject.FindGameObjectWithTag("Player").transform;
        StartCoroutine(CalculateDistance());
    }

    private void LateUpdate()
    {
        CheckState();
    }

    private void CheckState()
    {
        switch (state)
        {
            case States.idle:
                IdleState();
                break;
            case States.follow:
                FollowState();
                break;
            case States.attack:
                AttackState();
                break;
            default:
                break;
        }
    }

    public void ChangeState(States e)
    {
        switch (e)
        {
            case States.idle:
                break;
            case States.follow:
                break;
            case States.attack:
                break;
            default:
                break;
        }
        state = e;
    }

    public virtual void IdleState()
    {
        if (distance < followDistance)
        {
            ChangeState(States.follow);
        }
    }

    public virtual void FollowState()
    {
        if (distance < attackDistance)
        {
            ChangeState(States.attack);
        }
        else if (distance > escapeDistance)
        {
            ChangeState(States.idle);
        }
    }

    public virtual void AttackState()
    {
        if (distance > attackDistance + 0.4f)
        {
            ChangeState(States.follow);
        }
    }

    IEnumerator CalculateDistance()
    {
        while (true)
        {
            if (target != null)
            {
                distance = Vector3.Distance(transform.position, target.position);
                yield return new WaitForSeconds(0.3f);
            }
        }
    }

#if UNITY_EDITOR
    private void OnDrawGizmosSelected()
    {
        Handles.color = Color.red;
        Handles.DrawWireDisc(transform.position, Vector3.up, attackDistance);
        Handles.color = Color.yellow;
        Handles.DrawWireDisc(transform.position, Vector3.up, followDistance);
        Handles.color = Color.green;
        Handles.DrawWireDisc(transform.position, Vector3.up, escapeDistance);
    }

#endif
}

public enum States
{
    idle = 0,
    follow = 1,
    attack = 2
}