using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine.Unity;

public class FairyAnimController : MonoBehaviour
{
    [SerializeField] private SkeletonAnimation skeletonAnimation;

    private void Start()
    {
        PlayAnimation(1, "eyeblink-long", true);
    }

    private void OnMouseDown()
    {
        PlayAnimation(0, "swing", false);
        AddToQueue(0, "wings-and-feet", true, 0f);
    }

    private void PlayAnimation(int trackIndex, string animationName, bool isLoop)
    {
        if (skeletonAnimation != null)
        {
            skeletonAnimation.AnimationState.SetAnimation(trackIndex, animationName, isLoop);
        }
    }

    private void AddToQueue(int trackIndex, string animationName, bool loop, float delay)
    {
        if (skeletonAnimation != null)
        {
            skeletonAnimation.AnimationState.AddAnimation(trackIndex, animationName, loop, delay);
        }
    }
}
