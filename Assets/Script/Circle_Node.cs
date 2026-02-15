using UnityEngine;

public class NodeMover : MonoBehaviour
{
    public float moveSpeed = 2f; // 이동 속도

    void Update()
    {
        // 중심으로 이동
        Vector3 targetPosition = Vector3.zero;
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

        // 중심에 도달하면 삭제
        if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // 다른 콜라이더와 충돌 시 삭제
        Destroy(gameObject);
    }
}
