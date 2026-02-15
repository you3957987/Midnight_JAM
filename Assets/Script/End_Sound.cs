using UnityEngine;

public class End_Sound : MonoBehaviour
{
    public AudioSource audio;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audio.Play();
    }
}
