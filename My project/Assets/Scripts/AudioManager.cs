using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource jumpSound;

    public AudioSource pointsGainedAudio;

    void Start()
    {
        Locator.Instance.Player.BirdJumped += PlayJumpAudio;
        Locator.Instance.Player.BirdScored += PlayPassedPipeAudio;
    }

    public void PlayJumpAudio()
    {
        jumpSound.Play();
    }

    public void PlayPassedPipeAudio()
    {
        pointsGainedAudio.Play();
    }
}
