using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardHandler
{
    public static int TotalOpenedCard = 6; //Toplam açılmış kart
    public static int OpenedCardCount = 0; //Açık kart sayısı
    public static int OpenedCardID; //Açık kart ID
    public static bool IsCompleted = false;
    public static GameObject OpenedObject;
}
