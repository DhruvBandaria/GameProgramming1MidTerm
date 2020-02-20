using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 1f);
        float rand1, rand2;
        rand1 = Random.Range(1, 50);
        rand2 = Random.Range(1, 50);
        GetComponent<Rigidbody2D>().AddForce(new Vector2(rand1,rand2));
    }
}
