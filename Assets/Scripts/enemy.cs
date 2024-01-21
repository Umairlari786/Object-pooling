using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enmyobj;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Random.Range(0, 100) < 5)
        {
            // Instantiate(enmyobj, this.transform.position + new Vector3(Random.Range(-7, 7), 0), Quaternion.identity);

            GameObject a = pool.singlton.Get("Enemy");
            {
                if (a != null)
                {   
                    a.transform.position = this.transform.position + new Vector3(Random.Range(-7,7),0,0);
                    a.SetActive(true);
                }
            }
        }
        //Instantiate(enmyobj, this.transform.position, Quaternion.identity);
    }
}
