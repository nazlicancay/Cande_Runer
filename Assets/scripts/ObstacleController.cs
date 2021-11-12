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
        
        Debug.Log("Euler angles inside if " + transform.rotation.eulerAngles.y);
        if (_rotateRight)
        {
            transform.RotateAround(transform.position, Vector3.up, -20 * Time.deltaTime);
        }
        else if(!_rotateRight)
        {
            transform.RotateAround(transform.position, Vector3.up, 20 * Time.deltaTime);
        }
    }
    //
    // public void LoopRotateCycle()
    // {
    //     _rotateRight = true;
    //     Invoke(nameof(RotateLeft),4);
    // }
    //
    // public void RotateLeft()
    // {
    //     _rotateRight = false;
    //     Invoke(nameof(LoopRotateCycle),4);
    // }

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

    public void ObstacleMovement()
    {
        Debug.Log(transform.rotation.y);
        if (transform.rotation.y < 0.3)
        {
            transform.RotateAround(transform.position, Vector3.up, 20 * Time.deltaTime);
            once = true;
        }

        if(once)
        {
            transform.RotateAround(transform.position, Vector3.up, -20 * Time.deltaTime);
        }

        if (transform.position.x > 0.5)
        {
            once = false;
        }
        
    }

    }




