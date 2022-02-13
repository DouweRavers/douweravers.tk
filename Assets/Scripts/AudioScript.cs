using System.Collections;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    public AudioSource start, run, end;
    
    public void StartSound() {
        StartCoroutine(PCNoiseCoroutine());
    }
    
    public void EndSound()
    {
        if (run != null) {
            if (!run.isPlaying) return;
            run.Stop();
        }
        if (end != null) end.Play();
    }

    IEnumerator PCNoiseCoroutine() {
        if (start != null) start.Play();
        yield return new WaitForSeconds(start.clip.length);
        if (run != null) run.Play();
    }
}
