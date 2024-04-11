using static UnityEngine.GraphicsBuffer;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(DialogueManager))]
public class DialogEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        DialogueManager dialogueManager = (DialogueManager)target;
        if (GUILayout.Button("Set dialogue with id(0 default)"))
        {
            dialogueManager.StartDialogue(dialogueManager.TestValue);
        }
    }
}