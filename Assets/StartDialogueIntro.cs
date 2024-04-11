using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartDialogueIntro : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    [SerializeField] private DialogueManager dialogueManager;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Return))
        {
            dialogueManager.StartDialogue(11);
        }
    }
}
