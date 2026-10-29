using UnityEngine;

public class LifeCycleLogger : MonoBehaviour
{
    //Awake è eseguito solo alla prima attivazione dell'oggetto 
    void Awake()
    {
        Debug.Log($"Eseguo Awake {gameObject.name}");
    }

    //OnEnable è eseguito a ogni riattivazione dell'oggetto
    void OnEnable()
    {
        Debug.Log($"Eseguo OnEnable {gameObject.name}");
    }

    // Start è eseguito solo al primo avvio della scena
    void Start()
    {
        Debug.Log($"Eseguo Start {gameObject.name}");
    }

    // Update è chiamato ad ogni frame
    void Update()
    {
        Debug.Log($"Eseguo Update {gameObject.name}");
    }

    //FixedUpdate è chiamato a intervalli fissi mentre l'oggetto è attivo (calcoli fisici)
    void FixedUpdate()
    {
        Debug.Log($"Eseguo FixedUpdate {gameObject.name}");
    }

    //LateUpdate è chiamato al termine del ciclo Update/FixedUpdate come ultimo step del ciclo
    void LateUpdate()
    {
        Debug.Log($"Eseguo LateUpdate {gameObject.name}");
    }

    //OnDisable è chiamato alla disattivazione dell'oggetto
    void OnDisable()
    {
        Debug.Log($"Eseguo OnDisable {gameObject.name}");
    }

    //OnDestroy è chimato alla distruzione dell'oggetto 
    void OnDestroy()
    {
        Debug.Log($"Eseguo OnDestroy {gameObject.name}");
    }
}
