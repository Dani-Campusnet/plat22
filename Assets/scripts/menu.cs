using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    // Start is called before the first frame update
    public void ExitGame()
    {
        Application.Quit();
    }

    public void LoadScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
