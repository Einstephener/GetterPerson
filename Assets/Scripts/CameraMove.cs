using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class MainCamera_Action : MonoBehaviour
{
    public Transform[] targets; // 각 플레이어에 대한 타겟 설정
    public float offsetX = 0.0f;
    public float offsetY = 0.0f;
    public float offsetZ = -10.0f;
    public float cameraSpeed = 10.0f;

    private Transform target;

    void FixedUpdate()
    {
        if (target != null)
        {
            Debug.Log("타겟은 설정됨");
            Vector3 targetPos = new Vector3(target.position.x + offsetX, target.position.y + offsetY, target.position.z + offsetZ);
            transform.position = Vector3.Lerp(transform.position, targetPos, Time.deltaTime * cameraSpeed);
        }
    }

    public void SetTargetByPlayerId(int playerId)
    {
        if (playerId >= 0 && playerId < targets.Length)
        {
            Debug.Log("SetTargetByPlayerId");
            target = targets[playerId];
        }
        else
        {
            Debug.LogWarning("Unknown playerId: " + playerId);
        }
    }
}