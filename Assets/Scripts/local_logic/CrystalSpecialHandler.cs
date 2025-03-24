using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalSpecialHandler : MonoBehaviour
{
    [SerializeField] private AudioManager audioManager;
    [SerializeField] private ObjectClickHandler objectHandler;
    [SerializeField] private SkeletonAnimController skeletonAnimController;
    [SerializeField] private GameObject heartPrefab;

    private void Start()
    {
        skeletonAnimController.OnSkeletonAttack += ForceEffect;
    }

    private void ForceEffect()
    {
        objectHandler.PlayVFX();
        objectHandler.PlayAnimation();
        audioManager.Play("poison");
        Instantiate(heartPrefab, transform.position, transform.rotation);
    }
}
