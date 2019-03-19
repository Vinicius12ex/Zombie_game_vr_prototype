using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zumbi : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void OnTriggerEnter(Collider other)
    {
        //Exibo a tag do collider trigger que ativou
        print("OnTriggerEnter Zumbi: " + other.name);

        //verificou se a tag do trigger é igual a projétil
        if (other.CompareTag("Projetil"))
        {
            // Objetivo other verificado. É o projetil
            // Destrói o gameObject do projétil
            Destroy(other.gameObject);

            // Destrói o zumbi que foi atingido
            Destroy(gameObject);
        }
    }
}
