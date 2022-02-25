using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerV1 : MonoBehaviour {

    bool canJump = false;
    // Start is called before the first frame update
    void Start() {
        // gameObject.GetComponent<Transform>().position = new Vector3(20, 0, 0);
        // Vector3 initialPosition = gameObject.transform.position;
        // Debug.Log("initial " + initialPosition);
        // Debug.Log("initial X " + initialPosition.x);
        // gameObject.transform.position = new Vector3(initialPosition.x + 20, initialPosition.y, initialPosition.z);
        // gameObject.transform.position = new Vector3(gameObject.transform.position.x + 20, gameObject.transform.position.y, gameObject.transform.position.z);
    }

    // Update is called once per frame
    void Update() {
        Vector3 initialPosition = gameObject.transform.position;
        float tdt = Time.deltaTime;
        // gameObject.transform.position = new Vector3(initialPosition.x + 50f * tdt, initialPosition.y, initialPosition.z);
        
        if (Input.GetKey("left")) {
            gameObject.transform.Translate(-50f * tdt, 0, 0);
        }
        if (Input.GetKey("right")) {
            gameObject.transform.Translate(50f * tdt, 0, 0);
        }
        ManageJump(initialPosition, tdt);
    }

    void ManageJump(Vector3 initialPosition, float tdt) {
        if (initialPosition.y <= 0) {
            canJump = true;
        }
        if (Input.GetKey("up") && canJump == true && initialPosition.y < 10) {
            gameObject.transform.Translate(0, 50f * tdt, 0);
        }
        else {
            canJump = false;

            if (initialPosition.y > 0) {
                gameObject.transform.Translate(0, -50f * tdt, 0);
            }
        }
    }
}
