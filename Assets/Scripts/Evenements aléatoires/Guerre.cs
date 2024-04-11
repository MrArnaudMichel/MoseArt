using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guerre : MonoBehaviour
{
    [SerializeField] PlayerVariables playerVariables;  
    void Start()
    {
        playerVariables.Money = playerVariables.Money - 1000000;
    }

    void Update()
    {
        
    }
}
