using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MathHandler : MonoBehaviour
{
    public int answer;
    public InputField text;
    public Sprite successImage; //Yeşil
    public Sprite errorImage; //Kırmızı
    public Image image; //beyaz
    public void checkAnswer()
    {
        if (text.text == answer.ToString()) //cevaplar doğruysa
        {
            image.sprite = successImage; //unity içinde resimler sprite'a çevrilip kullanılıyor.
        }
        else //cevaplar yanlışsa
        {
            image.sprite = errorImage;
        }
    }
}
