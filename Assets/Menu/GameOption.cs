

using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
public class GameOption : Fruit
{
    public bool selected = false;
    public Text text; 
    public UnityEvent action;
    public float rotationSpeed = 10f;
    private void Start()
    {
        BasicSetup(); 
    }
    private void Update()
    {
        transform.Rotate(Vector3.up,rotationSpeed*Time.deltaTime);
        text.transform.Rotate(Vector3.up, 10*rotationSpeed * Time.deltaTime);
    }
    private void OnTriggerEnter (Collider other)
    {       
        selected = true;
        
        SliceFruit(other);
        transform.localPosition = Vector3.zero;
    }
    public IEnumerator RunAction(Collider collider)
    {
        Debug.Log("Menu Selected");
        //SliceFruit(collider);
        text.enabled = false;
        yield return new WaitForSeconds(2);
         action.Invoke();        
    }
    
}
