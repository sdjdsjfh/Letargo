using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscenaCollider : MonoBehaviour
{
    public int numeroEscena;

    private void OnTriggerEnter(Collider other) 
    {
        if(other.tag == "Player")
        {
            SceneManager.LoadScene(numeroEscena);
        }

    }

}