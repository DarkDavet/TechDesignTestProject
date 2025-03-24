using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectClickHandler : MonoBehaviour
{
    [SerializeField] private GameObject particlePrefab;
    [SerializeField] private bool isLoop;
    [SerializeField] private string animationName;
    [SerializeField] private string audioName;
    private bool isVFXPlay;
    private Animator animator;

    private GameObject particleInstance;
    private ParticleSystem particle;

    private void Start()
    {
        animator = GetComponent<Animator>();

        if (particlePrefab == null)
        {
            Debug.LogError("Particle prefab is not assigned!");
        }

        isVFXPlay = false;
    }

    private void OnMouseDown()
    {
        AudioManager.Instance.Play(audioName);
        PlayAnimation();
        PlayVFX();
    }

    private void PlayAnimation()
    {
        if (animator != null)
        {
            animator.Play(animationName, -1, 0f);
        }
    }

    private void PlayVFX()
    {
        if (particlePrefab != null && isVFXPlay == false)
        {
            particleInstance = Instantiate(particlePrefab, transform.position, Quaternion.identity);
            particle = particleInstance.GetComponent<ParticleSystem>();
            if (particle != null && isLoop == false)
            {
                particle.Play();

                Destroy(particleInstance, particle.main.duration + particle.main.startLifetime.constantMax);
            }
            else if (particlePrefab != null && isLoop == true)
            {
                isVFXPlay = true;
                particle.Play();
                AudioManager.Instance.Play("campfire_ambient");
            }
        }

        else if (isVFXPlay)
        {
            Destroy(particleInstance);
            particle = null;
            isVFXPlay = false;
            AudioManager.Instance.Stop("campfire_ambient");
        }
    }

    private void OnDestroy()
    {
        AudioManager.Instance.Stop("campfire_ambient");
    }
}
