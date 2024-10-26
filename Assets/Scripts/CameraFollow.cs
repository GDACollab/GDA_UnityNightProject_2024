using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    [SerializeField] private GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.position = Player.gameObject.transform.position + new Vector3(0f, 5f, -5f);
        this.gameObject.transform.LookAt(Player.transform);
    }
}
