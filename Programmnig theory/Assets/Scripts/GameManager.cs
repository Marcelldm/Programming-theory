using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameManager Instance;
    public InputField nameInput;
    public Text additionalText;

    private string playerName;

    //ENCAPSULATION
    public string PlayerName               
    {
        get => playerName;
        set
        {
            if (value == "Gabe Newell")
            {
                additionalText.text = "Really?";
            }
            else 
            { 
                playerName = value;               
            }
            
        }
    }
    
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    public void StartGame()
    {
        PlayerName = nameInput.text;

        if( playerName != null)
        { 
            SceneManager.LoadScene(1); 
        }
        
        Debug.Log(playerName);
    }
}
