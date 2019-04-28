using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounds : MonoBehaviour
{

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Fruit")
        {
            Debug.Log("Fruit Hit Bounds");
            Destroy(other.gameObject);
            GameStats.fruitMissed += 1;
            txtManager.setMissed();
        }
      
        
    }
}
