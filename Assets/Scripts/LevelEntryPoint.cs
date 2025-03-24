using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEntryPoint : MonoBehaviour
{
    [SerializeField] private AudioManager audioManager;
    [SerializeField] private string audioName;
    private void Start()
    {
        audioManager.Play(audioName);
    }
}
