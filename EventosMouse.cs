/*
Nombre de desarrollador: Jesús Alberto Toríz Hernández
Asignatura: Realidad Aumentada
Profesor: Josué Rivas Díaz
Nombre de código: Eventos Mouse
Descripción: Codigo que contiene las diferentes caracteristicas y aplicaciones que se le asignaron al mouse cuando entren en contacto con los objetos indicados
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventosMouse : MonoBehaviour
{
    [SerializeField]
    Animator animPlayer;
    
    // Declaración de variables para identificar a los objetos 
    //[SerializeField]
    //Renderer materiaObjeto;
    //[SerializeField]
    //Renderer materiaObjeto2;

    //[SerializeField]
    //Rigidbody proyectil;

   //Codificación que marca, que cuando se entre en contacto con el mouse, o se de clic se torne en el color marcado
    //private void OnMouseEnter()
    //{
      //  materiaObjeto.material.color = Color.blue;
    //}

    //private void OnMouseOver()
    //{
      //  materiaObjeto.material.color = Color.green;
    //}

    //private void OnMouseExit()
    //{
      //  materiaObjeto.material.color = Color.red;
    //}

    //private void OnMouseDown()
    //{
    //    materiaObjeto.material.color = Color.black;
    //}

    //private void OnMouseUp()
    //{
    //    materiaObjeto.material.color = Color.yellow;
    //}



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitinfo;

        if (Input.GetMouseButtonDown(0))
        {
            //Creacion de un objeto desde pantalla
            //Rigidbody proyectilPos = Instantiate(proyectil) as Rigidbody;
            //proyectil.position = ray.origin;
            //proyectilPos.AddForce(ray.direction * 1000);

            if (Physics.Raycast(ray,out hitinfo))
            {
                if (hitinfo.collider.tag=="Player")
                {
                    animPlayer.SetTrigger("Hola");
                }

                if (hitinfo.collider.tag == "Pino")
                {
                    
                }
            }
        }
    }
}
