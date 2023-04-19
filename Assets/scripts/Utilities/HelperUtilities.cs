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

        //화면 크기에 맞게 마우스 위치 고정

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
    //22도에서 67도는 upRight
    //67도에서 112도는 up
    //112도에서 158도는 upLeft
    //138도에서 -135도는 Left
    //-135도에서 -45도는 Down
    //-45도에서 22도는 Right

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
