using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    // Start is called before the first frame update

    public Vector3 velocity;
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            //Destroy(collision.gameObject);
            collision.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(velocity);
    }
}
