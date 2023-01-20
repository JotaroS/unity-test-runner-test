using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using System;
using UnityEngine.SceneManagement;
public class NewTestScript
{
    public Vector3 initialSpherePosition;
    public GameObject sphereObject;
    public GameObject cubeObject;

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator T001_SetupScene(){
        // before the test, load the scene
        SceneManager.LoadScene("SampleScene");
        yield return null; // skip a frame
        // after loading the scene at the first frame.
        cubeObject = GameObject.Find("Cube");
        sphereObject = GameObject.Find("Player");

        // if cube exists
        Assert.IsNotNull(cubeObject);
        Assert.IsNotNull(sphereObject);
    }



    [UnityTest]
    public IEnumerator T002_IsCubeHitBySphere()
    {
        yield return new WaitForSeconds(2f); // wait for 4s
        Assert.IsTrue(cubeObject.GetComponent<MyCubeController>().isHit);

    }

    [UnityTest]
    public IEnumerator T003_IsSphereMoving(){
        // if sphere exists
        Assert.IsNotNull(sphereObject);
        yield return null;
        // if sphere is not initially hit
    }
}
