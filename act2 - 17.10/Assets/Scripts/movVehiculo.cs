using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movJugador : MonoBehaviour
{

    public float velocidad = 15.0f;
    public float velocidadGiro = 25.0f;
    public float controlHorizontal;
    public float controlAvance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // transform.Translate(Vector3.forward * Time.deltaTime * velocidad);


        controlHorizontal = Input.GetAxis("Horizontal");
        controlAvance = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * velocidad * controlAvance);
        transform.Translate(Vector3.right * Time.deltaTime * velocidadGiro * controlHorizontal);
        transform.Rotate(Vector3.up, Time.deltaTime * velocidadGiro * controlHorizontal);
    }
}
