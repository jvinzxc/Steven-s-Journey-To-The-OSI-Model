using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorSlider : MonoBehaviour
{
    public Color startColor;
    public Color endColor;
    public float transitionSpeed = 1f;

    private Slider slider;
    private Image handleImage;
    private Image backgroundImage;

    private void Start()
    {
        slider = GetComponent<Slider>();
        handleImage = slider.fillRect.GetComponentInChildren<Image>();
        backgroundImage = slider.fillRect.parent.GetComponentInChildren<Image>();
    }

    private void Update()
    {
        float normalizedValue = slider.normalizedValue;
        Color lerpedColor = Color.Lerp(startColor, endColor, normalizedValue);

        // Set handle and background color
        handleImage.color = lerpedColor;
        backgroundImage.color = lerpedColor;
    }
}
