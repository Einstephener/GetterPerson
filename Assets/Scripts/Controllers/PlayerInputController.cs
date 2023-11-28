using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : TopDownCharacterController
{
    private Camera _camera;

    private void Awake()
    {
        _camera = Camera.main;  
    }

    public void OnMove(InputValue value)
    {
        //Debug.Log("OnMove" + value.ToString());
        Vector2 moveInput = value.Get<Vector2>().normalized;
        //nomalized를 하는 이유: 방향 2개를 같이 누를 때, 루트2가 나오기때문에 대각선 방향이 더 빠르게 됨.

        CallMoveEvent(moveInput);
    }
    public void OnLook(InputValue value)
    {
        //Debug.Log("OnLook" + value.ToString());
        Vector2 newAim = value.Get<Vector2>();
        Vector2 worldPos = _camera.ScreenToWorldPoint(newAim);
        newAim = (worldPos - (Vector2)transform.position).normalized; //player한테서 mousepoint를 바라보는 방향

        if(newAim.magnitude >= .9f) //magnitude = 크기. nomalized했으므로 1.
        {
            CallLookEvent(newAim);
        }

    }
    public void OnFire(InputValue value)
    {
        IsAttacking = value.isPressed;
    }
}
