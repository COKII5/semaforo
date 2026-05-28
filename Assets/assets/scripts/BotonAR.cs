using UnityEngine;

public class BotonAR : MonoBehaviour
{
    public Semaforo semaforo;

    void OnMouseDown()
    {
        semaforo.Cambiar();
    }
}