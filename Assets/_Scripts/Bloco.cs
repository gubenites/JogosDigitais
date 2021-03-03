using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bloco : MonoBehaviour
{
    int dura;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        dura -= 1;
        if(dura == 0)
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        Color newColor = new Color(Random.value, Random.value, Random.value, 1.0f);

        GetComponent<Renderer>().material.color = newColor;

        dura = Random.Range(1, 3);
    }
}
