using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CamereMove : MonoBehaviour
{
    public float offsetX = 0.0f;            // ī�޶��� x��ǥ
    public float offsetY = 0.0f;           // ī�޶��� y��ǥ
    public float offsetZ = -10.0f;          // ī�޶��� z��ǥ

    public float CameraSpeed = 10.0f;       // ī�޶��� �ӵ�
    Vector3 TargetPos;                      // Ÿ���� ��ġ

    // Update is called once per frame
    void FixedUpdate()
    {
        Transform Target;    
        Target = GameManager.I.target;
        // Ÿ���� x, y, z ��ǥ�� ī�޶��� ��ǥ�� ���Ͽ� ī�޶��� ��ġ�� ����
        TargetPos = new Vector3(
            Target.transform.position.x + offsetX,
            Target.transform.position.y + offsetY,
            Target.transform.position.z + offsetZ
            );

        // ī�޶��� �������� �ε巴�� �ϴ� �Լ�(Lerp)
        transform.position = Vector3.Lerp(transform.position, TargetPos, Time.deltaTime * CameraSpeed);
    }
}