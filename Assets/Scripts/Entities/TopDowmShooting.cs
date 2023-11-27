using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDowmShooting : MonoBehaviour
{
    private TopDownCharacterController _controller;

    [SerializeField]private Transform projectileSpawnPosition;
    private Vector2 _aimDirection = Vector2.right;

    public GameObject testPrefab;

    // Start is called before the first frame update
    private void Awake()
    {
        _controller = GetComponent<TopDownCharacterController>();
    }
    void Start()
    {
        _controller.OnAttackEvent += OnShoot;
        _controller.OnLookEvent += OnAim;
    }

    private void OnAim(Vector2 newAimDirection)
    {
        _aimDirection = newAimDirection;
    }

    private void OnShoot()
    {
        CreatProjectile();
    }

    private void CreatProjectile()
    {
        Instantiate(testPrefab, projectileSpawnPosition.position,Quaternion.identity);
    }

}
