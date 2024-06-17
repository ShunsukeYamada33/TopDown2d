using UnityEngine;

public class StudyAudio : MonoBehaviour
{
    // ����炷���@

    // AudioSource
    // ����炷�X�s�[�J�[
    private AudioSource _audioSource;

    // AudioClip
    // ��
    // �g�p�\�Ȋg���q .wav .mp3 .aif .ogg
    [SerializeField] private AudioClip audioClip;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void Start()
    {
        // BGM �̐ݒ�
        _audioSource.clip = audioClip;

        // BGM
        _audioSource.Play();
        _audioSource.Pause();
        _audioSource.Stop();

        // SE
        _audioSource.PlayOneShot(audioClip);

        // �~���[�g
        _audioSource.mute = true;
    }
}
