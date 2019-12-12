using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchStage : MonoBehaviour
{
    public GameObject level1;
    public GameObject level2;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            if (level1.activeSelf)
            {
                level1.SetActive(false);

            } else
            {
                level1.SetActive(true);
            }
        }

        if (Input.GetKey(KeyCode.B))
        {
            if (level2.activeSelf)
            {
                level2.SetActive(false);

            } else
            {
                level2.SetActive(true);
            }
        }
    }
}
