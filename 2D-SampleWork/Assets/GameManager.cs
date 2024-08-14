using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text Scorenum;
    public GameObject GameoverPanel;
    public GameObject GameScreen;
    public int points;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Score()
    {
        Scorenum.text = "Score" + points;
        points++;
        GameoverPanel.SetActive(true);
    }
    public void Retry()
    {
        GameoverPanel.SetActive(false);
        GameoverPanel.SetActive(true);
        Time.timeScale = 1;
    }
}
