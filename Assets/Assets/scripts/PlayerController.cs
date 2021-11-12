using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.iOS;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float rotateSpeed = 2;
    [SerializeField] float movementSpeed = 0.01f;
    float _rotateScale = 0;
    float _movementSide = 0;

    private float _objectHight = 20;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _rotateScale = Input.GetAxis("Horizontal");
        _movementSide = Input.GetAxis("Vertical");
        Vector3 movementVector = new Vector3(_rotateScale, 0, _movementSide).normalized;
        
        transform.Translate(-movementSpeed*movementVector*Time.deltaTime);
       
        
    }

   
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("candle"))
        {
            Debug.Log("collision");
            Destroy(other.gameObject);
            HightIncrase();
        }

        if (other.gameObject.CompareTag("obstacle"))
        {
            Debug.Log("engele çarpma");
            HightDecrase();
            
        }
        
       
       
    }
    
    public void HightIncrase()
    {
        _objectHight+=10;
       gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x, _objectHight, gameObject.transform.localScale.z);
        
    }
    
    
    public void HightDecrase()
    {
        _objectHight-=10;
       gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x, _objectHight, gameObject.transform.localScale.z);
        
    }
}

