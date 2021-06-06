using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager_4 : MonoBehaviour
{
    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI WinText;
    public Button restartButton;
    public Button nextLevelButton;
    public Button menuButton;
    private AudioSource playerAudio;
    public GameObject music;
    public string nextLevel;
    public string menu;

    public void OnMouseUpAsButton()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        playerAudio = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Attack_4.iswin)
        {
            WinText.gameObject.SetActive(true);
            nextLevelButton.gameObject.SetActive(true);
            menuButton.gameObject.SetActive(true);
            music.gameObject.GetComponent<AudioSource>().mute = true;
        }

        if (enemy_move_4.isdead)
        {
            
            gameOverText.gameObject.SetActive(true);
            restartButton.gameObject.SetActive(true);
            music.gameObject.GetComponent<AudioSource>().mute = true;
            
            
        }
    }
    public void RestartGame()
    {

        enemy_move_4.isdead = false;
        WinText.gameObject.SetActive(false);
        restartButton.gameObject.SetActive(false);
        gameOverText.gameObject.SetActive(false);
        music.gameObject.GetComponent<AudioSource>().mute = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }
    public void gotoNextLevel()
    {
        Attack_4.iswin = false;
        WinText.gameObject.SetActive(false);
        nextLevelButton.gameObject.SetActive(false);
        menuButton.gameObject.SetActive(false);
        SceneManager.LoadScene(nextLevel);
    }
    public void backtoMenu()
    {
       
        Attack_4.iswin = false;
        WinText.gameObject.SetActive(false);
        nextLevelButton.gameObject.SetActive(false);
        menuButton.gameObject.SetActive(false);
        SceneManager.LoadScene("Main");
    }
}
