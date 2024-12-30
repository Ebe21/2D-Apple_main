using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public List<GameObject> Objects;
    public float spawnTime = 1f;
    public int score;

    public bool isGameActive;

    public TextMeshProUGUI scoreText;
    public GameObject gameOverPanel;
    // Start is called before the first frame update
    void Start()
    {
        isGameActive = true;
        score = 0; 

        StartCoroutine(Spawner());
        //scoreAdd(5);   
    }   

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Spawner()
    {
        while (isGameActive)
        {
            yield return new WaitForSeconds(spawnTime);
            int index = Random.Range(0, Objects.Count);
            Instantiate(Objects[index]);
        }

    }

    public void scoreAdd(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }


    public void GameOver()
    {
        gameOverPanel.SetActive(true);
        isGameActive = false;
    }

    //public void RestartGame()
    //{
    //    gameOverPanel.SetActive(false);
    //    isGameActive= true;
    //}
}
