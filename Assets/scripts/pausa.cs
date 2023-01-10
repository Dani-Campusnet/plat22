using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pausa : MonoBehaviour
{
    public GameObject botonpausa;
    public GameObject menupausa;
    private bool pausado = false;
   void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
            if (pausado)
            {
                Reanudar();
            }
            else
            {
                Pausa();
            }
        }   
    }
    public void Pausa(){
        pausado = true;
        Time.timeScale = 0f;
        botonpausa.SetActive(false);
        menupausa.SetActive(true);
    }
    public void Reanudar() { 
        pausado = false;
        Time.timeScale = 1f;
        botonpausa.SetActive(true);
        menupausa.SetActive(false);
    }
    public void Reiniciar()
    {  
        pausado = false;
        Time.timeScale=1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Salir() { 
        Application.Quit();
    }
}
