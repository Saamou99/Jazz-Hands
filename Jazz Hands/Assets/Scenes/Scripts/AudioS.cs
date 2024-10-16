using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioS : MonoBehaviour
{
    public AudioSource audioSource; // Reference to the AudioSource component
    public float targetVolume = 0.9f; // Target volume (normal volume)
    public float duration = 10f;    // Duration over which to increase the volume and pitch
    public float initialVolume = 0.1f; // Starting low volume
    public float initialPitch = 0.9f; // Starting low pitch
    public float targetPitch = 1.0f; // Target pitch (normal pitch)

    void Start()
    {
        if (audioSource != null)
        {
            // Set the audio source volume and pitch to their initial low values
            audioSource.volume = initialVolume;
            audioSource.pitch = initialPitch;
            audioSource.Play(); // Play the audio

            // Start the coroutine to fade in the volume and pitch
            StartCoroutine(FadeInAudio());
        }
    }

    IEnumerator FadeInAudio()
    {
        float startVolume = audioSource.volume;
        float startPitch = audioSource.pitch;
        float timeElapsed = 0f;

        while (timeElapsed < duration)
        {
            // Gradually increase the volume and pitch over time
            audioSource.volume = Mathf.Lerp(startVolume, targetVolume, timeElapsed / duration);
            audioSource.pitch = Mathf.Lerp(startPitch, targetPitch, timeElapsed / duration);

            // Wait for the next frame and accumulate the time
            timeElapsed += Time.deltaTime;
            yield return null;
        }

        // Ensure the volume and pitch reach their target values at the end
        audioSource.volume = targetVolume;
        audioSource.pitch = targetPitch;
    }
}