using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projetil : MonoBehaviour
{
    [Range(1, 5)]
    public float velocidade = 2f;

    [Range(1, 30)]
    public float Destruidor;

    // Use this for initialization
    private void Start()
    {
        StartCoroutine(Destruidor1(Destruidor));
    }

    // Update is called once per frame
    private void Update()
    {
        transform.Translate(Vector3.forward * velocidade * Time.deltaTime);
    }

    private IEnumerator Destruidor1(float Destruidor)
    {
        yield return new WaitForSeconds(Destruidor);
        Destroy(gameObject);
    }
}