using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
#region REQUIRE COMPONENTS
[RequireComponent(typeof(IdleEvent))]
[RequireComponent(typeof(Idle))]
[RequireComponent(typeof(AimWeaponEvent))]
[RequireComponent(typeof(AimWeapon))]
#endregion REQUIRE COMPONENTS
*/


public class Player : MonoBehaviour
{
    [HideInInspector] public IdleEvent idleEvent;
    [HideInInspector] public AimWeaponEvent aimWeaponEvent;

    private void Awake()
    {
        idleEvent = GetComponent<IdleEvent>();
        aimWeaponEvent = GetComponent<AimWeaponEvent>();
    }
}
