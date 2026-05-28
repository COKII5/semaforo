using UnityEngine;

public class Semaforo : MonoBehaviour
{
    public GameObject rojo;
    public GameObject amarillo;
    public GameObject verde;

    public GameObject peatRojo;
    public GameObject peatVerde;

    bool estado = false;

    public void Cambiar()
    {
        estado = !estado;

        if (estado)
        {
            rojo.SetActive(false);
            amarillo.SetActive(false);
            verde.SetActive(true);

            peatRojo.SetActive(true);
            peatVerde.SetActive(false);
        }
        else
        {
            rojo.SetActive(true);
            amarillo.SetActive(false);
            verde.SetActive(false);

            peatRojo.SetActive(false);
            peatVerde.SetActive(true);
        }
    }
}