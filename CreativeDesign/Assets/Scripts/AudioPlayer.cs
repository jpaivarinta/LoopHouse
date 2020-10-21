using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{

    AudioSource audiosource;
    bool playAudio = true;
    

    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
        StartCoroutine(SoundOutput());
    }

    IEnumerator SoundOutput()
    {
        while (playAudio)
        {
            audiosource.Play();
            yield return new WaitForSeconds(15);
        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
