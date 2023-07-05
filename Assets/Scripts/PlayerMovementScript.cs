using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float playerSpeed = 10.0f;
    public float playerRotationSpeed = 100.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float translation = Input.GetAxis("Vertical") * playerSpeed * Time.deltaTime;
        float rotation = Input.GetAxis("Horizontal") * playerRotationSpeed * Time.deltaTime;

        transform.Translate(0, 0, translation);

        transform.Rotate(0, rotation, 0);
    }
}
