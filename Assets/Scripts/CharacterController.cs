using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [Header("Movement Controls")]
    [Range(0, 1)]
    public float globalSpeedScale = .1f;
    [Range(0, 10)]
    public float horizontalSpeedScale = 1f;
    [Range(0, 10)]
    public float verticalSpeedScale = 1f;
    
    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput * horizontalSpeedScale * globalSpeedScale, verticalInput * verticalSpeedScale * globalSpeedScale, 0);

        this.gameObject.transform.position = this.gameObject.transform.position + movement;


    }
}
