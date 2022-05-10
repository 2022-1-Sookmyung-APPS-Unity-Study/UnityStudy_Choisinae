using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotAndColdGame : MonoBehaviour
{
    int randomNumber;
    [Range(0, 100)]
    public int guess;

    int number0fAttempts;
    // Start is called before the first frame update
    void Start()
    {
        randomNumber = Random.Range(0, 100);
        print("Welcome to the Hot & Cold number guessing game.");
        print("A random number between 0 and 100 has been chosen. Your goal is to find this number in the less possible");
        print("Enter in your guess and then press the space button to submit it. Good luck!");    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            number0fAttempts += 1;

            if (guess == randomNumber)
            {
                print("YOU WON! It took you "+ number0fAttempts.ToString() + " attempts.");
            } else if (Mathf.Abs(randomNumber - guess) <= 10) {
                print("Boiling.");
            }
            else if (Mathf.Abs(randomNumber - guess) <= 20){
                print("Very hot.");
            }
            else if (Mathf.Abs(randomNumber - guess) <= 30){
                print("Hot."); 
            }
            else if (Mathf.Abs(randomNumber - guess) <= 40){
                print("Quite hot.");
            }
            else if (Mathf.Abs(randomNumber - guess) <=50){
                print("Neutral.");
            }
            else if (Mathf.Abs(randomNumber - guess) <= 60){
                print("Quite cold.");
            }
            else if (Mathf.Abs(randomNumber - guess) <=70){
                print("Cold.");
            }
            else if (Mathf.Abs(randomNumber - guess) <= 80){
                print("Very cold.");
            }
            else if (Mathf.Abs(randomNumber - guess) <= 100){
                print("Freezing.");
            }
        }
    }
}
 