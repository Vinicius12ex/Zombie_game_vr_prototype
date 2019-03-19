using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zumbi : MonoBehaviour {

    Animator anim;
    Rigidbody rb;

    public float velocidade = 0.35f;

	// Use this for initialization
	void Start ()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        rb.velocity = transform.forward * velocidade;
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
            // Destroy(gameObject);

            anim.SetTrigger("Morrer");
        }
    }
}
