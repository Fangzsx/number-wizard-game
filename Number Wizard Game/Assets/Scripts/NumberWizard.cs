using UnityEngine;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour
{

    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] Text guessText;
    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }


    void StartGame()
    {
        NextGuess();
    }


    public void OnPressHigher()
    {
        //set the minimum value = guess
        min = guess  + 1 ;
        //change value of guess
        NextGuess();
    }

    public void onPressLower()
    {
        max = guess - 1;
        NextGuess();
    }


    void NextGuess()
    {
        guess = Random.Range(min,max + 1);
        guessText.text = ("Is it " + guess + "?");

    }
}
