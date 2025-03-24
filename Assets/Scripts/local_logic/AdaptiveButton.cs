using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AdaptiveButton : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI buttonText;
    [SerializeField] private float padding;
    [SerializeField] private float height;

    private RectTransform buttonRect;

    private void Awake()
    {
        buttonRect = GetComponent<RectTransform>();
    }
    private void Start()
    {
        AdjustButtonSize();
    }

    private void AdjustButtonSize()
    {
        if (buttonText == null || buttonRect == null) return;

        Vector2 textSize = buttonText.GetPreferredValues();
        buttonRect.sizeDelta = new Vector2(textSize.x + padding, height);
    }
}
