using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Create 2 variables to use the unity nuilt in axes
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        //Create our movement vector
        Vector2 postition = transform.position;

        //create horizontal and vertical movement
        postition.x = postition.x + 3.0f * horizontal * Time.deltaTime;
        postition.y = postition.y + 3.0f * vertical * Time.deltaTime;

        //setting the new position
        transform.position = postition;
    }
}
