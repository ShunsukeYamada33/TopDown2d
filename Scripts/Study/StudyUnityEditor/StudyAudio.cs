using UnityEngine;

public class StudyAudio : MonoBehaviour
{
    // 音を鳴らす方法

    // AudioSource
    // 音を鳴らすスピーカー
    private AudioSource _audioSource;

    // AudioClip
    // 音
    // 使用可能な拡張子 .wav .mp3 .aif .ogg
    [SerializeField] private AudioClip audioClip;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void Start()
    {
        // BGM の設定
        _audioSource.clip = audioClip;

        // BGM
        _audioSource.Play();
        _audioSource.Pause();
        _audioSource.Stop();

        // SE
        _audioSource.PlayOneShot(audioClip);

        // ミュート
        _audioSource.mute = true;
    }
}
