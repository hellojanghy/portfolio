using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Makebuilding : MonoBehaviour
{
    public GameObject building;
    public float timeDiff;
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > timeDiff)
        {
            GameObject newbuilding = Instantiate(building);
            newbuilding.transform.position = new Vector3(2, Random.Range (-1.2f, 4f), 0);
            timer = 0;
            Destroy(newbuilding, 8.0f);
        }
       
    }
}
