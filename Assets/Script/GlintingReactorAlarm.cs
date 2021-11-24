using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlintingReactorAlarm : MonoBehaviour
{
    private CanvasGroup moonCanvasGroup;
    private float flashSpeed = 1.4f;//光晕闪动速度
    private bool isOn = true;
    private float maxAlpha = 1.0f;//显示的最高alpha值
    private float minAlpha = 0.3f;//显示的最低alpha值
    private Image ManImage;

    void Start()
    {
        moonCanvasGroup = GetComponent<CanvasGroup>();
        ManImage = GameObject.Find("Image").GetComponent<Image>();

    }
    void Update()
    {
        if (ValueStore.WaterLevelReactor > 30.0)
        {
            ManImage.color = Color.red;
            if (moonCanvasGroup.alpha < maxAlpha && isOn)
            {
                moonCanvasGroup.alpha += flashSpeed * Time.deltaTime;
            }
            else
            {
                isOn = false;
                moonCanvasGroup.alpha -= flashSpeed * Time.deltaTime;
                if (moonCanvasGroup.alpha < minAlpha)
                {
                    isOn = true;
                }
            }
        }
        if (ValueStore.WaterLevelReactor <= 30.0)
        {
            ManImage.color = Color.white;
            moonCanvasGroup.alpha = 1.0f;
        }
    }
}
