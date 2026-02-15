using UnityEngine;

public class Handle : MonoBehaviour
{

    public CircleMove circle;


    // Update is called once per frame
    void Update()
    {
        // 회전 각도 계산 (1.5일 때 180도, -1.5일 때 -180도)
        float rotationAngle = circle.move * 120f; // 1.5 * 120 = 180도, -1.5 * 120 = -180도

        // 중심을 기준으로 회전
        transform.rotation = Quaternion.Euler(0, 0, rotationAngle);
    }
}
