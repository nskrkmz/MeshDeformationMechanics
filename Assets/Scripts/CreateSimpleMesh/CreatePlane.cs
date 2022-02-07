using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(
    typeof(MeshRenderer),
    typeof(MeshFilter)
    )]
public class CreatePlane : MonoBehaviour, IMeshCreatable
{
    Vector3[] vertices;
    int[] triangles;

    Mesh mesh;

    void Start()
    {
        mesh = GetComponent<MeshFilter>().mesh;

        CreateMeshData();
        CreateMesh();
        GetComponent<MeshRenderer>().material = new Material(Shader.Find("Diffuse"));

    }

    public void CreateMeshData()
    {
        vertices = new Vector3[]{
            Vector3.zero,                       //0,0,0
            Vector3.forward,                    //0,0,1
            Vector3.right,                      //1,0,0
            Vector3.right + Vector3.forward     //1,0,1
        };

        triangles = new int[]{
            0,1,2,1,3,2
        };
    }

    public void CreateMesh()
    {
        mesh.Clear();
        mesh.vertices = vertices;
        mesh.triangles = triangles;

        mesh.RecalculateNormals();
    }

}
