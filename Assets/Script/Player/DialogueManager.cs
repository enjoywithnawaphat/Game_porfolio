using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class DialogueManager : MonoBehaviour
{
    private Queue<string> sentences;
    [SerializeField] private TextMeshProUGUI nameText;
    [SerializeField] private TextMeshProUGUI dialogueText;
    private InputManager inputManager;
    [SerializeField] private GameStateManager gameStateManager;
    public GameObject background;

    void Start()
    {
        inputManager = GetComponent<InputManager>();

        sentences = new Queue<string>();
        nameText.SetText("");
        dialogueText.SetText("");
        background.SetActive(false);
    }

    public void StartDialogue(Dialogue dialogue)
    {
        inputManager.dialogue.Next.performed += ctx => OnNextDialogue(ctx);
        gameStateManager.ChangeState(Gamestate.Dialogue);
        nameText.text = dialogue.name;
        background.SetActive(true);
        sentences.Clear();
        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }

    private void OnNextDialogue(InputAction.CallbackContext ctx)
    {
        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentance = sentences.Dequeue();
        dialogueText.text = sentance;
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentance));
    }

    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(0.03f);
        }
    }

    public void EndDialogue()
    {
        nameText.gameObject.SetActive(false);
        dialogueText.gameObject.SetActive(false);
        gameStateManager.ChangeState(Gamestate.Playing);
        background.SetActive(false);
        inputManager.dialogue.Next.performed -= ctx => OnNextDialogue(ctx);
    }
}
