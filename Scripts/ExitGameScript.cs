using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitGameScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void ExitGame() 
    {
        SceneManager.LoadScene(0);   
    }

}
