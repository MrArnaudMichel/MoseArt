using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DonImportant : MonoBehaviour
{
    [SerializeField] PlayerVariables playerVariables;
    void Start()
    {
        playerVariables.Money = playerVariables.Money + 500000;
    }

    void Update()
    {
        
    }
}
