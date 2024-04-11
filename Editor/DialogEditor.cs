using static UnityEngine.GraphicsBuffer;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(DialogueManager))]
public class DialogEditor : Editor
{
    public int dialogueId = 0;
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        DialogueManager dialogueManager = (DialogueManager)target;
        if (GUILayout.Button("Set dialogue with id(0 default)"))
        {
            dialogueManager.StartDialogue(dialogueId);
        }
    }
}