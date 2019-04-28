using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour {

	public GameObject fruitSlicedPrefab;
	public float startForce = 15f;
	Rigidbody rb;
    public AudioSource soundSlice;
    
	void Start ()
	{
        
        BasicSetup();
        
        fruitSlicedPrefab.transform.localScale =  gameObject.transform.localScale;
		rb = GetComponent<Rigidbody>();
		rb.AddForce(transform.up * startForce, ForceMode.Impulse);            
	}
    protected void BasicSetup()
    {
        soundSlice = GameObject.Find("Watermellon_Hit").GetComponent<AudioSource>();
        //soundSlice.clip.LoadAudioData();
        rb = GetComponent<Rigidbody>();
      //  randomFruitSize(ref fruitSlicedPrefab);
    }
    private void OnTriggerEnter(Collider other)
    {
        SliceFruit(other);
    }
    protected void RemoveFruit()
    {
        
        //transform.localPosition = Vector3.zero;
        rb.detectCollisions = false;
        Destroy(gameObject,5f);
    }
    protected void SliceFruit(Collider col)
    {
        if (col.tag == "Blade" )
        {
            //Debug.Log("Blade Hit the Fruit");
            if (gameObject.tag == "Fruit")
            {
                GameStats.fruitSliced += 1;
                txtManager.setSliced();
            }
           
            //Debug.Log(""+ GameStats.fruitSliced);
            Vector3 direction = (col.transform.position - transform.position).normalized;

            Quaternion rotation = Quaternion.LookRotation(direction);

            GameObject slicedFruit = Instantiate(fruitSlicedPrefab, transform.position, rotation);
           
            //randomFruitSize(ref slicedFruit);
            Destroy(slicedFruit, 3f);
            RemoveFruit();
            soundSlice.Play();
            
        }
        

    }
void randomFruitSize(ref GameObject sf)
{
    float multi = Random.Range(.5f, 1.25f);
    sf.transform.localScale = new Vector3(multi, multi, multi);
    gameObject.transform.localScale = new Vector3(multi, multi, multi);
}       
    }

