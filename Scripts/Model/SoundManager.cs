using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;
    private AudioSource _audioSource;
    [SerializeField] private AudioClip attackAudioClip;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        _audioSource = GetComponent<AudioSource>();
    }

    public void Play()
    {
        _audioSource.Play();
    }

    public void Stop()
    {
        _audioSource.Stop();
    }

    public void Pause()
    {
        _audioSource.Pause();
    }

    public void Attack()
    {
        // attackAudioClip ÇSEÇ∆ÇµÇƒÇPìxçƒê∂
        if(attackAudioClip != null)
        {
            _audioSource.PlayOneShot(attackAudioClip);
        }
    }
}
