using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounds : MonoBehaviour
{

    private void OnTriggerExit(Collider other)
    {
        if (other.tag != "Blade")
        {
            if (other.tag == "Sphere(Clone)" || other.tag == "Sphere_002(Clone)")
            { Destroy(other.gameObject.gameObject); }
            else
            Destroy(other.gameObject);
        }
    }
}
