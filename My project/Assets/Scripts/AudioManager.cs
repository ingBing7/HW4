using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource jumpSound;

    public Locator locator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        locator.Player.BirdJumped += PlayJumpAudio;
    }

    public void PlayJumpAudio()
    {
        jumpSound.Play();
    }


}
