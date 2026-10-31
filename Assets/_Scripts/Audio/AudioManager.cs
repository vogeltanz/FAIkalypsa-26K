using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(AudioSource))]
public class AudioManager : MonoBehaviour
{
    [SerializeField]
    AudioClip[] audioIdleClips;

    [SerializeField]
    AudioClip[] audioRunClips;

    Animator animator;

    AudioSource audioSource;

    void Awake()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();

        animator.GetBehaviour<AudioIdleBehavior>().AudioClips = audioIdleClips;
        animator.GetBehaviour<AudioIdleBehavior>().AudioSource = audioSource;

        animator.GetBehaviour<AudioRunBehavior>().AudioClips = audioRunClips;
        animator.GetBehaviour<AudioRunBehavior>().AudioSource = audioSource;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
