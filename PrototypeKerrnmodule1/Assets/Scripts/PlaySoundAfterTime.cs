using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundAfterTime: MonoBehaviour
{
    private AudioSource audio;
    public int AfterHowLong;
    void Start()
    {
        //delay the sound
        StartCoroutine(PlaySound());
        audio = GetComponent<AudioSource>();
    }

    IEnumerator PlaySound()
    {
        yield return new WaitForSeconds(AfterHowLong);
        //play the sound
        audio.Play();
    }

}
