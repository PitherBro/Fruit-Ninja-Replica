using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour {

	public GameObject fruitSlicedPrefab;
	public float startForce = 15f;
	Rigidbody rb;

	void Start ()
	{
        fruitSlicedPrefab.transform.localScale =  gameObject.transform.localScale;
		rb = GetComponent<Rigidbody>();
		rb.AddForce(transform.up * startForce, ForceMode.Impulse);
	}

    private void OnTriggerEnter(Collider other)
    {
        SliceFruit(other);
    }
    protected void RemoveFruit()
    {
        transform.localPosition = Vector3.zero;
        rb.detectCollisions = false;
        Destroy(gameObject,5f);
    }
    protected void SliceFruit(Collider col)
    {
        if (col.tag == "Blade")
        {
            Debug.Log("Blade Hit the Fruit");
            Vector3 direction = (col.transform.position - transform.position).normalized;

            Quaternion rotation = Quaternion.LookRotation(direction);

            GameObject slicedFruit = Instantiate(fruitSlicedPrefab, transform.position, rotation);
            randomFruitSize(ref slicedFruit);
            Destroy(slicedFruit, 3f);
            RemoveFruit();
        }
        if (col.tag == "Bounds")
        {
            Debug.Log("Fruit Hit Bounds");
            Destroy(gameObject);

        }
        void randomFruitSize(ref GameObject sf)
        {
            float multi = Random.Range(.5f, 1.25f);
            sf.transform.localScale = new Vector3(multi, multi, multi);
            gameObject.transform.localScale = new Vector3(multi, multi, multi);
        }
    }

}
