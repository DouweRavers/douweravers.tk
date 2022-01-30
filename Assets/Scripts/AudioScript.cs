using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    public AudioSource start, run, end;
    
    public void StartPCNoise() {
        StartCoroutine(PCNoiseCoroutine());
    }
    
    public void EndPCNoise()
    {
        if (!run.isPlaying) return;
        run.Stop();
        end.Play();
    }

    IEnumerator PCNoiseCoroutine() {
        start.Play();
        yield return new WaitForSeconds(start.clip.length);
        run.Play();
    }
}
