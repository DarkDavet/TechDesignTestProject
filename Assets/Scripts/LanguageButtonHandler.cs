using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LanguageButtonHandler : MonoBehaviour
{
    [Range(0f, 1f), SerializeField] private int id;
    [SerializeField] public Button playButton;

    private void Start()
    {
        playButton.onClick.AddListener(OnButtonClick);
    }

    private void OnButtonClick()
    {
        LocaleSelector.Instance.ChangeLocale(id);
    }
}
