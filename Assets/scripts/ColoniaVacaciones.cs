using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColoniaVacaciones : MonoBehaviour
{
    public int inscriptosJuveniles;
    public int inscriptosInfantiles;
    private int profesJuveniles;
    private int profesInfantiles;
    private int cordinadores;
    private int listaDeEspera;
    // Start is called before the first frame update
    void Start()
    {
        //verificación de errores
        if (inscriptosInfantiles < 0 || inscriptosJuveniles < 0)
        {
            Debug.Log("ERROR: los números ingresados deben ser positivos");
            return;
        }
        if (inscriptosInfantiles > 100 || inscriptosJuveniles > 100)
        {
            Debug.Log("ERROR: los números ingresados deben ser menores a 100");
            return;
        }
        //Procesamiento de datos
        profesInfantiles = inscriptosInfantiles / 10;
        profesJuveniles = inscriptosJuveniles / 20;
        if ((profesInfantiles + profesJuveniles) % 5 != 0)
        {
            cordinadores = (profesInfantiles + profesJuveniles / 5) + 1;
        }
        else
        {
            cordinadores = (profesInfantiles + profesJuveniles / 5);
        }
        listaDeEspera = (inscriptosInfantiles % 10) + (inscriptosJuveniles % 20);
        //Resultados
        Debug.Log("Se necesitan " + profesJuveniles + " profesores para los indcriptos juveniles");
        Debug.Log("Se necesitan " + profesInfantiles + "profesores para los inscriptos infantiles");
        Debug.Log("Se necesitan " + cordinadores + "cordinadores para todos los profesores necesarios");
        Debug.Log("La lista de espera es de " + listaDeEspera + " personas");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
