using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestController : MonoBehaviour
{
    [SerializeField] private GameObject Star;
    [SerializeField] private Sprite OpenedChest;
    [SerializeField] private GameObject Spawner;

    private SpriteRenderer sr;
    private bool isChestOpened=false;
    private bool isPressingKey=false;
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.E))
        {
            if (isPressingKey)
            {
                isChestOpened = true;
            }
            //Debug.Log("abcd");
        }
        if (isChestOpened)
        {
           
                Instantiate(Star, 
                    new Vector3(Spawner.transform.position.x, Spawner.transform.position.y, Spawner.transform.position.z),
                    Spawner.transform.rotation);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        isPressingKey = true;
    }
}
