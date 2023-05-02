using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(IdleEvent))]
public class Idle : MonoBehaviour
{
    private Rigidbody2D rb2D;
    private IdleEvent idleEvent;

    private void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
        idleEvent = GetComponent<IdleEvent>();
    }

    private void OnEnable()
    {
        idleEvent.OnIdle += IdleEvent_OnIdle;
    }

    private void IdleEvent_OnIdle(IdleEvent idleEvent)
    {
        MoveRigideBody();
    }

    private void MoveRigideBody()
    {
        rb2D.velocity = Vector2.zero;
    }
}
