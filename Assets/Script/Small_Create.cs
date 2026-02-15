using UnityEngine;
using System.Collections;

public class Small_NodeManager : MonoBehaviour
{
    public GameObject smallerNodePrefab; // 스몰 노드 프리팹
    public float[] spawnTimes; // 생성 주기 배열
    public Vector3 spawnPosition = Vector3.zero; // 생성 위치, 기본값은 (0, 0, 0)

    void Start()
    {
        // 코루틴 시작
        StartCoroutine(SpawnNodes());
    }

    IEnumerator SpawnNodes()
    {
        foreach (float spawnTime in spawnTimes)
        {
            yield return new WaitForSeconds(spawnTime);
            SpawnSmallerNode();
        }
    }

    void SpawnSmallerNode()
    {
        // 지정된 위치에 스몰 노드 생성
        Instantiate(smallerNodePrefab, spawnPosition, Quaternion.identity);
    }
}
