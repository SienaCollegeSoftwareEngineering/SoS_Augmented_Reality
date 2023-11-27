using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class ScavengerHunt : MonoBehaviour
{
    public Button btn;

    public Image pnl;
    public Image img;

    public Image XButtonClueImg;

    public Button XButtonClue;

    public Image cluePanel;

    public TMP_Text nextClue;
    public Button XButton;
    public TMP_Text clueText;

    public TMP_Text coinCounter;

    public static string global_PlaqueInfo;

    public int coinCount = 0;

    public bool usedHint = false;

    public bool gameStarted = false;
    

    //public List<string> plaqueNums = new List<string> { "RB308", "RB311", "RB313", "RB314", "RB315", "RB316", "RB317", "RB318", "RB319", "RB320", "RB321", "RB323"};

    //public List<string> plaqueHints = new List<string> { "Teresco", "Small", "Vandenberg", "DiTursi", "Flatland", "Lim", "Goldstein", "Small", "Cotler", "Breimer", "Armitage", "Matthews"};

    public static string[] plaqueNums = {"RB323","RB313", "RB321", "RB308", "RB311", "RB314", "RB315", "RB316", "RB317", "RB318", "RB319", "RB320", };

    public static string[] plaqueClues = {"This professor teaches Discrete Structures and their office is located near Room 350", 
    "This professor’s favorite class to teach is Database Management Systems and their office is located near Room 328",
    "This professor is the advisor of the Cyber Security club and their office is located near Room 350", 
    "Teresco", "White", "DiTursi", "Flatland", "Lim", "Goldstein", "Small", "Cotler", "Breimer"};

    public static string[] plaqueHints = {"Matthews", "Vandenberg", "Armitage", "Teresco", "White", "DiTursi", "Flatland", "Lim", "Goldstein", "Small", "Cotler", "Breimer"};


    public int current_Plaque = 0;


    void Awake(){
        current_Plaque = 0;
        coinCount = 0;
        
    }

    public void SelfTour(){
        pnl = GameObject.Find("RBButtons").GetComponent<Image>();
        pnl.enabled = false;
        clueText = GameObject.Find("SelfTourButtonText").GetComponent<TMPro.TextMeshProUGUI>();
        //clueText.enabled = false;
        btn = GameObject.Find("SelfTourButton").GetComponent<Button>();
        btn.enabled = false;
        img = GameObject.Find("SelfTourButton").GetComponent<Image>();
        img.enabled = false;
        clueText = GameObject.Find("SelfTourButtonText").GetComponent<TMPro.TextMeshProUGUI>();
        //clueText.enabled = false;
        btn = GameObject.Find("ScavengerHuntButton").GetComponent<Button>();
        btn.enabled = false;
        img = GameObject.Find("ScavengerHuntButton").GetComponent<Image>();
        img.enabled = false;
        
        clueText = GameObject.Find("SienaText").GetComponent<TMP_Text>();
        clueText.enabled = false;
    }
    public void DeactivateGame(){
        gameStarted = false;
    }
    public void ActivateGame(){
            pnl = GameObject.Find("RBButtons").GetComponent<Image>();
        pnl.enabled = false;
        //clueText = GameObject.Find("SelfTourButtonText").GetComponent<TMP_Text>();
        //clueText.enabled = false;
        btn = GameObject.Find("SelfTourButton").GetComponent<Button>();
        btn.enabled = false;
        img = GameObject.Find("SelfTourButton").GetComponent<Image>();
        img.enabled = false;
        clueText = GameObject.Find("ScavengerHuntButtonText").GetComponent<TMP_Text>();
        clueText.enabled = false;
        btn = GameObject.Find("ScavengerHuntButton").GetComponent<Button>();
        btn.enabled = false;
        img = GameObject.Find("ScavengerHuntButton").GetComponent<Image>();
        img.enabled = false;
        
        clueText = GameObject.Find("SienaText").GetComponent<TMP_Text>();
        clueText.enabled = false;
            Debug.Log("Game Activated");
            clueText = GameObject.Find("CoinCounter").GetComponent<TMP_Text>();
            clueText.enabled = true;
            img = GameObject.Find("Coin").GetComponent<Image>();
            img.enabled = true;
            pnl = GameObject.Find("CoinBackground").GetComponent<Image>();
            pnl.enabled = true; 
            btn = GameObject.Find("ClueButton").GetComponent<Button>();
            btn.enabled = true;
            clueText = GameObject.Find("ClueButtonText").GetComponent<TMP_Text>();
            clueText.enabled = true;
            img = GameObject.Find("ClueButton").GetComponent<Image>();
            img.enabled = true;

        gameStarted = true;
    }
    public void GetCurrentPlaque(string plaqueInfo)
    {
        if(gameStarted == true){
            global_PlaqueInfo = plaqueInfo;
            Debug.Log(global_PlaqueInfo);
            checkPlaque();
        }

    }

    public void checkPlaque()
    {
        if (current_Plaque != 14)
        {
            if (string.Equals(global_PlaqueInfo, plaqueNums[current_Plaque]))
            {
                Debug.Log("Correct Plaque");
                //plaqueNums.RemoveAt(current_Plaque);
                //plaqueHints.RemoveAt(current_Plaque);
                if (current_Plaque == 14)
                {
                    Debug.Log("Won Game");
                }
                else
                {
                    if(usedHint == false)
                    {
                        coinCount++;
                        incrementCoin(); 
                    }
                    else{
                        usedHint = false;
                    }
                    
                    newPlaque();
                    displayClue();
                }
            }
            else
            {
                Debug.Log("Incorrect Plaque");
            }
        }
    }

    public void newPlaque()
    {
        //current_Plaque = Random.Range(0, plaqueNums.Count-1);

        current_Plaque++;
        
        Debug.Log(current_Plaque);
    }

    public void displayCurrentHint()
    {
        for(int i = 0; i < plaqueNums.Length; i++)
        {
            Debug.Log(plaqueNums[i]);
        }

        Debug.Log(plaqueHints.Length);

        clueText = GameObject.Find("ClueText").GetComponent<TMP_Text>();
        clueText.enabled = true;
        clueText.text = plaqueHints[current_Plaque];

        XButton = GameObject.Find("XButton").GetComponent<Button>();
        XButton.enabled = true;

        img = GameObject.Find("XButton").GetComponent<Image>();
        img.enabled = true;

        pnl = GameObject.Find("ClueBackground").GetComponent<Image>();
        pnl.enabled = true;
    }

    public void hideCurrentHint()
    {
        clueText = GameObject.Find("ClueText").GetComponent<TMP_Text>();
        clueText.enabled = false;

        XButton = GameObject.Find("XButton").GetComponent<Button>();
        XButton.enabled = false;

        img = GameObject.Find("XButton").GetComponent<Image>();
        img.enabled = false;

        pnl = GameObject.Find("ClueBackground").GetComponent<Image>();
        pnl.enabled = false;
    }


    public void incrementCoin()
    {
        
        coinCounter = GameObject.Find("CoinCounter").GetComponent<TMP_Text>();
    
        string coinCountText = coinCount.ToString();
        coinCounter.text = coinCountText;
        Debug.Log(coinCount);
    }

    public void displayClue()
    {
        nextClue = GameObject.Find("NextClue").GetComponent<TMP_Text>();
        nextClue.text = plaqueClues[current_Plaque];
        nextClue.enabled = true;

        cluePanel = GameObject.Find("NextClueBackground").GetComponent<Image>();
        cluePanel.enabled = true;

        XButtonClue = GameObject.Find("XButtonClue").GetComponent<Button>();
        XButtonClue.enabled = true;

        XButtonClueImg = GameObject.Find("XButtonClue").GetComponent<Image>();
        XButtonClueImg.enabled = true;
    }

    public void hideClue(){
        nextClue = GameObject.Find("NextClue").GetComponent<TMP_Text>();
        nextClue.enabled = false;

        cluePanel = GameObject.Find("NextClueBackground").GetComponent<Image>();
        cluePanel.enabled = false;

        XButtonClue = GameObject.Find("XButtonClue").GetComponent<Button>();
        XButtonClue.enabled = false;

        XButtonClueImg = GameObject.Find("XButtonClue").GetComponent<Image>();
        XButtonClueImg.enabled = false;
    }
    
}