using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("Audio Sources")]
    [SerializeField] AudioSource musicSource; //Audio source for music.
    [SerializeField] AudioSource vfxSource; //Audio source for sound effects.

    [Header("Audio Clips")]
    public AudioClip backgroundMusic; //Music clip to play as background.
    public AudioClip jumpSound; //Sound effect for jump.

    private void Start()
    {
        musicSource.clip = backgroundMusic; //Set the music clip.
        musicSource.Play(); //Play the background music.
    }

    public void PlaySoundEffect(AudioClip clip) //Function to play a sound effect.
    {
        vfxSource.PlayOneShot(clip); //Play the clip one time.
    }
}