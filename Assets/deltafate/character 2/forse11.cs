using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forse11 : MonoBehaviour
{
    public bool vc; 
    public bool vc3;
    public Vector2 vc2;
    public Vector2 vc21;
    public int dist;
    public int type = 1;
    public int forse;
    public float tic;
    public int s = 1;
    
    private void Start()
    {
        
        vc21 = new Vector2(transform.position.x, transform.position.y);
    }
    
    void Update()
    {
        forse += 4;
        tic += 2 * Time.deltaTime;
        if (tic >= 1)
        {
            vc2.x = Random.Range(-2f / s, 2f / s); 
            vc2.y = Random.Range(-2f / s, 2f / s);
            tic = 0;
        }

            GetComponent<Rigidbody2D>().velocity = vc2 * forse;
            
        

    }
}
