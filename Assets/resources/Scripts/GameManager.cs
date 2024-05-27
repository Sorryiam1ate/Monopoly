using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Main")]


    private int test = 30;
    void Start()
    {
        Debug.Log("Hello World");
        compute_age();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void compute_age()
    {
        Debug.Log("Compute Age");
    }
}
