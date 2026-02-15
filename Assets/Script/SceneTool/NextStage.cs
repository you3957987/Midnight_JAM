using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextStage : MonoBehaviour
{
    public Sprite[] sprites;  // Sprite 배열
    public Canvas canvas;     // Canvas 객체

    private SpriteRenderer spriteRenderer;  // SpriteRenderer 컴포넌트 참조

    int next = 0;

    private void Start()
    {
        // SpriteRenderer 컴포넌트를 가져옵니다.
        spriteRenderer = GetComponent<SpriteRenderer>();

        if (spriteRenderer == null)
        {
            Debug.LogError("SpriteRenderer 컴포넌트가 이 오브젝트에 없습니다!");
            return;
        }

        // 1초 후에 스프라이트를 변경
        Invoke("ChangeSprite", 3f);
    }

    private void Update()
    {
        if (next == 1)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene("Jam");
            }
        }
    }

    private void ChangeSprite()
    {
        // sprites[1]로 스프라이트 변경
        if (sprites != null && sprites.Length > 1)
        {
            spriteRenderer.sprite = sprites[1];
            canvas.gameObject.SetActive(true);
            next = 1;
        }
        else
        {
            Debug.LogError("sprites 배열이 비어있거나 sprites[1]이 존재하지 않습니다!");
        }
    }
}
