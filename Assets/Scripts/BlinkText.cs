using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BlinkText : MonoBehaviour
{
    public TextMeshProUGUI textToBlink;
    public float blinkSpeed = 1f;

    private void Start()
    {
        StartCoroutine(Blink());
    }

    IEnumerator Blink()
    {
        while (true)
        {
            // Fade out
            for (float alpha = 1f; alpha >= 0f; alpha -= Time.deltaTime * blinkSpeed)
            {
                SetAlpha(alpha);
                yield return null;
            }

            // Fade in
            for (float alpha = 0f; alpha <= 1f; alpha += Time.deltaTime * blinkSpeed)
            {
                SetAlpha(alpha);
                yield return null;
            }
        }
    }

    void SetAlpha(float alpha)
    {
        Color color = textToBlink.color;
        color.a = alpha;
        textToBlink.color = color;
    }
}
