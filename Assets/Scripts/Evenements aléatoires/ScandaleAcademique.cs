using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScandaleAcademique : MonoBehaviour
{
    [SerializeField] PlayerVariables playerVariables;

    void Start()
    {
        playerVariables.GlobalSatisfactionRate = (int)(playerVariables.GlobalSatisfactionRate * 0.8);
        playerVariables.AttractionRate = (int)(playerVariables.AttractionRate * 0.8);
    }

    void Update()
    {
        
    }
}
