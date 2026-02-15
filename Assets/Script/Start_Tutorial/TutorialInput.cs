using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TutorialInput : MonoBehaviour
{
    [SerializeField] private Button tutorialEndButton;

    [SerializeField] private Image image1;
    [SerializeField] private Image image2;
    [SerializeField] private Image image3;
    [SerializeField] private Image image4;

    private int currentImageIndex = 0;

    private void Awake()
    {
        tutorialEndButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("enemy");
        });
    }
    private void Start()
    {
        tutorialEndButton.enabled = false;
        image1.enabled = false;
        image2.enabled = false;
        image3.enabled = false;
        image4.enabled = false;
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShowNextImage();
        }
    }

    private void ShowNextImage()
    {
        // 현재 이미지 인덱스에 따라 이미지를 활성화
        if (currentImageIndex == 0)
        {
            image1.enabled = true;
        }
        else if (currentImageIndex == 1)
        {
            image2.enabled = true;
        }
        else if (currentImageIndex == 2)
        {
            image3.enabled = true;
        }
        else if (currentImageIndex == 3)
        {
            image4.enabled = true;
            tutorialEndButton.enabled = true;
        }

        currentImageIndex++;

        if (currentImageIndex > 3)
        {
            currentImageIndex = 3;
        }
    }
}
