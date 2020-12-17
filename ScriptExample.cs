using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptExample : MonoBehaviour
{
    public int myInteger = 5;
    public float myFloat = 3.5f;
    public bool myBoolean = true;
    public string myString = "Miau";
    public int[] myArray;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello man, let's just chill. Here have some int...");
        Debug.Log("Nice man, now you have: " + (myInteger + 2));

        SpriteRenderer mySpriteRenderer = GetComponent<SpriteRenderer>();
        
        //Find objects in Scene
        GameObject anObjectWithSpriteRenderer = FindObjectOfType<SpriteRenderer>().gameObject;
        GameObject anObjectWithTag = GameObject.FindWithTag("Player"); //Faster than  with name
        GameObject anObjectWithName = GameObject.Find("Whatever name");

        //Enable and disable components
        if(mySpriteRenderer != null){
            mySpriteRenderer.enabled = true; //false
        }

        //Enable and disable gameObjects
        if(anObjectWithName != null){
            anObjectWithName.SetActive(false); //true
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
