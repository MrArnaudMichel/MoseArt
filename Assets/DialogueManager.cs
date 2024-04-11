using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI dialogueText;
    [SerializeField] public GameObject mainUI;
    [SerializeField] private bool isWriting;
    [SerializeField] private string currentText;
    [SerializeField] private List<string> dialogueList;
    [SerializeField] private int dialogueIndex = 0;
    [SerializeField] private float timeBetweenCharacters = 0.005f;
    [SerializeField] private bool _isSettingUp = false;
    [SerializeField] public int testValue = 1;

    [SerializeField] private setupUI setupUI;

    private int _uiToAdd = -1;

    public int TestValue { get => testValue; set => testValue = value; }

    private float timeSinceLastCharacter = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!_isSettingUp)
        {
            return;
        }
        WriteText();
    }

    public void StartDialogue(int id, int uiToAdd = -1)
    {
        this.gameObject.SetActive(true);
        mainUI.SetActive(false);
        Debug.Log("Active" + mainUI.activeSelf);
        dialogueList = DialogueData.GetDialogueData(id);
        dialogueIndex = 0;
        currentText = dialogueList[dialogueIndex];
        dialogueText.text = "";
        isWriting = true;
        _isSettingUp = true;
        _uiToAdd = uiToAdd;
    }

    public void NextDialogue()
    {
        if (isWriting)
        {
            dialogueText.text = currentText;
            isWriting = false;
            return;
        }
        dialogueIndex++;
        if (dialogueIndex < dialogueList.Count)
        {
            currentText = dialogueList[dialogueIndex];
            dialogueText.text = "";
            isWriting = true;
        }
        else
        {
            this.gameObject.SetActive(false);
            mainUI.SetActive(true);
            _isSettingUp = false;
            if (_uiToAdd > 0)
            {
                setupUI.setup(_uiToAdd);
                _uiToAdd = -1;
            }
        }
    }

    private void WriteText()
    {
        if (isWriting)
        {
            timeSinceLastCharacter += Time.deltaTime;
            if (timeSinceLastCharacter >= timeBetweenCharacters)
            {
                timeSinceLastCharacter = 0;
                dialogueText.text += currentText[dialogueText.text.Length];
            }
            if (dialogueText.text.Length == currentText.Length)
            {
                isWriting = false;
            }
        }
    }
}
