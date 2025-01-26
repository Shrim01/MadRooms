using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using SubClasses;
using UnityEngine.SceneManagement;

public class TextEventScript : MonoBehaviour
{
    public Text textStart;
    public string[] replics;
    private int numReplic = 1;
    public float decayRate;
    private LinkedList speech;
    private bool canChange = false;
    private float angel = -Mathf.PI / 2;
    private bool flag;

    void Start()
    {
        textStart.text = replics[0];
    }

    void Update()
    {
        Debug.Log(numReplic);
        if (Input.GetMouseButton(0))
            canChange = true;
        if (canChange)
        {
            if (angel > Mathf.PI / 2 - 0.01)
            {
                canChange = false;
                textStart.color = new Color(1, 1, 1, 1);
                flag = true;
                angel -= Mathf.PI * 2;
            }
            else
            {
                angel += Time.deltaTime * decayRate;
                textStart.color = new Color(1, 1, 1, Mathf.Sin(angel) / 2 + 0.5f);
                if (textStart.color.a < 0.01 && flag)
                {
                    if (numReplic<replics.Length)
                    {
                        flag = false;
                        textStart.text = replics[numReplic++];
                    }
                    else
                        SceneManager.LoadScene("Room");
                }
            }
        }
    }
}
