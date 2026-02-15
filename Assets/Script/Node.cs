using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.InputSystem.Processors;

public class Node : MonoBehaviour
{
    public static event System.Action OnNodeDestroyed;  //이벤트 정의

    [SerializeField] private float fallSpeed = 1f; //떨어지는 속도
    public float destroyHeight = -6f;
    public float top;
    public float bottom;

    public AudioSource nodeaudio;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        nodeaudio = GetComponent<AudioSource>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        //아래로 떨어짐
        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime);

        // 화면 아래로 사라지면 노드 제거
        if (transform.position.y < destroyHeight)
        {
            Destroy(gameObject);
        }

        if(transform.position.y >= bottom && transform.position.y <=  top)
        {
            if( Input.GetKeyDown(KeyCode.Q))
            {
                //nodeaudio.Play();
                MakeTransparent();
                //Debug.Log("a");
                OnNodeDestroyed?.Invoke();  //노드 파괴될 때 이벤트 호출
            }

            if(Mathf.Abs(transform.position.y - (bottom + top) / 2) < 0.1f && GameOverManager.devMode)
            {
                nodeaudio.Play();
                MakeTransparent();
                OnNodeDestroyed?.Invoke();
            }
           
        }

    }
    void MakeTransparent()
    {
        Color color = spriteRenderer.color;
        color.a = 0f; // 알파 값을 0으로 설정하여 완전히 투명하게 만듦
        spriteRenderer.color = color;
    }

}
