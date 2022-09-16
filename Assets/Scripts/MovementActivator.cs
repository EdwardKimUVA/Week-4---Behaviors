using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementActivator : MonoBehaviour
{
    [SerializeField] GameObject objectToActivate;

    // Start is called before the first frame update
    void Start()
    {
        objectToActivate.GetComponent<MoveObject>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other){
        objectToActivate.GetComponent<MoveObject>().enabled = true;
    }
    private void OnTriggerExit(Collider other){
        objectToActivate.GetComponent<MoveObject>().enabled = false;
    }
}
