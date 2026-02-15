using UnityEngine;
using UnityEngine.UI;

public class FadeImage : MonoBehaviour
{
    [SerializeField] private Image image;          // 알파 값을 제어할 이미지
    [SerializeField] private float fadeSpeed = 0.05f;  // 시간에 따라 어두워지는 속도
    [SerializeField] private float brightenAmount = 0.2f; // 노드 파괴 시 밝아지는 양

    private float alphaValue = 0f;                 // 알파 값 초기화 (완전 투명)

    //public static FadeImage Instance { get; private set; }

    private void Awake()
    {
        //Instance = this;
    }

    private void Start()
    {
        Node.OnNodeDestroyed += Node_OnNodeDestroyed;
        Node2.OnNodeDestroyed += Node_OnNodeDestroyed; 
        Node3.OnNodeDestroyed += Node_OnNodeDestroyed; 
        Node4.OnNodeDestroyed += Node_OnNodeDestroyed;
        SmallerNode.OnNodeDestroyed += Node_OnNodeDestroyed;
    }

    public void OnDestroy()
    {
        Node.OnNodeDestroyed -= Node_OnNodeDestroyed;
        Node2.OnNodeDestroyed -= Node_OnNodeDestroyed;
        Node3.OnNodeDestroyed -= Node_OnNodeDestroyed;
        Node4.OnNodeDestroyed -= Node_OnNodeDestroyed;
        SmallerNode.OnNodeDestroyed -= Node_OnNodeDestroyed;

    }

    private void Node_OnNodeDestroyed()
    {
        // 노드 파괴 시 밝아짐 (알파 감소)
        alphaValue -= brightenAmount;
        alphaValue = Mathf.Clamp(alphaValue, 0f, 1f); // 알파 값 제한
        Debug.Log($"Node destroyed. Brightened alpha: {alphaValue}");
    }

    private void Update()
    {
        // 시간이 지나면서 어두워짐 (알파 증가)
        alphaValue += fadeSpeed * Time.deltaTime;
        alphaValue = Mathf.Clamp(alphaValue, 0f, 1f); // 알파 값 제한

        // 이미지 색상 업데이트
        Color currentColor = image.color;
        currentColor.a = alphaValue;
        image.color = currentColor;

        // 디버깅
        //Debug.Log($"Alpha value (darkening): {alphaValue}");
    }
}