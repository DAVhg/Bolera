using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaScript : MonoBehaviour
{
    public float force;
    private List<Vector3> boloPosicion;
    private List<Quaternion> boloRotacion;
    private Vector3 bolaPosicion;
    void Start()
    {
        var bolos = GameObject.FindGameObjectsWithTag("Bolo");
        boloPosicion = new List<Vector3>();
        boloRotacion = new List<Quaternion>();
        foreach (var bolo in bolos){
            boloPosicion.Add(bolo.transform.position);
            boloRotacion.Add(bolo.transform.rotation); 
        }
        bolaPosicion = GameObject.FindWithTag("Bola").transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
            GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, force));
        if (Input.GetKeyUp(KeyCode.LeftArrow))
            GetComponent<Rigidbody>().AddForce(new Vector3(1, 0, 0), ForceMode.Impulse);
        if (Input.GetKeyUp(KeyCode.RightArrow))
            GetComponent<Rigidbody>().AddForce(new Vector3(-1, 0, 0), ForceMode.Impulse);
        if (Input.GetKeyUp(KeyCode.R))
            {
                var bolos = GameObject.FindGameObjectsWithTag("Bolo");
                for (int i=0; i < bolos.Length; i++){
                    var boloFisica = bolos[i].GetComponent<Rigidbody>();
                    boloFisica.velocity = Vector3.zero;
                    boloFisica.position = boloPosicion[i];
                    boloFisica.rotation = boloRotacion[i];
                    boloFisica.velocity = Vector3.zero;
                    boloFisica.angularVelocity = Vector3.zero;

                    var bola = GameObject.FindWithTag("Bola");
                    bola.transform.position = bolaPosicion;
                    bola.GetComponent<Rigidbody>().velocity = Vector3.zero;
                    bola.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
                }
        }
        if (Input.GetKeyUp(KeyCode.B)){
            var bola = GameObject.FindWithTag("Bola");
            bola.GetComponent<Rigidbody>().velocity = Vector3.zero;
            bola.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            bola.transform.position = bolaPosicion;
        }
        if (Input.GetKeyUp(KeyCode.Escape)){
            Application.Quit();
        }
    }

    private void OnCollisionEnter(Collision collision){
        if (collision.gameObject.tag == "Pin")
            GetComponent<AudioSource>().Play();
    }
}
