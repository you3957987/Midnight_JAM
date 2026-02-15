using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class StartMenuButton : MonoBehaviour
{
    [SerializeField] private Button startButton;
    [SerializeField] private Button quitButton;
    public AudioSource audio;

    private void Awake()
    {
        startButton.onClick.AddListener(() =>
        {
            audio.Play();
            Invoke("LoadTutorialScene", 2.2f); // 1ÃÊ ÈÄ ¾À ·Îµå
        });

        quitButton.onClick.AddListener(() =>
        {
            Debug.Log("Quit");
            Application.Quit();
        });
    }

    private void LoadTutorialScene()
    {
        SceneManager.LoadScene("TutorialScene");
    }
}
