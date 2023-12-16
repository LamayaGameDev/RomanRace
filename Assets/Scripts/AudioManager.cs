using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public AudioSource source;
    public AudioClip successClip;
    public AudioClip failClip;
    public static AudioManager instance;
    // Start is called before the first frame update
    void Start()
    {
        source.GetComponent<AudioSource>();
        instance = this;
    }

    public void PlaySuccess()
    {
        source.PlayOneShot(successClip);
    }
    public void PlayFail()
    {
        source.PlayOneShot(failClip);
    }

}
