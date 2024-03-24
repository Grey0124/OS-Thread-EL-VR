using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;

public class Collecting : MonoBehaviour
{
    public List<string> Collected_items;
    int i;
    void Start()
    {
        Collected_items = new List<string>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        
        if(other.CompareTag("Collect"))
        {
           
            string itemType = other.gameObject.GetComponent<CollectableComponent>().itemType;
            print("Thread collected: " + itemType);
            Collected_items.Add(itemType);
            Destroy(other.gameObject);
        }
    } 

   
        
    
}
