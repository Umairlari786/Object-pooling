using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class RocketFire : MonoBehaviour
{
    // Start is called before the first frame update

    private float speed = 5.0f;
    public GameObject bomb;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
            float flyDirection = Input.GetAxis("Horizontal") * speed;
            flyDirection *= Time.deltaTime;
            float newPos = transform.position.x + flyDirection ;
            newPos = Mathf.Clamp(newPos,-7.5f,7.5f);
            transform.position = new Vector2(newPos, -3f);
            //transform.Translate(flyDirection, 0, 0);


            if (Input.GetKeyDown(KeyCode.Space))
            {
            //Instantiate(bomb, this.transform.position, Quaternion.identity);

            GameObject b = pool.singlton.Get("Bullet");
            if (b != null)
            {
                b.transform.position = this.transform.position;
                b.SetActive(true);
            }
            }
    }

}
