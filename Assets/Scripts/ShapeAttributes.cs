using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShapeAttributes : MonoBehaviour
{
    /*
    The generated shape will take on attributes which are defined below. 
    The atributes of each are controlled by separate methods in this 
    script (maybe separate scripts?) 
    */
    [SerializeField] GameObject cubeObject;
    [SerializeField] GameObject sphereObject;
    [SerializeField] GameObject cylinderObject;
    
    public TextMeshProUGUI shapeText;
    
    int cubeCount = 0;
    int sphCount = 0;
    int cylCount = 0;

    public void CreateCube()
    {
        shapeText = FindFirstObjectByType<TextMeshProUGUI>(FindObjectsInactive.Include);
        shapeText.gameObject.SetActive(true); // I am a genius 
        Debug.Log(shapeText.text);

        if (cubeCount < 15)
        {
            Instantiate(cubeObject, new Vector3(-2.5f, 8, 0), Quaternion.identity);
            cubeCount++;
        }
        else
        {
            Debug.Log("Too damn many cubes!"); 
        }
    }

    public void CreateSphere()
    {
        if (cubeCount < 15)
        {
            Instantiate(sphereObject, new Vector3(0, 8, 0), Quaternion.identity);
            sphCount++;
        }
        else
        {
            Debug.Log("Too damn many spheres!");
        }
    }

    public void CreateCylinder()
    {
        if (cubeCount < 15)
        {
            Instantiate(cylinderObject, new Vector3(2.5f, 8, 0), Quaternion.identity);
            cylCount++;
        }
        else
        {
            Debug.Log("Too damn many cylinders!");
        }
    }

}
