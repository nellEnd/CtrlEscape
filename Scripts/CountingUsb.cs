using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class CountingUsb : MonoBehaviour
{
    [SerializeField]
    private TMP_Text scoreUI;

    private int _score = 0;

    public void IncreasePoint()
    {
        _score = _score + 1;

        StartCoroutine(ShowScoreAndHideIt(3));
    }

    IEnumerator ShowScoreAndHideIt(int secondsToBeShown)
    {
        scoreUI.gameObject.SetActive(true);

        scoreUI.text = "COLLECTED USB: " + _score.ToString() + "/4";

        yield return new WaitForSeconds(secondsToBeShown);

        scoreUI.gameObject.SetActive(false);
    }
}
