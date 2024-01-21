using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class NoOfItem
{
    public int amount;
    public GameObject prefeb;

}

public class pool : MonoBehaviour
{
    // Start is called before the first frame update
    public static pool singlton;
    //public GameObject poolGameObject;
    public List<GameObject> poolList;
    public List<NoOfItem> items;


    private void Awake()
    {
        singlton = this;
    }

    public GameObject Get(string tag)
    {
        for (int i = 0; i < poolList.Count; i++)
        {
            if (!poolList[i].activeInHierarchy && poolList[i].tag == tag)
            {   
                return poolList[i];
            }
        }
        return null;
    }
    void Start()
    {
        poolList = new List<GameObject>();
        foreach (NoOfItem item in items)
        {
            for (int i = 0; i < item.amount; i++)
            {
                GameObject obj = Instantiate(item.prefeb);
                obj.SetActive(false);
                poolList.Add(obj);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
