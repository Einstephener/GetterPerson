using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PenguinAnimation : MonoBehaviour
{
    private Animator _animator;
    Vector2 movement = new Vector2();
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }
    private void Update()
    {
        UpdateState();
    }

    private void FixedUpdate()
    {
        MoveCharacter();
    }

    private void MoveCharacter()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        movement.Normalize();

    }
    private void UpdateState()
    {
        if (movement.x != 0)
        {
            _animator.SetBool("isMove", true);
        }
        else if (movement.y != 0)
        {
            _animator.SetBool("isMove", true);
        }
        else
        {
            _animator.SetBool("isMove", false);
        }
    }
}
