using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownAimRotation : MonoBehaviour
{
    [SerializeField] private SpriteRenderer armRenderer;
    [SerializeField] private Transform armPivot;
    [SerializeField] private SpriteRenderer characterRenderer;
    private TopDownCharacterController _controller;

    private void Awake()
    {
        _controller = GetComponent<TopDownCharacterController>();    
    }

    void Start() //���콺�� �����̴°� ����
    {
        _controller.OnLookEvent += OnAim;
    }

    // Update is called once per frame
    public void OnAim(Vector2 newAimDirection)
    {
        RotateArm(newAimDirection);
    }
    private void RotateArm(Vector2 direction) //���콺�� �ٶ󺸴� �������� ���� Ȱ�� �����ش�.
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        armRenderer.flipY = Mathf.Abs(rotZ) > 90f;
        characterRenderer.flipX = armRenderer.flipY;
        armPivot.rotation = Quaternion.Euler(0, 0, rotZ);
    }
}
