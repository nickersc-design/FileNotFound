using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    [SerializeField] private int seed;
    public TMP_InputField passInput;

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
