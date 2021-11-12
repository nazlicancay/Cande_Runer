using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    // Start is called before the first frame update
    public bool once = false;
    private bool _rotateRight = true;
    public bool trueExpression = true;
    void Start()
    {
        //LoopRotateCycle();
        StartCoroutine(StartRotating());

    }

    // Update is called once per frame
    void Update()
    {
        
     
        if (_rotateRight)
        {
            transform.RotateAround(transform.position, Vector3.up, -20 * Time.deltaTime);
        }
        else if(!_rotateRight)
        {
            transform.RotateAround(transform.position, Vector3.up, 20 * Time.deltaTime);
        }
    }


    IEnumerator StartRotating()
    {
        while (trueExpression)
        {
            yield return new WaitForSeconds(4f);
            _rotateRight = false;
            yield return new WaitForSeconds(4f);
            _rotateRight = true;
        }
        
    }

    

    }




