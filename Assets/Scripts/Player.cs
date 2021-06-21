using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float horizontalVelocity = 0;
    //the current displacement rate in which the attached object will be moving horizontally

    float verticalVelocity = 0;
    //the current displacement rate in which the attached object will be moving vertically

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float moveSpeed = 1;
        //Define the speed at which the object moves.

        float horizontalInput = Input.GetAxis("Horizontal");
        //Get the value of the Horizontal input axis.

        float verticalInput = Input.GetAxis("Vertical");
        //Get the value of the Vertical input axis.

        if (horizontalInput == -1)
        {
            if (horizontalVelocity > -10)
            {
                horizontalVelocity += -1;
            }
        }
        if (horizontalInput == 1)
        {
            if (horizontalVelocity < 10)
            {
                horizontalVelocity += 1;
            }
        }
        if (horizontalInput == 0)
        {
            if (horizontalVelocity > 0)
            {
                horizontalVelocity += -1;
            }
            if (horizontalVelocity < 0)
            {
                horizontalVelocity += 1;
            }
        }

        if (verticalInput == -1)
        {
            if (verticalVelocity > -10)
            {
                verticalVelocity += -1;
            }
        }
        if (verticalInput == 1)
        {
            if (verticalVelocity < 10)
            {
                verticalVelocity += 1;
            }
        }

        if (verticalInput == 0)
        {
            if (verticalVelocity > 0)
            {
                verticalVelocity += -1;
            }
            if (verticalVelocity < 0)
            {
                verticalVelocity += 1;
            }
        }


        transform.Translate(new Vector3(horizontalVelocity, verticalVelocity, 0) * moveSpeed * Time.deltaTime);
        //Move the object to XYZ coordinates defined as horizontalInput, 0, and verticalInput respectively.
    }
}
