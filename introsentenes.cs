using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class introsentenes : MonoBehaviour
{
    public List<Button> buttons;
    public Image backImage;
    public Button nextButton;
  

    public static Queue<string> messages;
    public static bool alreadySet = false;
    private static string[] dialogue;
    public bool nextbuttoninteractable = true;
    public Image infoimage;
    private void Awake()
    {

        if (!alreadySet)
        {
            dialogue = new string[12];
            dialogue[0] = "Hello warrior! Welcome to Outlast!"; // next button should be enabled to move to dialogue 1
            dialogue[1] = "You currently have 400 coins. Tap on the armoury and buy equipment for your next battle"; //next button should be disabled, and armoury button is the only button enabled. Once they go out of the armoury. disable armoury button and enable inventory button.
            dialogue[2] = "Great! Now that you have bought items, gear up in the inventory";//Once they go out of the the inventory, disable inventory button and enable skills button
            dialogue[3] = "Ensure that you have assigned your skills here. After every battle you will gain more skill points to assign."; //Once they are out of the skills menu, enable next button and disable all other buttons.
            dialogue[4] = "Restart your progress and start anew by clicking here.";
            dialogue[5] = "Collect special dropped items by going into the retrieved items panel";
            dialogue[6] = "Save your progress after each battle";
            dialogue[7] = "Fight your enemy by going to the battle arena!";
            dialogue[8] = "press here to quit the game.";
            dialogue[9] = "press the multiplayer button to go in the multplayer mode and play with others.";
            dialogue[10] = "go to info to read about how to play the game";

            dialogue[11] = "Good Luck!!!";


            messages = new Queue<string>();
            messages.Enqueue(dialogue[0]);
            messages.Enqueue(dialogue[1]);
            //buttons[0].GetComponent<Image>().color = Color.red;

            messages.Enqueue(dialogue[2]);

            // buttons[1].GetComponent<Image>().color = Color.red;
            messages.Enqueue(dialogue[3]);
            messages.Enqueue(dialogue[4]);
            messages.Enqueue(dialogue[5]);
            messages.Enqueue(dialogue[6]);
            messages.Enqueue(dialogue[7]);
            messages.Enqueue(dialogue[8]);
            messages.Enqueue(dialogue[9]);
            messages.Enqueue(dialogue[10]);
            messages.Enqueue(dialogue[11]);
            alreadySet = true;
        }
        }

    public void InfoLoaded()
    {
        infoimage.gameObject.SetActive(true);
    }

        



        void Start()
        {


        if (GameManager.infoscriptbool)
        {
            return;
        }

        if (!GameManager.infoscriptbool)
            {
                InfoLoaded();

                //            infoscript.enabled = false;
                //GameManager.infoscriptbool = false;
            }
            else
            {

                infoimage.gameObject.SetActive(false);
            }



            foreach (Button button in buttons)
            {
                button.interactable = false;
            }


            NextMessage();
            //Debug.Log(messages.Dequeue());
            // dialogueBox.text = messages.Dequeue();
            //messages.Dequeue();
        }


        public void NextMessage()
        {

            Debug.Log("messges" + messages.Peek());

        

        if (messages.Peek() == dialogue[1])
            {
                foreach (Button button in buttons)
                {

                    button.GetComponent<Image>().color = Color.black;

                }

                //messages.Dequeue("this is a tutorial for the game");
                buttons[2].GetComponent<Image>().color = Color.red;
                buttons[2].interactable = true;
                nextButton.interactable = false;
                 nextbuttoninteractable = false;
            }

            if (dialogue[2] != null && messages.Peek() == dialogue[2])
            {
                foreach (Button button in buttons)
                {

                    button.GetComponent<Image>().color = Color.black;

                }
                //messages.Dequeue("this is a tutorial for the game");
                buttons[1].GetComponent<Image>().color = Color.red;
                buttons[1].interactable = true;
                nextButton.interactable = false;
            nextbuttoninteractable = false;
        }


            if (dialogue[3] != null && messages.Peek() == dialogue[3])
            {
                foreach (Button button in buttons)
                {

                    button.GetComponent<Image>().color = Color.black;

                }
                //messages.Dequeue("this is a tutorial for the game");
                buttons[6].GetComponent<Image>().color = Color.red;
                 buttons[6].interactable = true;
                    nextButton.interactable = false;
            nextbuttoninteractable = false;
        }

            if (messages.Peek() == dialogue[4])
            {
                foreach (Button button in buttons)
                {

                    button.GetComponent<Image>().color = Color.black;

                }

                //messages.Dequeue("this is a tutorial for the game");
                buttons[4].GetComponent<Image>().color = Color.red;
            }

            if (messages.Peek() == dialogue[5])
            {
                foreach (Button button in buttons)
                {

                    button.GetComponent<Image>().color = Color.black;

                }
                //messages.Dequeue("this is a tutorial for the game");
                buttons[7].GetComponent<Image>().color = Color.red;
            }

            if (messages.Peek() == dialogue[6])
            {
                foreach (Button button in buttons)
                {

                    button.GetComponent<Image>().color = Color.black;

                }
                //messages.Dequeue("this is a tutorial for the game");
                buttons[3].GetComponent<Image>().color = Color.red;
            }

            if (messages.Peek() == dialogue[7])
            {
                foreach (Button button in buttons)
                {

                    button.GetComponent<Image>().color = Color.black;

                }

                //messages.Dequeue("this is a tutorial for the game");
                buttons[0].GetComponent<Image>().color = Color.red;
            }

            if (messages.Peek() == dialogue[8])
            {
                foreach (Button button in buttons)
                {

                    button.GetComponent<Image>().color = Color.black;

                }
                //messages.Dequeue("this is a tutorial for the game");
                buttons[9].GetComponent<Image>().color = Color.red;
            }

            if (messages.Peek() == dialogue[9])
            {
                foreach (Button button in buttons)
                {

                    button.GetComponent<Image>().color = Color.black;

                }

                //messages.Dequeue("this is a tutorial for the game");
                buttons[5].GetComponent<Image>().color = Color.red;
            }

            if (messages.Peek() == dialogue[10])
            {
                foreach (Button button in buttons)
                {

                    button.GetComponent<Image>().color = Color.black;

                }
                //messages.Dequeue("this is a tutorial for the game");
                buttons[8].GetComponent<Image>().color = Color.red;
            }

            if (messages.Peek() == dialogue[11])
            {

                GameManager.infoscriptbool = true;
                //messages.Dequeue("this is a tutorial for the game");
                foreach (Button button in buttons)
                {
                    button.interactable = true;


                }
                Destroy(backImage);
                Destroy(nextButton.gameObject);
            Destroy(this.gameObject); 
                //nextButton.enabled = false;
                buttons[9].GetComponent<Image>().color = Color.red;

                foreach (Button button in buttons)
                {
                    button.GetComponent<Image>().color = Color.black;
                }

                GameManager.infoscriptbool = true;
            }


            string sentence = messages.Dequeue();

            StartCoroutine(TypeSentence(sentence));





        }


        IEnumerator TypeSentence(string sentence)
        {
            nextButton.interactable = false;
            this.GetComponent<Text>().text = "";
            foreach (char letter in sentence.ToCharArray())
            {
                this.GetComponent<Text>().text += letter;
                yield return null;
            }
        if (nextbuttoninteractable)
        {
            nextButton.interactable = true;
        }
    }








        // Update is called once per frame
        void Update()
        {

        }
    }
