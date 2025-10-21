using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("Audio Sources")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource vfxSource;

    [Header("Audio Clips")]
    public AudioClip backgroundMusic;
    public AudioClip jumpSound;

    private void Start()
    {
        musicSource.clip = backgroundMusic;
        musicSource.Play();
    }

    public void PlaySoundEffect (AudioClip clip)
    {
        vfxSource.PlayOneShot(clip);
    }



}
