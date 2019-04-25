

using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class GameOption : Fruit
{

    public UnityEvent action;
    private void Start()
    {
      
    }
    private void OnTriggerEnter (Collider other)
    {
        transform.localPosition = Vector3.zero;
       //if(other.tag == "Blade")
        StartCoroutine(LoadScene(other));
    }
    IEnumerator LoadScene(Collider collider)
    {
        Debug.Log("Menu Selected");
        //SliceFruit(collider);
        yield return new WaitForSeconds(2);
         action.Invoke();
    }
    
}
