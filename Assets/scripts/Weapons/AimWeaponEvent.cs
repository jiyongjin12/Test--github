using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

[DisallowMultipleComponent]
public class AimWeaponEvent : MonoBehaviour
{
    public event Action<AimWeaponEvent, AimWeaponEventArgs> OnWeaponAim;

    public void CallAimWeaponEvent(AimDirection aimDirection, float aimAnlg, float weaponAimAngle, Vector3 weaponAimDirectionVector)
    {
        OnWeaponAim?.Invoke(this, new AimWeaponEventArgs()
        {
            aimDirection = aimDirection,
            aimAnlge = aimAnlg,
            weaponAimAngle = weaponAimAngle,
            weaponAimDirectionVector = weaponAimDirectionVector
        });
    }
}

public class AimWeaponEventArgs : EventArgs
{
    public AimDirection aimDirection;
    public float aimAnlge;
    public float weaponAimAngle;
    public Vector3 weaponAimDirectionVector;
}
