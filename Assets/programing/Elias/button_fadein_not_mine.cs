using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class button_fadein_not_mine : MonoBehaviour
{
    public Image buttonImage;
    public float duration = 2f;

    void Start()
    {
        StartCoroutine(FadeIn());
    }

    IEnumerator FadeIn()
    {
        float elapsedTime = 0;
        Color color = buttonImage.color;
        while (elapsedTime < duration)
        {
            color.a = Mathf.Lerp(0, 1, elapsedTime / duration);
            buttonImage.color = color;
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        color.a = 1;
        buttonImage.color = color;
    }

}

