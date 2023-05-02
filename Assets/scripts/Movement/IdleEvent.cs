using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class IdleEvent : MonoBehaviour
{
    public event Action<IdleEvent> OnIdle;

    public void CallIdeEvent()
    {
        OnIdle?.Invoke(this);
    }
}


