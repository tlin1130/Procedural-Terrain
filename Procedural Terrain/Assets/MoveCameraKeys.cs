using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCameraKeys : MonoBehaviour {

    [SerializeField]
    private float speed = 10.0f;

    // Update is called once per frame
    void Update() {

        if (Input.GetKey(KeyCode.D)) {
            transform.position += Vector3.right * Time.deltaTime * speed;
        }

        if (Input.GetKey(KeyCode.A)) {
            transform.position += Vector3.left * Time.deltaTime * speed;
        }

        if (Input.GetKey(KeyCode.W)) {
            transform.position += Vector3.forward * Time.deltaTime * speed;
        }

        if (Input.GetKey(KeyCode.S)) {
            transform.position += Vector3.back* Time.deltaTime * speed;
        }

        if (Input.GetKey(KeyCode.UpArrow)) {
            transform.position += Vector3.up * Time.deltaTime * speed;
        }

        if (Input.GetKey(KeyCode.DownArrow)){
            transform.position += Vector3.down * Time.deltaTime * speed;
        }
    }
}
