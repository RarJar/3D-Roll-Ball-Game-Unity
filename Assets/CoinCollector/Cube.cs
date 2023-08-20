using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Cube : MonoBehaviour
{
    // Start is called before the first frame update
    float x = 0;
    public float speed = 0;
    public int scaleX = 1;

    Transform cubeTransform;
    void Start()
    {
        cubeTransform = GetComponent<Transform>();
        cubeTransform.localScale=new Vector3 (scaleX, 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        x += 1 * speed;
        cubeTransform.position = new Vector3(x, 1, 1);

        cubeTransform.Rotate(0.1f, 0.1f, 0.1f);
        cubeTransform.Translate(0.01f,0,0);
    }
}
