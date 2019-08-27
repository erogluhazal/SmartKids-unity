using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorHandler : MonoBehaviour
{
    Image image;

    public Text inputText;
    public Sprite succesImage;
    public Sprite errorImage;
    public int Number;
    void Start()
    {
        image = GetComponent<Image>();
    }

    public void CheckName() //Renk oyunu kontrolü
    {
        Debug.Log(inputText.text);
        if(inputText.text == Number.ToString())
        {
            image.sprite = succesImage;
        }
        else
        {
            image.sprite = errorImage;
        }
    }
}
