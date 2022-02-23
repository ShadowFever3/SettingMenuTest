using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralScript : MonoBehaviour
{
    [SerializeField]
    Canvas optionsCanvas, mainMenuCanvas;

    private void Start()
    {
        optionsCanvas.GetComponent<Canvas>().enabled = false;
        mainMenuCanvas.GetComponent<Canvas>().enabled = false;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            mainMenuCanvas.GetComponent<Canvas>().enabled = true;
        }
    }
    // Start is called before the first frame update
    public void QuitGame()
    {
        Debug.Log("QUIT GAME");
        Application.Quit();
    }
}
