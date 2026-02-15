using UnityEngine;

public class CircleMove : MonoBehaviour
{
    public float radius; // 원의 반지름 == 2.8
    public Vector3 center = new Vector3(0, 0, 0); // 원의 중심
    public float move = 0f; // 핸들의 회전 상태를 나타내는 변수
    public float maxMove = 1.5f; // 최대 회전 값 (한 바퀴 반)
    public float limitedMove; // 제한된 회전 값

    private void Start()
    {
        Application.targetFrameRate = 60; // 프레임 속도를 60으로 고정
    }

    void Update()
    {
        // 마우스 위치를 화면 좌표에서 월드 좌표로 변환
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0; // 2D 게임이므로 z값을 0으로 설정

        // 원의 중심에서 마우스 위치까지의 벡터 계산
        Vector3 direction = mousePosition - center;
        direction.Normalize(); // 방향 벡터를 정규화

        // 원의 중심에서 반지름 거리만큼 떨어진 위치 계산
        Vector3 targetPosition = center + direction * radius;

        // 핸들의 회전 상태 업데이트
        float angle = Vector3.SignedAngle(Vector3.up, direction, Vector3.forward);
        move = Mathf.Clamp(angle / 180f * maxMove, -maxMove, maxMove);

        // 오브젝트 위치 업데이트
        if (Mathf.Abs(move) <= limitedMove)
        {
            transform.position = targetPosition;
        }
        else
        {
            // move 값이 제한된 범위를 벗어나면 이동하지 않음
            move = Mathf.Clamp(move, -limitedMove, limitedMove);
        }
    }
}
