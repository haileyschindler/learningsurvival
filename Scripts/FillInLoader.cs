using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FillInLoader : MonoBehaviour
{
    public void ToFillIn()
    {
        SceneManager.LoadScene("Fill In");
    }

    public void PlayScene()
    {
        SceneManager.LoadScene("MainGame");
    }
}

