using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float rotateSpeed = 2;
    [SerializeField] float movementSpeed = 0.01f;
    float rotateScale = 0;
    float movementSide = 0;

    private float objectHight = 20;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotateScale = Input.GetAxis("Horizontal");
        movementSide = Input.GetAxis("Vertical");
        Vector3 movementVector = new Vector3(rotateScale, 0, movementSide).normalized;
        
        transform.Translate(-movementSpeed*movementVector*Time.deltaTime);
       // transform.Rotate(0, rotateSpeed*rotateScale * Time.deltaTime, 0);
       // transform.Translate(0,0,-movementSpeed*movementSide * Time.deltaTime);
        
    }

   
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("candle"))
        {
            Debug.Log("collision");
            Destroy(other.gameObject);
            CollactableAdd();
        }
       
    }
    
    public void CollactableAdd()
    {
        objectHight+=10;
       gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x, objectHight, gameObject.transform.localScale.z);
        
    }
}

