using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] private Button playButton, close, quitButton, howtoplayButton;

    //PlayerReady_andName
    public static string player1Name, player1CharacterName, player1Nick, player2Name, player2CharacterName, player2Nick;
    [SerializeField] private GameObject ReadyButton;
    private bool ReadyButtons = false; 
    [SerializeField] InputField Player1NameInput , Player1CharacterInput, Player1NickInput, Player2NameInput, Player2CharacterInput, Player2NickInput;

    [SerializeField] private GameObject howtoPlay;
    private bool howToPlayBool = false;

    void Start()
    {
       playButton = GameObject.Find("Play").GetComponent<Button>();
       Player1NameInput = GameObject.Find("Player1NameSurname").GetComponent<InputField>();
       Player1CharacterInput = GameObject.Find("Player1CharacterName").GetComponent<InputField>();
       Player1NickInput = GameObject.Find("Player1CharacterNick").GetComponent<InputField>();
       Player2NameInput = GameObject.Find("Player2NameSurname").GetComponent<InputField>();
       Player2CharacterInput = GameObject.Find("Player2CharacterName").GetComponent<InputField>();
       Player2NickInput = GameObject.Find("Player2CharacterNick").GetComponent<InputField>();

        close = GameObject.Find("Close").GetComponent<Button>();
       quitButton = GameObject.Find("Quit").GetComponent<Button>();
       howtoplayButton = GameObject.Find("How to play").GetComponent<Button>();

       ReadyButton = GameObject.Find("ReadyButtons");
       ReadyButton.SetActive(false);
       ReadyButtons = false;

       howtoPlay = GameObject.Find("howtoPlayimage");
       howtoPlay.SetActive(false);
       howToPlayBool = false;

       if (playButton != null)
       {
           playButton.onClick.AddListener(PlayButtonClick);
       }
       if (close != null)
       {
            close.onClick.AddListener(closeButtonClick);
       }
       if (quitButton != null)
       {
           quitButton.onClick.AddListener(quitButtonClick);
       }
       if (howtoplayButton != null)
       {
           howtoplayButton.onClick.AddListener(howtoplayButtonClick);
       }
    }

    private void Update()
    {   
        player1Name = Player1NameInput.text;
        player1CharacterName = Player1CharacterInput.text;
        player1Nick = Player1NickInput.text;
        player2Name = Player2NameInput.text;
        player2CharacterName = Player2CharacterInput.text;
        player2Nick = Player2NickInput.text;
    }

    void PlayButtonClick()
    {
        if (ReadyButtons == false)
        {
            ReadyButton.SetActive(true);
            ReadyButtons = true;
        }
        else if (ReadyButtons == true)
        {
            ReadyButton.SetActive(false);
            ReadyButtons = false;
        }
    }
    void closeButtonClick()
    {
        howtoPlay.SetActive(false);
        howToPlayBool = false;
    }
    void quitButtonClick()
    {
        Application.Quit();
    }
    void howtoplayButtonClick()
    {
        if (howToPlayBool == false)
        {
            howtoPlay.SetActive(true);
            howToPlayBool = true;
        }
        else if (howToPlayBool == true)
        {
            howtoPlay.SetActive(false);
            howToPlayBool = false;
        }
    }
}