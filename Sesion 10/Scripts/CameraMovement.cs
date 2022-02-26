using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform target;
    Vector3 offset; // es la diferencia entre el transform de la camara y el transform
                    // del target, para que vayan siempre con la misma diferencia
    public float smoothing = 5f;
    
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - target.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //transform.position = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, target.position + offset, smoothing * Time.deltaTime);
    }
}
