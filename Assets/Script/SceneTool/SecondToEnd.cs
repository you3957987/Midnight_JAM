using UnityEngine;
using UnityEngine.SceneManagement;

public class SecondToEnd : MonoBehaviour
{
    private void Start()
    {
        // 59√  »ƒø° æ¿ ¿Ãµø
        Invoke("LoadEndScene", 34f);
    }

    private void LoadEndScene()
    {
        // "1end" æ¿ ∑ŒµÂ
        SceneManager.LoadScene("2end");
    }
}
