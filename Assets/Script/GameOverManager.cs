using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameOverManager : MonoBehaviour
{
    [SerializeField] private Image image;  // 알파 값을 확인할 이미지
    [SerializeField] private GameObject back;
    private bool isTransitioning = false;  // 씬 전환 중복 방지용 플래그
    [SerializeField] private float backgroundThreshold = 8f;

    public static bool devMode = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            devMode = !devMode;
            Debug.Log("devMode");
        }

        // 이미지의 알파 값 가져오기
        float currentAlpha = image.color.a;

        // 알파 값이 1 이상이고 아직 전환 중이 아닌 경우
        if (currentAlpha >= 1f && !isTransitioning || Mathf.Abs(back.transform.position.x) > backgroundThreshold)
        {
            isTransitioning = true;  // 전환 시작 플래그 설정
            StartCoroutine(WaitAndLoadScene(3f));  // 3초 후 씬 전환
        }
    }

    private IEnumerator WaitAndLoadScene(float waitTime)
    {
        Debug.Log("Waiting for " + waitTime + " seconds...");
        yield return new WaitForSeconds(waitTime);  // 3초 대기

        SceneManager.LoadScene("GameOverScene");  // 씬 로드
    }
}