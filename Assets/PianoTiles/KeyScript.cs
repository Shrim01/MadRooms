using UnityEngine;

public class KeyScript : MonoBehaviour
{
    public Rigidbody2D Rb2D;
    public float speed;
    private bool flag;
    private int numLine;
    private string[] KeyCode;
    private PianoScript piano;
    private int numKey;


    void Start()
    {
        piano = GameObject.FindGameObjectWithTag("Piano").GetComponent<PianoScript>();
        numKey = piano.countKey;
        KeyCode = new[] { "d", "f", "j", "k" };
        numLine = (int)(transform.position.x + 4.5f) / 3;
        Rb2D.velocity = new Vector2(0, -speed);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode[numLine]))
        {
            if (flag&&numKey==piano.lastKey+1)
            {
                Destroy(gameObject);
                piano.lastKey=numKey;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag != "Key")
            flag = true;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag != "Key")
        {
            Destroy(gameObject);
            piano.lastKey=numKey;
        }
    }
}
