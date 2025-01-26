using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class MouseScript : MonoBehaviour
{
    public GameObject[] BackObject;
    public LogicScript logic;
    private bool flag = false;
    private bool canClick = false;
    private Collision2D touch;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    void Update()
    {
        var pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(pos.x, pos.y, 5);
        if (touch != null)
        {
            if (Input.GetMouseButton(0))
            {
                switch (touch.gameObject.name)
                {
                    case "Elexir":
                        if (flag)
                            logic.ShowDescription(0);
                        break;
                    case "PaperMushroom":
                        logic.ShowDescription(1);
                        break;
                    case "Mushroom":
                        logic.ShowDescription(2);
                        break;
                    case "Books":
                        logic.ShowDescription(3);
                        flag = true;
                        break;
                    case "PhotoFrame":
                        logic.ShowDescription(4);
                        break;
                }
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        touch = other;
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        touch = null;
    }
}
