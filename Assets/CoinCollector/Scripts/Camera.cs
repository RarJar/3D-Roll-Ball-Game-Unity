using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject sphere;
    Vector3 newPosition;

    void Start()
    {
        newPosition = transform.position - sphere.transform.position;
    }

    void Update()
    {
        transform.position = sphere.transform.position + newPosition;
    }
}
