using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarcelinaScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public Rigidbody2D rb2D;
        public float speed = 10f;

        void Update()
        {
            Move();
        }

        private void Move()
        {
            float horizontal = Input.GetAxis("Horizontal");
            rb2D.velocity = new Vector2(horizontal * speed, 0);
        }
}
