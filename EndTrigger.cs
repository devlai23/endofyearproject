using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndTrigger : MonoBehaviour
{
    public GameObject completeLevelUI;
    public Text timerText;

    void OnTriggerEnter2D()
    {
        GameObject ob = GameObject.Find("Text");
        timer playerScript = ob.GetComponent<timer>();
        timerText.text = playerScript.min + ":" + playerScript.sec;
        completeLevelUI.SetActive(true);
    }
}
