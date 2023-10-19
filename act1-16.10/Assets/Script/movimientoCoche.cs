using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoCoche : MonoBehaviour
{

    public float velocidad = 15.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * velocidad);
    }
}
