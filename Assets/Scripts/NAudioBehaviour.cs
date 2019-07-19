using UnityEngine;
using NAudio.Wave;

public class NAudioBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AudioFileReader reader = new AudioFileReader("Assets/Audio/Sample.wav");
        WaveOut waveOut = new WaveOut();
        waveOut.Init(reader);
        waveOut.Play();

        // 音楽の再生
        while(waveOut.PlaybackState == PlaybackState.Playing);
    }
}
