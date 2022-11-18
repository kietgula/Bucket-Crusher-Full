using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlSaw : MonoBehaviour
{
    [SerializeField]float moveSpeed;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb=this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(horizontalInput, verticalInput, 0) * moveSpeed * Time.deltaTime);
    }
}
