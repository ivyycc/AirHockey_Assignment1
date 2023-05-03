using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour 
{
    public float start = 15;
    public TMP_Text textbox;
    public GameObject CanvasTimer;
    private int howOften; 

    private void Start()
    {
        textbox.text = start.ToString();
        howOften = Random.Range(5, 15);

    }

    public void Update()
    {
    
        start -= Time.deltaTime;
        textbox.text = Mathf.Round(start).ToString();

        if (start < 1)
          {
            textbox.text = "end!";
            CanvasTimer.SetActive(false);
            start = 0;
          }

    }
}
