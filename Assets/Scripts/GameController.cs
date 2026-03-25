using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    [SerializeField] private int seed;
    public TMP_InputField passInput;

    public bool simplePuzzle(string input)
    {
        if (input == "ABC" || input == "abc")
        {
            return true;
        }
        return false;
    }
}
