using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Kamera()
    {
        SceneManager.LoadScene("Kamera");
    }


    public void Detail(int number)
    {
        PlayerPrefs.SetInt("Desc", number);
        SceneManager.LoadScene("Description");
    }

    public void BackKamera()
    {
        SceneManager.LoadScene("Kamera");
    }

    public void BackMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
