using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public struct Cube
{
    public Vector3 position;

    public Color color;

}

public class ComputeShaderTest2 : MonoBehaviour
{
    public ComputeShader computeShader;

    public RenderTexture renderTexture;

    public Mesh mesh;

    public Material material;

    public int count = 50;

    public int repetitions = 1;

    List<GameObject> objects;

    Cube[] data;

    public void CreateCubes()
    {
        objects = new List<GameObject>();


    }
}
