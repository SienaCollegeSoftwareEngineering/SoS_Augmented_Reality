using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class ScavengerHunt : MonoBehaviour
{
    public Button btn;

    public Image backgroundPanel;
    public Image img;

    public Image XButtonClueImg;

    public Button XButtonClue;

    public TMP_Text _text;
    public Button XButton;

    public TMP_Text tmp;

    public TMP_Text coinCounter;

    public static string global_PlaqueInfo;

    public int coinCount = 0;

    public bool usedHint = false;

    public bool gameStarted = true;

    public bool usedAnswer = false; 

    public bool correct;

    public int clickedNext = 0;   
    

    //public List<string> plaqueNums = new List<string> { "RB308", "RB311", "RB313", "RB314", "RB315", "RB316", "RB317", "RB318", "RB319", "RB320", "RB321", "RB323"};

    //public List<string> plaqueHints = new List<string> { "Teresco", "Small", "Vandenberg", "DiTursi", "Flatland", "Lim", "Goldstein", "Small", "Cotler", "Breimer", "Armitage", "Matthews"};

    //Plaque numbers
    public static string[] plaqueNums = {"RB323","RB313", "RB321", "RB308", "RB311", "RB332", "RB315", "RB316", "RB317", "RB318", "RB319", "RB320","RB338","RB326" };
    //Plaque Clues
    public static string[] plaqueClues = {
        "This professor teaches Discrete Structures and their office is located near Room 350", 
        "This professor’s favorite class to teach is Database Management Systems and their office is located near Room 328",
        "This professor is the advisor of the Cyber Security club and their office is located near Room 350", 
        "This professor is the head chair of the computer science department", 
        "This is the only professor to teach CSIS 220 and their by the CS lounge", 
        "This professor is near 340 and teaches Intro to Computer Science and Software Engineering", 
        "This professor teaches Algorithms and Intro to Computer Science, and their office is located across from Room 328", 
        "This is the only professor who teaches a first year seminar course", 
        "This is the only professor to teach Networking and Unix/Linux",
        "This professor’s research and teaching areas are Artificial Intelligence and Computational Linguistics", 
        "This professor teaches UX Design and Software Engineering", 
        "This professor teaches intro to data science",
        "This professor is the only one to teach Web Design",
        "This professor does research about Natural language processing"
    };
    //Plaque Hints
    public static string[] plaqueHints = {
        "He is not Jack Armitage", 
        "Their plaque says they attended University of Wisconsin-Madison for their PHD", 
        "He is known as the dopey IT guy", 
        "Their plaque says they love to ski", 
        "She has a M.A.T. from Union Graduate College", 
        "He was a professional athlete on the Indian National Rifle Shooting Team", 
        "She loves cooking and distance swimming", 
        "They love to participate in trivia", 
        "One of his photos was chosen for Wikipedia picture of the day", 
        "This professor is located in the CS Lounge", 
        "This professor is across from the Software Engineering Lab", 
        "They love to kayak and row",
        "She has been to all 7 continents", 
        "He got his masters and bachelors degree from Shandong University"
    };

    public static string[] plaqueAnswers = {
        "Mr.James Matthews", "Dr.Scott Vandenberg","Professor Jack Armitage", "Dr.James Teresco", 
        "Professor Pauline White", "Professor Ninad Chaudhari", "Dr.Robin Flatland", "Dr.Darren Lim",
        "Dr.Ira Goldstein", "Dr.Sharon Small", "Dr.Jami Cotler", "Dr.Eric Breimer", "Dr. Maryanne Egan",
         "Dr.Ting Liu"
    };


    //Start current plaque at 0 in the array
    public int current_Plaque = 0;

    //Always set current plaque and coin count back to 0 when page is loaded
    void Awake(){
        
    }
    //If the use clicks self tour only show components for self tour

    public void SelfTour(){
        backgroundPanel = GameObject.Find("RBButtons").GetComponent<Image>();
        backgroundPanel.enabled = false;
        
        //Must find the button object and the image object for each button, this is repeated throughout the code
        btn = GameObject.Find("SelfTourButton").GetComponent<Button>(); 
        btn.enabled = false;
        img = GameObject.Find("SelfTourButton").GetComponent<Image>();
        img.enabled = false;
    
        btn = GameObject.Find("ScavengerHuntButton").GetComponent<Button>();
        btn.enabled = false;
        img = GameObject.Find("ScavengerHuntButton").GetComponent<Image>();
        img.enabled = false;

        btn = GameObject.Find("QuickLinksButton").GetComponent<Button>();
        btn.enabled = false;
        img = GameObject.Find("QuickLinksButton").GetComponent<Image>();
        img.enabled = false;
        
       _text = GameObject.Find("SienaText").GetComponent<TMP_Text>();
       _text.enabled = false;

       
        backgroundPanel = GameObject.Find("DirectionsBackgroundSelfTour").GetComponent<Image>();
        backgroundPanel.enabled = true;
        
        tmp = GameObject.Find("SelfTourDirections").GetComponent<TMP_Text>();
        tmp.enabled = true;

        XButton = GameObject.Find("DirectionsXButton").GetComponent<Button>();
        XButton.enabled = true;

        img = GameObject.Find("DirectionsXButton").GetComponent<Image>();
        img.enabled = true;

        DeactivateGame();
    }
    //Set game started to false if the game is deativated
    public void DeactivateGame(){
        gameStarted = false;
    }
    //If user clicks scavenger hunt show those components and start the game
    public void ActivateGame(){
        backgroundPanel = GameObject.Find("RBButtons").GetComponent<Image>();
        backgroundPanel.enabled = false;
       
        btn = GameObject.Find("SelfTourButton").GetComponent<Button>();
        btn.enabled = false;
        img = GameObject.Find("SelfTourButton").GetComponent<Image>();
        img.enabled = false;
        
        btn = GameObject.Find("ScavengerHuntButton").GetComponent<Button>();
        btn.enabled = false;
        img = GameObject.Find("ScavengerHuntButton").GetComponent<Image>();
        img.enabled = false;

        btn = GameObject.Find("QuickLinksButton").GetComponent<Button>();
        btn.enabled = false;
        img = GameObject.Find("QuickLinksButton").GetComponent<Image>();
        img.enabled = false;
        
       _text = GameObject.Find("SienaText").GetComponent<TMP_Text>();
       _text.enabled = false;
            
           _text = GameObject.Find("CoinCounter").GetComponent<TMP_Text>();
           _text.enabled = true;
            img = GameObject.Find("Coin").GetComponent<Image>();
            img.enabled = true;
            backgroundPanel = GameObject.Find("CoinBackground").GetComponent<Image>();
            backgroundPanel.enabled = true; 
            btn = GameObject.Find("ClueButton").GetComponent<Button>();
            btn.enabled = true;
            img = GameObject.Find("ClueButton").GetComponent<Image>();
            img.enabled = true;
            btn = GameObject.Find("HintButton").GetComponent<Button>();
            btn.enabled = true;
            img = GameObject.Find("HintButton").GetComponent<Image>();
            img.enabled = true;
            btn = GameObject.Find("AnswerButton").GetComponent<Button>();
            btn.enabled = true;
            img = GameObject.Find("AnswerButton").GetComponent<Image>();
            img.enabled = true;

       

        gameStarted = true;
        clickedNext = 0;
        showDirections();
        incrementCoin();
    }
    //Get the current plaque the was scanned if the game was started
    public void GetCurrentPlaque(string plaqueInfo)
    {
        if(gameStarted){
            global_PlaqueInfo = plaqueInfo;
            Debug.Log("Check for me: " + global_PlaqueInfo);
            checkPlaque();
        }

    }

    //Check if the plaque scanned is correct
    public void checkPlaque()
    {
        Debug.Log("Check for me2: " + global_PlaqueInfo);
        if (current_Plaque != 14)
        {
            if (string.Equals(global_PlaqueInfo, plaqueNums[current_Plaque]))
            {
                correct = true;
                Debug.Log("Correct Plaque");
                //plaqueNums.RemoveAt(current_Plaque);
                //plaqueHints.RemoveAt(current_Plaque);
                if (current_Plaque == 14)
                {
                    Debug.Log("Won Game");
                }
                else
                {
                    //If no hint or answer was used, give 2 points and run the incrementCoin method to display the change in the scene
                    if(usedHint == false && usedAnswer == false)
                    {
                        coinCount+= 2;
                        incrementCoin(); 
                    }
                    //If a hint was used, give 1 point and run the incrementCoin method to display the change in the scene
                    else if(usedHint == true && usedAnswer == false)
                    {
                        usedHint = false;
                        coinCount++;
                        incrementCoin();
                    }
                    //If an answer was used, give 0 points
                    else
                    {
                        usedHint = false;
                        usedAnswer = false;
                    }
                    //Get the next plaque
                    newPlaque();
                    //Display the next clue
                    displayClue();
                }
            }
            else
            {
                correct = false;
                Debug.Log("Incorrect Plaque");
            }
            showFeedback();
        }
    }
    //Get a new plaque for the scavenger hunt
    public void newPlaque()
    {
        //current_Plaque = Random.Range(0, plaqueNums.Count-1);

        current_Plaque++;
        
        Debug.Log(current_Plaque);
    }

    //Display the current hint
    public void displayCurrentHint()
    {
        

       _text = GameObject.Find("HintText").GetComponent<TMP_Text>();
       _text.enabled = true;
       _text.text = plaqueHints[current_Plaque];

        XButton = GameObject.Find("XButton").GetComponent<Button>();
        XButton.enabled = true;

        img = GameObject.Find("XButton").GetComponent<Image>();
        img.enabled = true;

        backgroundPanel = GameObject.Find("HintBackground").GetComponent<Image>();
        backgroundPanel.enabled = true;
        usedHint = true;
    }

    //Display the current clue
    public void displayCurrentClue()
    {
       _text = GameObject.Find("NextClue").GetComponent<TMP_Text>();
       _text.text = plaqueClues[current_Plaque];
       _text.enabled = true;

        backgroundPanel = GameObject.Find("NextClueBackground").GetComponent<Image>();
        backgroundPanel.enabled = true;

        XButtonClue = GameObject.Find("XButtonClue").GetComponent<Button>();
        XButtonClue.enabled = true;

        XButtonClueImg = GameObject.Find("XButtonClue").GetComponent<Image>();
        XButtonClueImg.enabled = true;
    }

    //Hide the current Hint
    public void hideCurrentHint()
    {
       _text = GameObject.Find("HintText").GetComponent<TMP_Text>();
       _text.enabled = false;

        XButton = GameObject.Find("XButton").GetComponent<Button>();
        XButton.enabled = false;

        img = GameObject.Find("XButton").GetComponent<Image>();
        img.enabled = false;

        backgroundPanel = GameObject.Find("HintBackground").GetComponent<Image>();
        backgroundPanel.enabled = false;
    }


    //Set the value of the coin text in the UI to the current value of the coincounter
    public void incrementCoin()
    {
        
        coinCounter = GameObject.Find("CoinCounter").GetComponent<TMP_Text>();
        Debug.Log("This checking2:" + coinCount);
        string coinCountText = coinCount.ToString();
        coinCounter.text = coinCountText;
        Debug.Log(coinCount);
    }

    //Display the current clue if the clue button is clicked
    public void displayClue()
    {
       _text = GameObject.Find("NextClue").GetComponent<TMP_Text>();
       _text.text = plaqueClues[current_Plaque];
       _text.enabled = true;

        backgroundPanel = GameObject.Find("NextClueBackground").GetComponent<Image>();
        backgroundPanel.enabled = true;

        XButtonClue = GameObject.Find("XButtonClue").GetComponent<Button>();
        XButtonClue.enabled = true;

        XButtonClueImg = GameObject.Find("XButtonClue").GetComponent<Image>();
        XButtonClueImg.enabled = true;
    }

    //Hide the current clue if the x button is clicked
    public void hideClue(){
       _text = GameObject.Find("NextClue").GetComponent<TMP_Text>();
       _text.enabled = false;

        backgroundPanel = GameObject.Find("NextClueBackground").GetComponent<Image>();
        backgroundPanel.enabled = false;

        XButtonClue = GameObject.Find("XButtonClue").GetComponent<Button>();
        XButtonClue.enabled = false;

        XButtonClueImg = GameObject.Find("XButtonClue").GetComponent<Image>();
        XButtonClueImg.enabled = false;
    }

    //Disable all components of the directions
    public void hideDirections(){
        tmp = GameObject.Find("SelfTourDirections").GetComponent<TMP_Text>();
        tmp.enabled = false;
        img = GameObject.Find("DirectionsBackgroundSelfTour").GetComponent<Image>();
        img.enabled = false;
        XButton = GameObject.Find("DirectionsXButton").GetComponent<Button>();
        XButton.enabled = false;
        img = GameObject.Find("DirectionsXButton").GetComponent<Image>();
        img.enabled = false;
    }


    //Show all components of the directions
    public void showDirections(){
        
        if(gameStarted){
            clickedNext = 0;
            tmp = GameObject.Find("ScavHuntDirections2").GetComponent<TMP_Text>();
            tmp.text = "Here are some buttons to use while you play. Clue is given to you for free";
            showScavHuntDirections1();
        }else{
            tmp = GameObject.Find("SelfTourDirections").GetComponent<TMP_Text>();
            tmp.enabled = true;
            backgroundPanel = GameObject.Find("DirectionsBackgroundSelfTour").GetComponent<Image>();
            backgroundPanel.enabled = true;
            XButton = GameObject.Find("DirectionsXButton").GetComponent<Button>();
            XButton.enabled = true;
            img = GameObject.Find("DirectionsXButton").GetComponent<Image>();
            img.enabled = true;
        }
        
    }


    //Shows the current answer when the answer button is clicked
    public void displayCurrentAnswer()
    {
       _text = GameObject.Find("AnswerText").GetComponent<TMP_Text>();
       _text.text = plaqueAnswers[current_Plaque];
       _text.enabled = true;
        

        XButton = GameObject.Find("AnswerXButton").GetComponent<Button>();
        XButton.enabled = true;

        img = GameObject.Find("AnswerXButton").GetComponent<Image>();
        img.enabled = true;

        backgroundPanel = GameObject.Find("AnswerBackground").GetComponent<Image>();
        backgroundPanel.enabled = true;

        usedAnswer = true;

    }

    //Hides the current answer when X button is clicked
    public void hideCurrentAnswer()
    {
       _text = GameObject.Find("AnswerText").GetComponent<TMP_Text>();
       _text.enabled = false;

        XButton = GameObject.Find("AnswerXButton").GetComponent<Button>();
        XButton.enabled = false;

        img = GameObject.Find("AnswerXButton").GetComponent<Image>();
        img.enabled = false;

        backgroundPanel = GameObject.Find("AnswerBackground").GetComponent<Image>();
        backgroundPanel.enabled = false;
    }

    //Displays a popup when the wrong plaque is scanned
    public void showFeedback(){
        backgroundPanel = GameObject.Find("FeedbackPlaqueBackground").GetComponent<Image>();
        backgroundPanel.enabled = true;
        tmp = GameObject.Find("FeedbackPlaqueText").GetComponent<TMP_Text>();
        tmp.enabled = true;
        if(correct){
            tmp.text = "Correct!";
            tmp.color = Color.green;
        }else{
            tmp.text = "Incorrect Plaque!";
            tmp.color = Color.red;
        }
        XButton = GameObject.Find("FeedbackPlaqueXButton").GetComponent<Button>();
        XButton.enabled = true;
        img = GameObject.Find("FeedbackPlaqueXButton").GetComponent<Image>();
        img.enabled = true;
    }
    
    public void hideFeedback(){
        backgroundPanel = GameObject.Find("FeedbackPlaqueBackground").GetComponent<Image>();
        if(backgroundPanel.enabled == true){
            backgroundPanel.enabled = false;
            tmp = GameObject.Find("FeedbackPlaqueText").GetComponent<TMP_Text>();
            tmp.enabled = false;
            XButton = GameObject.Find("FeedbackPlaqueXButton").GetComponent<Button>();
            XButton.enabled = false;
            img = GameObject.Find("FeedbackPlaqueXButton").GetComponent<Image>();
            img.enabled = false;
        }
    }

    public void showScavHuntDirections1(){
        btn = GameObject.Find("HelpButton").GetComponent<Button>();
        btn.enabled = false;
        tmp = GameObject.Find("ScavHuntDirections1").GetComponent<TMP_Text>();
        tmp.enabled = true;
        backgroundPanel = GameObject.Find("ScavHuntDirectionsBackground1").GetComponent<Image>();
        backgroundPanel.enabled = true;
        btn = GameObject.Find("NextButton1").GetComponent<Button>();
        btn.enabled = true;
        img = GameObject.Find("NextButton1").GetComponent<Image>();
        img.enabled = true;
        btn = GameObject.Find("SkipButton").GetComponent<Button>();
        btn.enabled = true;
        img = GameObject.Find("SkipButton").GetComponent<Image>();
        img.enabled = true;
    }

    public void showScavHuntDirections2(){
        //Hide the current directions
        tmp = GameObject.Find("ScavHuntDirections1").GetComponent<TMP_Text>();
        tmp.enabled = false;
        backgroundPanel = GameObject.Find("ScavHuntDirectionsBackground1").GetComponent<Image>();
        backgroundPanel.enabled = false;
        btn = GameObject.Find("NextButton1").GetComponent<Button>();
        btn.enabled = false;
        img = GameObject.Find("NextButton1").GetComponent<Image>();
        img.enabled = false;
        btn = GameObject.Find("SkipButton").GetComponent<Button>();
        btn.enabled = false;
        img = GameObject.Find("SkipButton").GetComponent<Image>();
        img.enabled = false;

        //Show the next directions
        tmp = GameObject.Find("ScavHuntDirections2").GetComponent<TMP_Text>();
        tmp.enabled = true;
        backgroundPanel = GameObject.Find("ScavHuntDirectionsBackground2").GetComponent<Image>();
        backgroundPanel.enabled = true;
        btn = GameObject.Find("NextButton2").GetComponent<Button>();
        btn.enabled = true;
        img = GameObject.Find("NextButton2").GetComponent<Image>();
        img.enabled = true;
        
    }

    public void changeDirectionsText(){
        //Change text of current directions
        tmp = GameObject.Find("ScavHuntDirections2").GetComponent<TMP_Text>();
        if(clickedNext == 0){
            tmp.text = "The hint button can be used for additional help. This takes away 1 point.";
            clickedNext++;
        }else if(clickedNext == 1){
            tmp.text = "The answer button can be used for the answer to the current plaque. This takes away 2 points.";
            clickedNext++;
        }else if(clickedNext == 2){
            showScavHuntDirections3();
        }   
    }

    public void showScavHuntDirections3(){
        //Hide the current directions
        tmp = GameObject.Find("ScavHuntDirections2").GetComponent<TMP_Text>();
        tmp.enabled = false;
        backgroundPanel = GameObject.Find("ScavHuntDirectionsBackground2").GetComponent<Image>();
        backgroundPanel.enabled = false;
        btn = GameObject.Find("NextButton2").GetComponent<Button>();
        btn.enabled = false;
        img = GameObject.Find("NextButton2").GetComponent<Image>();
        img.enabled = false;

        //Show the next directions
        tmp = GameObject.Find("ScavHuntDirections3").GetComponent<TMP_Text>();
        tmp.enabled = true;
        backgroundPanel = GameObject.Find("ScavHuntDirectionsBackground3").GetComponent<Image>();
        backgroundPanel.enabled = true;
        btn = GameObject.Find("NextButton3").GetComponent<Button>();
        btn.enabled = true;
        img = GameObject.Find("NextButton3").GetComponent<Image>();
        img.enabled = true;
    }

    public void hideScavHuntDirections3(){
        tmp = GameObject.Find("ScavHuntDirections3").GetComponent<TMP_Text>();
        tmp.enabled = false;
        backgroundPanel = GameObject.Find("ScavHuntDirectionsBackground3").GetComponent<Image>();
        backgroundPanel.enabled = false;
        btn = GameObject.Find("NextButton3").GetComponent<Button>();
        btn.enabled = false;
        img = GameObject.Find("NextButton3").GetComponent<Image>();
        img.enabled = false; 
        btn = GameObject.Find("HelpButton").GetComponent<Button>();
        btn.enabled = true;   
    }

    public void hideScavHuntDirections1(){
        tmp = GameObject.Find("ScavHuntDirections1").GetComponent<TMP_Text>();
        tmp.enabled = false;
        backgroundPanel = GameObject.Find("ScavHuntDirectionsBackground1").GetComponent<Image>();
        backgroundPanel.enabled = false;
        btn = GameObject.Find("NextButton1").GetComponent<Button>();
        btn.enabled = false;
        img = GameObject.Find("NextButton1").GetComponent<Image>();
        img.enabled = false;
        btn = GameObject.Find("SkipButton").GetComponent<Button>();
        btn.enabled = false;
        img = GameObject.Find("SkipButton").GetComponent<Image>();
        img.enabled = false;
        btn = GameObject.Find("HelpButton").GetComponent<Button>();
        btn.enabled = true;
    }
}