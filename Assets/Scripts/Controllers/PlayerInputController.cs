using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : TopDownCharacterController
{
    private Camera _camera;
    private Animator _animator;

    private void Awake()
    {
        _camera = Camera.main;  
    }
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void OnMove(InputValue value)
    {
        //Debug.Log("OnMove" + value.ToString());
        Vector2 moveInput = value.Get<Vector2>().normalized;
        //nomalized를 하는 이유: 방향 2개를 같이 누를 때, 루트2가 나오기때문에 대각선 방향이 더 빠르게 됨.
        if (moveInput!= Vector2.zero)
        {
            _animator.SetBool("isMove", true);
        }
        else
        {
            _animator.SetBool("isMove", false);
        }
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
