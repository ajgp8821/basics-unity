using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinControllerV1 : MonoBehaviour {

    public ScoreManager scoreManager;

    private void OnTriggerEnter2D(Collider2D collision) {
        /* GameObject scripter = GameObject.Find("Scripter");
        scripter.GetComponent<ScoreManager>().RaiseScore(1);*/
        // scoreManager.RaiseScore(1);
        ScoreManager.scoreManager.RaiseScore(1);

        // gameObject.SetActive(false);
        Destroy(transform.parent.gameObject);
    }
}
