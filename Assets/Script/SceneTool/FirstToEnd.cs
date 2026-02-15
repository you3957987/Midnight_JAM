using UnityEngine;
using UnityEngine.SceneManagement;

public class FirstToEnd : MonoBehaviour
{
    private void Start()
    {
        // 59√  »ƒø° æ¿ ¿Ãµø
        Invoke("LoadEndScene", 59f);
    }

    private void LoadEndScene()
    {
        // "1end" æ¿ ∑ŒµÂ
        SceneManager.LoadScene("1end");
    }
}
