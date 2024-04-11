using static UnityEngine.GraphicsBuffer;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(NextRound))]
public class NextRoundEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        NextRound nextRound = (NextRound)target;

        if (GUILayout.Button("Next Round Action"))
        {
            nextRound.NextRoundAction();
        }
    }
}