using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameExit : MonoBehaviour
{
    [SerializeField] public Button playButton;

    private void Start()
    {
        playButton.onClick.AddListener(OnButtonClick);
    }

    private void OnButtonClick()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; 
#else
        Application.Quit(); 
#endif
    }
}
