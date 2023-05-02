using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Player))]
[DisallowMultipleComponent]
public class AimatePlayer : MonoBehaviour
{
    private Player player;

    private void Awake()
    {
        player = GetComponent<Player>();
    }

    private void OnEnable()
    {
        player.idleEvent.OnIdle += IdleEvent_OnIdle;

        player.aimWeaponEvent.OnWeaponAim += AimWeaponEvent_OnweaponAim;
    }
    
    
    private void OnDisable()
    {
        player.idleEvent.OnIdle -= IdleEvent_OnIdle;

        player.aimWeaponEvent.OnWeaponAim -= AimWeaponEvent_OnweaponAim;
    }

    private void IdleEvent_OnIdle(IdleEvent idleEvent)
    {
        SetIdleAnimationParameters();
    }

    private void AimWeaponEvent_OnweaponAim(AimWeaponEvent aimWeaponEvent, AimWeaponEventArgs aimWeaponEventArgs)
    {

    }

    private void SetIdleAnimationParameters()
    {
        player.animator.SetBool(Settings.isMoving, false);
        player.animator.SetBool(Settings.isIdle, false);
    }
}
