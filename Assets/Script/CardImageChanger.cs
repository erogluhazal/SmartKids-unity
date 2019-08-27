using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CardImageChanger : MonoBehaviour
{
    Image image;
    Button button;
    Button button2;
    Image image2;

    public GameObject Card;
    public Sprite cardImage;
    public Sprite defaultImage;
    public int CardID;

    bool IsOpened = false;
    
    private void Start()
    {
        image = GetComponent<Image>();
        button = GetComponent<Button>();
        button2 = Card.GetComponent<Button>();
        image2 = Card.GetComponent<Image>();
    }

    public void CardClick()
    {
        if(IsOpened) //Açık karta tıklandığında
        {
            image.sprite = defaultImage;
            IsOpened = false;
            CardHandler.OpenedCardCount--;
            CardHandler.OpenedCardID = 0;
        }
        else
        {
            if (CardHandler.OpenedCardCount == 2)
                return;

            image.sprite = cardImage;
            IsOpened = true;
            CardHandler.OpenedCardCount++;

            if (CardHandler.OpenedCardID == CardID) //eşleştirme
            {
                button.enabled = false;
                button2.enabled = false;
                CardHandler.OpenedCardCount = 0;
                CardHandler.OpenedCardID = 0;
                CardHandler.TotalOpenedCard--;
                //CardHandler.OpenedObject = null;
            }

            //if(CardHandler.OpenedCardID == 1)
            //{
            //    StartCoroutine(Wait());

            //    CardHandler.OpenedObject.GetComponent<Image>().sprite = defaultImage;
            //    image.sprite = defaultImage;

            //    CardHandler.OpenedCardCount = 0;
            //    CardHandler.OpenedCardID = 0;
            //    CardHandler.OpenedObject = null;
            //}

            //CardHandler.OpenedObject = gameObject;
            CardHandler.OpenedCardID = CardID;
        }

        if(CardHandler.TotalOpenedCard == 0) //Bütün kartlar açıldığında
        {
            if (CardHandler.IsCompleted == true)//son level
            {
                Debug.Log("Game Completed");
                StartCoroutine(WaitHome());
            }
            else
            {
                Debug.Log("Level Completed");
                StartCoroutine(Wait());
            }
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Kart2");
        CardHandler.OpenedCardCount = 0;
        CardHandler.OpenedCardID = 0;
        CardHandler.TotalOpenedCard = 9;
        CardHandler.IsCompleted = true;
    }
    IEnumerator WaitHome()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Home");
    }
}
