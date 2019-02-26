using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    [Header("Atirar")]
    [Tooltip("Prefab do projétil que será gerado quando o jogador atirar")]
    public GameObject projetilPrefab;

    // Use this for initialization
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        bool botaoPressionado = Input.GetMouseButtonDown(0);
        if (botaoPressionado)
        {
            Atirar();
        }
    }

    private void Atirar()
    {
        GameObject projetil = Instantiate(projetilPrefab);
        projetil.transform.position = Camera.main.transform.position;
        projetil.transform.rotation = Camera.main.transform.rotation;
    }
}