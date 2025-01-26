using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnKeyPianoScript : MonoBehaviour
{
    public GameObject Key;
    public float reload;
    private float time;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > reload)
        {
            Instantiate(Key,
                new Vector3(transform.position.x+Random.Range(0, 4) * 3, transform.position.y, 0),
                transform.rotation);
            GameObject.FindGameObjectWithTag("Piano").GetComponent<PianoScript>().countKey++;
            time = 0;
        }
    }
}
