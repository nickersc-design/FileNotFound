using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class NoteController : MonoBehaviour
{

    [Header("Input")]
    [SerializeField] private KeyCode closeKey;

    [Space(10)]
    [SerializeField] private Controller player;

    [Header("UI Text")]
    [SerializeField] private GameObject noteCanvas;
    [SerializeField] private TMP_Text noteTextAreaUI;
    [SerializeField] private GameController gameController;

    [Space(10)]
    [SerializeField] private string noteText;
    [SerializeField] private string puzzleText;

    [SerializeField] private string puzzleAnswer;

    [Space(10)]
    [SerializeField] private UnityEvent openEvent;
    private bool isOpen = false;
    public bool isLocked;

    

    public void ShowNote()
    {
        noteTextAreaUI.text = noteText;
        noteCanvas.SetActive(true);
        gameController.passInput.gameObject.SetActive(false);
        openEvent.Invoke();
        DisablePlayer(true);
        isOpen = true;
    }
    public void ShowPuzzle()
    {
        noteTextAreaUI.text = puzzleText;
        noteCanvas.SetActive(true);
        gameController.passInput.gameObject.SetActive(true);
        gameController.passInput.ActivateInputField();
        openEvent.Invoke();
        DisablePlayer(true);
        isOpen = true;
    }

    void DisableNote()
    {
        gameController.passInput.gameObject.SetActive(true);
        noteCanvas.SetActive(false);
        //noteTextAreaUI = null;
        DisablePlayer(false);
        isOpen = false;
    }
    
    void DisablePlayer(bool disable)
    {
        player.canMove = !disable;
    }

    private void Update()
    {
        if (gameController.simplePuzzle(gameController.passInput.text, puzzleAnswer) && isLocked)
        {
            isLocked = false;
            DisableNote();
            ShowNote();
        }

        if (isOpen)
        {
            if (Input.GetKeyDown(closeKey))
            {
                DisableNote();
            }
        }
    }
}
