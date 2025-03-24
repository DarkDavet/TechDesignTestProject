using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonAnimController : MonoBehaviour
{
    [SerializeField] private AudioManager audioManager;
    //[SerializeField] private string animationName;
    [SerializeField] private string audioName;

    public event Action OnSkeletonAttack;

    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();

    }

    private void OnMouseDown()
    {
        audioManager.Play(audioName);
        PlayAnimation();
    }

    public void OnAnimationCompleted()
    {
        OnSkeletonAttack?.Invoke();
    }
    private void PlayAnimation()
    {
        if (animator != null)
        {
            animator.SetTrigger("attack");
        }
    }
}
