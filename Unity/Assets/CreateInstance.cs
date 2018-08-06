using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateInstance : MonoBehaviour
{
    public InstanceColor prefab;

    public int createNum = 1;
    public bool changeColor = true;
    public bool changePosition = true;
    public bool changeScale = true;
    public bool changeRotation = true;

    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            for (int i = 0; i < createNum; ++i)
            {
                var ic = Instantiate(prefab);

                if (changeColor)
                {
                    ic.color.r = Random.Range(0.0f, 1.0f);
                    ic.color.g = Random.Range(0.0f, 1.0f);
                    ic.color.b = Random.Range(0.0f, 1.0f);
                }

                if (changePosition)
                {
                    ic.transform.position = new Vector3(Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f));
                }

                if (changeScale)
                {
                    ic.transform.localScale = new Vector3(Random.Range(0.1f, 2.0f), Random.Range(0.1f, 2.0f), Random.Range(0.1f, 2.0f));
                }

                if (changeRotation)
                {
                    ic.transform.transform.rotation = Quaternion.Euler(Random.Range(0.0f, 360.0f), Random.Range(0.0f, 360.0f), Random.Range(0.0f, 360.0f));
                }
            }
        }
    }
}
