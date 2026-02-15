using UnityEngine;

public class ClickSound : MonoBehaviour
{

    public AudioSource first;
    public AudioSource second;
    public AudioSource third;
    public AudioSource fourth;
    public AudioSource fifth;

   

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            first.Play();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            second.Play();
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            third.Play();
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            fourth.Play();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            fifth.Play();
        }

    }
}
