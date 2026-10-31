using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class AudioBehavior : StateMachineBehaviour
{
    public AudioClip[] AudioClips { get; set; }
    public AudioSource AudioSource { get; set; }

    protected void PlayRandomAudioClip()
    {
        if (AudioClips != null && AudioClips.Length > 0 && AudioSource != null)
        {
            int randomIndex = UnityEngine.Random.Range(0, AudioClips.Length);
            AudioSource.clip = AudioClips[randomIndex];
            AudioSource.Play();
        }
    }

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    //override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    //override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}

