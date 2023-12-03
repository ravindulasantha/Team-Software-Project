using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject firstPanel;
    public GameObject secondPanel;
    public GameObject loadingPanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayBtn()
    {
        firstPanel.SetActive(false);
        secondPanel.SetActive(true);
    }

    public void day1()
    {
        SceneManager.LoadScene(1);
        
    }
    public void day2()
    {
        SceneManager.LoadScene(3);

    }
    public void day3()
    {
        SceneManager.LoadScene(6);

    }



    public void QuitBtn()
    {
        Application.Quit();
    }

    public void LoadingPanel()
    {
        secondPanel.SetActive(false);
        loadingPanel.SetActive(true);
    }

    public void backBtn()
    {
        secondPanel.SetActive(false);
        firstPanel.SetActive(true);
    }
}
