using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class CollectedUSBScript : MonoBehaviour
{

    [SerializeField]
    private CountingUsb scoreMaster;

    public void OnGrabUSB()
    {      
        
        scoreMaster.IncreasePoint();                   
      
    }
}