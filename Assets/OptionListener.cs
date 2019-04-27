using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionListener : MonoBehaviour
{
    public GameOption[] options;
    private void Start()
    {
        Debug.Log(options.Length);

    }
    // Update is called once per frame
    void Update()
    {
        for (int x=0; x <options.Length; x++)
        {
            if (options[x].selected)
            {
                
                StartCoroutine(options[x].RunAction(options[x].GetComponent<Collider>()));
            }
        }
    }
}
