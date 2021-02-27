using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;

public class LiftManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator LeftDoorAnimator;
    public Animator RightDoorAnimator;
    public Interactable pressableButton;
    public PressableButtonHoloLens2 a;
    void Start()
    {
        pressableButton.OnClick.AddListener(() => {
            StartAnimation();
        });

        pressableButton.GetComponent<PressableButtonHoloLens2>().ButtonReleased.AddListener(() => {
            StartAnimation();
        });
    }

    void StartAnimation()
    {
        // Later add some waiting time
        LeftDoorAnimator.Play("leftdoor");
        RightDoorAnimator.Play("rightdoor");

        // Turn on all audio source
        var audioSources = GameObject.FindObjectsOfType<AudioSource>();
        var resourcesAudioSources = Resources.FindObjectsOfTypeAll<AudioSource>();
        foreach(var audioSource in audioSources)
        {
            audioSource.enabled = true;
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }

        foreach(var audioSource in resourcesAudioSources)
        {
            audioSource.enabled = true;
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
    }
}
