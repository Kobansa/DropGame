using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    //public GameObject BasketObject;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Basket")
        {
            Destroy(this.gameObject, 0.01f);
            //Destroy(this.AppleObject, 0.01f);
        }
    }
  
}
