using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KinematicScript : MonoBehaviour
{
    private Vector3 start;
    [SerializeField]
    private float frequency = 5f;

    [SerializeField]
    private float magnitude = 5f;

    [SerializeField]
    private float offset = 0f;

    // Start is called before the first frame update
    void Start()
    {
        start = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = start + transform.right * Mathf.Sin(Time.time + frequency + offset) * magnitude;
    }
}
