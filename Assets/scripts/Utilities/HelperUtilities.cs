using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class HelperUtilities
{
    public static Camera mainCamera;

    public static Vector3 GetMouseWoldPosition()
    {
        if (mainCamera == null) mainCamera = Camera.main;

        Vector3 mouseScreenPosition = Input.mousePosition;

        //ȭ�� ũ�⿡ �°� ���콺 ��ġ ����

        mouseScreenPosition.x = Mathf.Clamp(mouseScreenPosition.x, 0f, Screen.width);
        mouseScreenPosition.y = Mathf.Clamp(mouseScreenPosition.y, 0f, Screen.height);

        Vector3 worldPosition = mainCamera.ScreenToViewportPoint(mouseScreenPosition);

        worldPosition.z = 0f;

        return worldPosition;
    }

    public static float GetAngleFromVector(Vector3 vector)
    {
        float radians = Mathf.Atan2(vector.y, vector.x);

        float degrees = radians * Mathf.Rad2Deg;

        return degrees;
    }

    //AimDirection 
    //22������ 67���� upRight
    //67������ 112���� up
    //112������ 158���� upLeft
    //138������ -135���� Left
    //-135������ -45���� Down
    //-45������ 22���� Right

    public static AimDirection GetAimDirection(float angleDegerees)
    {
        AimDirection aimDirection;

        //UpRight
        if (angleDegerees >= 22f && angleDegerees <= 67f)
        {
            aimDirection = AimDirection.UpRight;
        }
        //Up
        else if (angleDegerees > 67f && angleDegerees <= 112f)
        {
            aimDirection = AimDirection.Up;
        }
        //UpLeft
        else if (angleDegerees > 112f && angleDegerees <= 158f)
        {
            aimDirection = AimDirection.UpLeft;
        }
        //Left
        else if ((angleDegerees <= 180f && angleDegerees > 158f) || (angleDegerees > -180 && angleDegerees <= -135f))
        {
            aimDirection = AimDirection.Left;
        }
        //Down
        else if ((angleDegerees > -135 && angleDegerees <= -45f))
        {
            aimDirection = AimDirection.Down;
        }
        //Right
        else if ((angleDegerees > -45f && angleDegerees <= 0f) || (angleDegerees > 0 && angleDegerees < 22f))
        {
            aimDirection = AimDirection.Right;
        }
        else
        {
            aimDirection = AimDirection.Right;
        }
        return aimDirection;
    }
}
