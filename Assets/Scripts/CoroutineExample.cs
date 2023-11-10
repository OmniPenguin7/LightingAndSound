using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Wait(5));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator Wait(float waitAmount)
    {
        yield return new WaitForSeconds(waitAmount);
        Debug.Log("Timer Ended");
    }
}
