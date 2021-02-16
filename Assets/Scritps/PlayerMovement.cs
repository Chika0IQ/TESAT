
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float rotateSpeed = 150f;


    public GameObject bulletPrefab;
    public GameObject bulletSpawn;
    public GameObject gunappear;

    private bool gun = false;

    // Start is called before the first frame update
    void Start()
    {
        gunappear.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    }

    void PlayerMove()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, Time.deltaTime * -rotateSpeed, 0));
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, Time.deltaTime * rotateSpeed, 0));
        }

        if(Input.GetKey(KeyCode.Mouse0) && gun == true)
        {
            Instantiate(bulletPrefab, bulletSpawn.transform.position, transform.rotation);
        }
        if(Input.GetKey(KeyCode.G))
        {
            gunappear.SetActive(true);
            gun = true;
        }
    }
}
