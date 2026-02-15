using UnityEngine;
using UnityEngine.SceneManagement;

public class ThirdToEnd : MonoBehaviour
{
    private void Start()
    {
        // 59√  »ƒø° æ¿ ¿Ãµø
        Invoke("LoadEndScene", 51f);
    }

    private void LoadEndScene()
    {
        // "1end" æ¿ ∑ŒµÂ
        SceneManager.LoadScene("ending");
    }
}
