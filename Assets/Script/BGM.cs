using UnityEngine;
using System.Collections;

public class BGM : MonoBehaviour
{
    public AudioSource bgmaudio;

    private void Start()
    {
        bgmaudio.Play();
    }
 
}
