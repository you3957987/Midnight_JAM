using UnityEngine;

public class Title_sound : MonoBehaviour
{
    public AudioSource sound;

    public AudioSource button;
    void Start()
    {
        sound.Play();
    }

    public void buttonplay()
    {
        button.Play();
    }

}
