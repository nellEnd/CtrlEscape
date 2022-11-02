using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CodeLock : MonoBehaviour
{
    [SerializeField]
    private string codeMask;

    [SerializeField]
    public GameObject incorrectSymbol;

    [SerializeField]
    public GameObject unlockedSymbol;


    public UnityEvent onMatched;
    public UnityEvent failedMatched;

    private string codeSequence = "";

    public void AddCode(string codeNumber)
    {
        codeSequence += codeNumber;
    }

    public void TestCode()
    {
        if (codeMask == codeSequence)
        {  
            
            onMatched?.Invoke();

        }
        else
        {
            failedMatched?.Invoke();
            Destroy(incorrectSymbol, 2);
        }

        codeSequence = ""; 
    }
}
