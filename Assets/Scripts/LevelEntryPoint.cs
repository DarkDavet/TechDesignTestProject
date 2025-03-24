using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEntryPoint : MonoBehaviour
{
    [SerializeField] private string audioName;
    void Start()
    {
        AudioManager.Instance.Play(audioName);
    }
    private void OnDestroy()
    {
        AudioManager.Instance.Stop(audioName);
    }
}
