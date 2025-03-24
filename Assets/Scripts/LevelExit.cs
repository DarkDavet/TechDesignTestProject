using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelExit : MonoBehaviour
{
    [SerializeField] private SceneLoader sceneLoader;
    [SerializeField] private AudioManager audioManager;
    [SerializeField] private List<string> loop_audio_names;
    [SerializeField] public Button playButton;

    private void Start()
    {
        playButton.onClick.AddListener(OnButtonClick);
    }

    private void OnButtonClick()
    {
        StopLoopAudio();
        sceneLoader.LoadMainMenuScene();
    }
    private void StopLoopAudio()
    {
        foreach (string audio_name  in loop_audio_names)
        {
            audioManager.Stop(audio_name);
        }
    }
}
