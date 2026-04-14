using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    [SerializeField] private int seed;
    public TMP_InputField passInput;
    public GameObject player;

    [SerializeField] private Vector3[] startLocs;

    private void Start()
    {
        seed = Random.Range(100, 999);
        setup();
    }
    private void setup()
    {
        //Start Location
        int curDigit = (seed % 10) % 3;
        player.transform.position = startLocs[curDigit];

        //Clue 1
        curDigit = ((seed % 100) - (seed % 10)) % 3;
        if (curDigit == 0)
        {

        }
    }

    public bool simplePuzzle(string input, string puzzleAnswer)
    {
        string inputted_answer = input.ToLower();
        if (inputted_answer == puzzleAnswer)
        {
            return true;
        }
        return false;
    }
}



