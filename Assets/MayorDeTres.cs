using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MayorDeTres : MonoBehaviour
{
    public int numero1;
    public int numero2;
    public int numero3; 

    // Start is called before the first frame update
    void Start()
    {
        if (numero1 == numero2 || numero2 == numero3)
        {

            Debug.Log("Sus tres números son iguales");


        }
        else
        {
           
            if (numero1 > numero2 || numero1 > numero3)
                Debug.Log("El mayor es el "+numero1);

           else if (numero2 > numero1 || numero2 > numero3)
                Debug.Log("El mayor es el " +numero2);

            else 
                Debug.Log("El mayor es el " +numero3);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
