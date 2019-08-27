using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuHandler : MonoBehaviour
{
    public void OpenCardScene()
    {
        SceneManager.LoadScene("Kart"); //sahne yükleme
    }

    public void OpenColorScene()
    {
        SceneManager.LoadScene("Renk");
    }

    public void OpenMathScene()
    {
        SceneManager.LoadScene("Sayi");
    }

    public void GotoHomeScene()
    {
        SceneManager.LoadScene("Home");
    }
}
