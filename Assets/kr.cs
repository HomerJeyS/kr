using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kr : MonoBehaviour
{
    public GameObject Cube;

    public GameObject Example;

    public Transform SpawnPoint;

    public Transform SpawnPoint1;

    public Material NewMat;

    public Material NewMat1;

    public Material NewMat2;

    private int i = 1;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            i += 1;
        }

        while (i / 2 == 1)
        {
            //Для объекта
            if (Input.GetKeyDown(KeyCode.I))
            {
                Cube = Instantiate(Example, SpawnPoint1.position, SpawnPoint1.rotation, transform);
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Destroy(Cube);
            }

            if (Input.GetKeyDown(KeyCode.D))
            {
                Cube.SetActive(false);
            }

            if (Input.GetKeyDown(KeyCode.E))
            {
                Cube.SetActive(true);
            }
        }

        while (i / 2 != 1)
        {
            //Для компонента
            if (Input.GetKeyDown(KeyCode.I))
            {
                Cube.GetComponent<MeshRenderer>().material = NewMat;
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Destroy(Cube.GetComponent<MeshRenderer>());
            }

            if (Input.GetKeyDown(KeyCode.D))
            {
                Cube.GetComponent<MeshRenderer>().enabled = false;
            }

            if (Input.GetKeyDown(KeyCode.E))
            {
                Cube.GetComponent<MeshRenderer>().enabled = true;
            }
        }
    }

    void Obj()
    {
        //Для объекта
        if (Input.GetKeyDown(KeyCode.I))
        {
            Cube = Instantiate(Example, SpawnPoint1.position, SpawnPoint1.rotation, transform);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(Cube);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Cube.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            Cube.SetActive(true);
        }
    }

    void Comp()
    {
        //Для компонента
        if (Input.GetKeyDown(KeyCode.I))
        {
            Cube.GetComponent<MeshRenderer>().material = NewMat;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(Cube.GetComponent<MeshRenderer>());
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Cube.GetComponent<MeshRenderer>().enabled = false;
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            Cube.GetComponent<MeshRenderer>().enabled = true;
        }
    }
}
